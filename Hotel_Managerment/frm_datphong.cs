using Hotel_Managerment.Controller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Managerment
{
    public partial class frm_datphong : Form
    {
        BookingController controller = new BookingController();
        CustomerController customer = new CustomerController();
        public frm_datphong()
        {
            InitializeComponent();
        }

        private void LoadDanhSachPhong()
        {
            flp_dsPhong.Controls.Clear();
            DataTable dt = controller.LayTatCaPhong();

            foreach (DataRow row in dt.Rows)
            {
                Button btn = new Button();
                btn.Text = $"Phòng {row["room_id"]}\n{row["status"]}";
                btn.Width = 80;
                btn.Height = 80;
                btn.Tag = row["room_id"];

                string status = row["status"].ToString();

                if (status == "Available")
                    btn.BackColor = Color.LightGreen;
                else if (status == "Occupied")
                    btn.BackColor = Color.OrangeRed;
                else
                    btn.BackColor = Color.Gray;

                btn.Click += BtnRoom_Click;
                flp_dsPhong.Controls.Add(btn);
            }
        }

        private void BtnRoom_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string roomID = btn.Tag.ToString();
            txt_IDPhong.Text = roomID;

            object loaiPhongID = controller.LayLoaiPhongTheoRoomID(roomID);
            if (loaiPhongID != null)
            {
                cb_loaiphong.SelectedValue = Convert.ToInt32(loaiPhongID);
            }

            TinhTongTien();
        }

        private void LoadLoaiPhong()
        {
            cb_loaiphong.DataSource = controller.LayTatCaLoaiPhong();
            cb_loaiphong.DisplayMember = "name";
            cb_loaiphong.ValueMember = "room_type_id";
        }
        private void LoadDanhSachBooking()
        {
            DataTable data = controller.LayDanhSachBooking(); // hàm này cần JOIN RoomType và Room

            dtgv_Booking.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                int i = dtgv_Booking.Rows.Add();
                dtgv_Booking.Rows[i].Cells["Column1"].Value = row["booking_id"];
                dtgv_Booking.Rows[i].Cells["Column2"].Value = row["room_id"];
                dtgv_Booking.Rows[i].Cells["Column3"].Value = row["customer_id"];
                dtgv_Booking.Rows[i].Cells["Column4"].Value = row["room_type"];
                dtgv_Booking.Rows[i].Cells["Column5"].Value = Convert.ToDateTime(row["checkin"]).ToString("dd/MM/yyyy");
                dtgv_Booking.Rows[i].Cells["Column1"].Value = Convert.ToDateTime(row["checkout"]).ToString("dd/MM/yyyy");
                dtgv_Booking.Rows[i].Cells["Column6"].Value = row["total"];
                dtgv_Booking.Rows[i].Cells["Column7"].Value = row["status"];
            }

            dtgv_Booking.ClearSelection();
        }

        private void TinhTongTien()
        {
            if (string.IsNullOrWhiteSpace(txt_IDPhong.Text) || date_Checkin.Value >= date_Checkout.Value)
                return;

            int days = (int)(date_Checkout.Value - date_Checkin.Value).TotalDays;
            if (days == 0) days = 1;

            decimal gia = controller.LayGiaPhong(txt_IDPhong.Text);
            txt_Tongtien.Text = (gia * days).ToString();
        }

        private void btn_Datphong_Click_1(object sender, EventArgs e)
        {
            if (txt_IDPhong.Text == "" || txt_IDKhachhang.Text == "" || txt_Tongtien.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string msg;
            bool added = customer.AddCustomer(
                txt_tenkh.Text.Trim(),
                txt_Gioitinh.Text.Trim(),
                Convert.ToInt32(txt_Tuoi.Text.Trim()),
                txt_DiaChi.Text.Trim(),
                txt_sdt.Text.Trim(),
                out msg
            );

            if (!added && msg.Contains("tồn tại")) // Nếu SĐT đã tồn tại thì lấy ID cũ
            {
                MessageBox.Show("Khách đã tồn tại. Tiếp tục đặt phòng.");
            }
            else if (!added)
            {
                MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int customerID = customer.GetLatestCustomerID();

            bool success = controller.DatPhong(
                txt_IDPhong.Text.Trim(),
                txt_IDKhachhang.Text.Trim(),
                date_Checkin.Value,
                date_Checkout.Value,
                Convert.ToDecimal(txt_Tongtien.Text)
            );

            if (success)
            {
                MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachBooking();
                LoadDanhSachPhong();

                // ✅ Ghi log đặt phòng
                SystemLogController log = new SystemLogController();
                log.GhiLogDatPhong(
                    Convert.ToInt32(txt_IDKhachhang.Text.Trim()),
                    Convert.ToInt32(txt_IDPhong.Text.Trim()),
                    date_Checkin.Value,
                    date_Checkout.Value,
                    Convert.ToDecimal(txt_Tongtien.Text.Trim())
                );

            }
        }



        private void frm_datphong_Load_1(object sender, EventArgs e)
        {
            try
            {
                LoadDanhSachPhong();
                LoadLoaiPhong();
                LoadDanhSachBooking();
                

                date_Checkin.ValueChanged += (s, ev) => TinhTongTien();
                date_Checkout.ValueChanged += (s, ev) => TinhTongTien();

                TinhTongTien();
                MessageBox.Show("Load dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load: " + ex.Message);
            }
        }

        private void txt_Tongtien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
