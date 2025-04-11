using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Hotel_Managerment.View;
using Hotel_Managerment.Controller;

namespace Hotel_Managerment
{
    public partial class frm_Nhanvien : Form
    {
       public frm_Nhanvien()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frm_datphong"] == null)
            {
                frm_datphong f = new frm_datphong();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                Application.OpenForms["frm_datphong"].Activate();
            }

        }

        private void đặtPhòngTrướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frm_Datphongtruoc"] == null)
            {
                frm_Datphongtruoc f = new frm_Datphongtruoc();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                Application.OpenForms["frm_Datphongtruoc"].Activate();
            }

        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Thanhtoan"] == null)
            {
                frm_Thanhtoan f = new frm_Thanhtoan();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                Application.OpenForms["frm_Thanhtoan"].Activate();
            }

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DangNhap fs = new F_DangNhap();
            fs.Show();
            this.Visible = false;
        }
    }
}
