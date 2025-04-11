using Hotel_Managerment.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Managerment
{
    public partial class frm_qlKhachHang : Form
    {
        private CustomerController controller = new CustomerController();
        private int selectedCustomerID = -1;
        public frm_qlKhachHang()
        {
            InitializeComponent();
        }

        private void frm_qlKhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void LoadKH()
        {
            dtgv_qlKhachhang.AutoGenerateColumns = false;

            Column1.DataPropertyName = "customer_id";
            Column2.DataPropertyName = "name";
            Column3.DataPropertyName = "gender";
            Column4.DataPropertyName = "age";
            Column5.DataPropertyName = "address";
            Column6.DataPropertyName = "phone";

            dtgv_qlKhachhang.DataSource = controller.LoadCustomers();

            dtgv_qlKhachhang.DataSource = controller.LoadCustomers();
            dtgv_qlKhachhang.ClearSelection();
        }

        private void dtgv_qlKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string msg;
            bool result = controller.AddCustomer(
                txt_tenkh.Text,
                txt_Gioitinh.Text,
                int.Parse(txt_Tuoi.Text),
                txt_DiaChi.Text,
                txt_sdt.Text,
                out msg);

            MessageBox.Show(msg);
            if (result)
                LoadKH();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == -1)
            {
                MessageBox.Show("Vui lòng chọn khách cần sửa.");
                return;
            }

            string msg;
            bool result = controller.UpdateCustomer(
                selectedCustomerID,
                txt_tenkh.Text,
                txt_Gioitinh.Text,
                int.Parse(txt_Tuoi.Text),
                txt_DiaChi.Text,
                txt_sdt.Text,
                out msg);

            MessageBox.Show(msg);
            if (result)
                LoadKH();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa.");
                return;
            }

            string msg;
            bool result = controller.DeleteCustomer(selectedCustomerID, out msg);
            MessageBox.Show(msg);
            if (result)
                LoadKH();
        }

        private void btn_Capnhat_Click(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void dtgv_qlKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_qlKhachhang.Rows.Count)
            {
                var row = dtgv_qlKhachhang.Rows[e.RowIndex];

               
                if (int.TryParse(row.Cells["customer_id"].Value?.ToString(), out int id))
                    selectedCustomerID = id;
                else
                    selectedCustomerID = -1;
                txt_tenkh.Text = row.Cells["name"].Value?.ToString();
                txt_Gioitinh.Text = row.Cells["gender"].Value?.ToString();
                txt_Tuoi.Text = row.Cells["age"].Value?.ToString();
                txt_DiaChi.Text = row.Cells["address"].Value?.ToString();
                txt_sdt.Text = row.Cells["phone"].Value?.ToString();
            }
        }
    }
}