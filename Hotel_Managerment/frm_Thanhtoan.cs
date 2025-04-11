using Hotel_Managerment.Controller;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace Hotel_Managerment.View
{
    public partial class frm_Thanhtoan : Form
    {
        BillController controller = new BillController();

        public frm_Thanhtoan()
        {
            InitializeComponent();
        }

        private void frm_Thanhtoan_Load(object sender, EventArgs e)
        {
            LoadDanhSachBooking();
            LoadDanhSachHoaDon();

            cb_trangthai.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_trangthai.Items.AddRange(new string[] { "Need Clean", "Ready" });
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DataRow row = (DataRow)btn.Tag;

            txt_IDPhong.Text = row["room_id"].ToString();
            txt_IDBill.Text = row["booking_id"].ToString();
            txt_Tongtien.Text = row["total"].ToString();
            date_ngaytao.Value = DateTime.Now;
        }

        private void LoadDanhSachBooking()
        {
            flp_dsPhong.Controls.Clear();
            DataTable dt = controller.LayDanhSachBooking();

            HashSet<string> addedRooms = new HashSet<string>(); // đảm bảo không trùng room_id

            foreach (DataRow row in dt.Rows)
            {
                string roomID = row["room_id"].ToString();

                // Nếu đã thêm rồi thì bỏ qua
                if (addedRooms.Contains(roomID))
                    continue;

                // Đánh dấu đã thêm
                addedRooms.Add(roomID);

                Button btn = new Button();
                btn.Text = "Phòng " + roomID;
                btn.Width = 80;
                btn.Height = 80;
                btn.Tag = row;
                btn.Click += Btn_Click;
                btn.BackColor = Color.OrangeRed;

                flp_dsPhong.Controls.Add(btn);
            }
        }

        private void LoadDanhSachHoaDon()
        {
            DataTable data = controller.LayTatCaHoaDon();

            dtgv_Thanhtoan.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                int i = dtgv_Thanhtoan.Rows.Add();
                dtgv_Thanhtoan.Rows[i].Cells["Column1"].Value = row["bill_id"];
                dtgv_Thanhtoan.Rows[i].Cells["Column2"].Value = row["booking_id"];
                dtgv_Thanhtoan.Rows[i].Cells["Column3"].Value = row["room_id"];
                dtgv_Thanhtoan.Rows[i].Cells["Column4"].Value = row["customer_id"];
                dtgv_Thanhtoan.Rows[i].Cells["Column5"].Value = row["total_time"];
                dtgv_Thanhtoan.Rows[i].Cells["Column6"].Value = row["total"];
                dtgv_Thanhtoan.Rows[i].Cells["Column7"].Value = Convert.ToDateTime(row["created_at"]).ToString("dd/MM/yyyy HH:mm");
            }

            dtgv_Thanhtoan.ClearSelection();
        }

        private void btn_Thanhtoan_Click(object sender, EventArgs e)
        {
            if (txt_IDBill.Text == "" || txt_Tongtien.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phòng để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = controller.ThanhToan(
     Convert.ToInt32(txt_IDBill.Text.Trim()),
     Convert.ToDecimal(txt_Tongtien.Text),
     date_ngaytao.Value
 );


            if (success)
            {
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                controller.CapNhatTrangThaiPhong(txt_IDBill.Text);

                foreach (Control ctrl in flp_dsPhong.Controls)
                {
                    if (ctrl is Button btn && btn.Text.Contains(txt_IDPhong.Text))
                    {
                        flp_dsPhong.Controls.Remove(btn);
                        break;
                    }
                }

                LoadDanhSachHoaDon();

                SystemLogController log = new SystemLogController();
                int customerID = log.GetCustomerIDFromBill(txt_IDBill.Text.Trim());

                log.GhiLogThanhToan(
                    customerID,
                    Convert.ToInt32(txt_IDPhong.Text.Trim()),
                    Convert.ToInt32(txt_IDBill.Text.Trim()),
                    Convert.ToDecimal(txt_Tongtien.Text.Trim())
                );
                log.GhiLogTrangThaiPhong(
                Convert.ToInt32(txt_IDPhong.Text.Trim()),
                "Occupied",
                cb_trangthai.Text.Trim()
                );


                txt_IDBill.Clear();
                txt_IDPhong.Clear();
                txt_Tongtien.Clear();
            }
        }
    }
}