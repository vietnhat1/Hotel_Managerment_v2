using Hotel_Managerment.Controller;
using System;
using System.Windows.Forms;

namespace Hotel_Managerment
{
    public partial class F_DangNhap : Form
    {
        private LoginController loginController = new LoginController();

        public F_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string role = loginController.Authenticate(txt_DangNhap.Text, txt_MatKhau.Text);

            if (!string.IsNullOrEmpty(role))
            {
                switch (role.ToLower())
                {
                    case "admin":
                        new frm_main().Show();
                        this.Hide();
                        break;
                    case "staff":
                        new frm_Nhanvien().Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Quyền không hợp lệ!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ko", "Thông Báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
