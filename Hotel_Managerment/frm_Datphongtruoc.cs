using Hotel_Managerment.Controller;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_Managerment.View
{
    public partial class frm_Datphongtruoc : Form
    {
        ReservationController controller = new ReservationController();

        public frm_Datphongtruoc()
        {
            InitializeComponent();
        }

        private void frm_Datphongtruoc_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDanhSachPhong();
                LoadLoaiPhong();
                LoadDanhSachDatPhongTruoc();

                cb_trangthai.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_trangthai.Items.AddRange(new string[] { "Pending", "Confirmed" });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
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
            if (sender is Button btn)
            {
                string roomID = btn.Tag.ToString();
                txt_IDPhong.Text = roomID;

                object loaiPhongID = controller.LayLoaiPhongTheoRoomID(roomID);
                if (loaiPhongID != null)
                {
                    cb_loaiphong.SelectedValue = Convert.ToInt32(loaiPhongID);
                }
            }
        }

        private void LoadLoaiPhong()
        {
            cb_loaiphong.DataSource = controller.LayTatCaLoaiPhong();
            cb_loaiphong.DisplayMember = "name";
            cb_loaiphong.ValueMember = "room_type_id";
            cb_loaiphong.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadDanhSachDatPhongTruoc()
        {
            DataTable data = controller.LayTatCaDatPhongTruoc(); // từ ReservationModel JOIN RoomType

            dtgv_Reservation.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                int i = dtgv_Reservation.Rows.Add();
                dtgv_Reservation.Rows[i].Cells["Column1"].Value = row["reservation_id"];
                dtgv_Reservation.Rows[i].Cells["Column2"].Value = row["room_id"];
                dtgv_Reservation.Rows[i].Cells["Column3"].Value = row["customer_id"];
                dtgv_Reservation.Rows[i].Cells["Column4"].Value = row["room_type"];
                dtgv_Reservation.Rows[i].Cells["Column5"].Value = Convert.ToDateTime(row["reservation_date"]).ToString("dd/MM/yyyy");
                dtgv_Reservation.Rows[i].Cells["Column6"].Value = Convert.ToDateTime(row["expected_checkin"]).ToString("dd/MM/yyyy");
                dtgv_Reservation.Rows[i].Cells["Column7"].Value = row["status"];
            }

            dtgv_Reservation.ClearSelection();
        }

        private void CapNhatTrangThaiPhong(string roomID, string newStatus)
        {
            foreach (Control ctrl in flp_dsPhong.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = (Button)ctrl;
                    if (btn.Tag.ToString() == roomID)
                    {
                        if (newStatus == "Available")
                            btn.BackColor = Color.LightGreen;
                        else if (newStatus == "Occupied")
                            btn.BackColor = Color.OrangeRed;
                        else
                            btn.BackColor = Color.Gray;

                        btn.Text = $"Phòng {roomID}\n{newStatus}";
                        break;
                    }
                }
            }
        }

        private void btn_Datphongtruoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_IDPhong.Text) ||
                string.IsNullOrWhiteSpace(txt_IDKhachhang.Text) ||
                string.IsNullOrWhiteSpace(cb_trangthai.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = controller.DatPhongTruoc(
                txt_IDPhong.Text.Trim(),
                txt_IDKhachhang.Text.Trim(),
                date_Ngaydatphong.Value,
                date_Checkin.Value,
                cb_trangthai.Text
            );

            if (success)
            {
                MessageBox.Show("Đặt phòng trước thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachDatPhongTruoc();
                LoadDanhSachPhong();
                CapNhatTrangThaiPhong(txt_IDPhong.Text.Trim(), cb_trangthai.Text);

                SystemLogController log = new SystemLogController();
                log.GhiLogDatPhongTruoc(
                    Convert.ToInt32(txt_IDKhachhang.Text.Trim()),
                    Convert.ToInt32(txt_IDPhong.Text.Trim()),
                    date_Checkin.Value
                );

            }
            else
            {
                MessageBox.Show("Đặt phòng trước thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
