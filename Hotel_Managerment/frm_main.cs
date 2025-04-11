using Hotel_Managerment.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managerment
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }


        private void quảnLýĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_qlPhong"] == null)
            {
                frm_qlPhong fs = new frm_qlPhong();
                fs.MdiParent = this;
                fs.Show();
            }
            else
            {
                Application.OpenForms["frm_qlPhong"].Activate();
            }
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_qlKhachHang"] == null)
            {
                frm_qlKhachHang fs = new frm_qlKhachHang();
                fs.MdiParent = this;
                fs.Show();
            }
            else
            {
                Application.OpenForms["frm_qlKhachHang"].Activate();
            }
        }

        private void quảnLýBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_qlBill"] == null)
            {
                frm_qlBill fs = new frm_qlBill();
                fs.MdiParent = this;
                fs.Show();
            }
            else
            {
                Application.OpenForms["frm_qlBill"].Activate();
            }
        }

    

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DangNhap fs = new F_DangNhap();
            fs.Show();
            this.Visible = false;
        }

        private void qlLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_SystemLog"] == null)
            {
                frm_SystemLog fs = new frm_SystemLog();
                fs.MdiParent = this;
                fs.Show();
            }
            else
            {
                Application.OpenForms["frm_SystemLog"].Activate();
            }
        }

        private void quảnLýĐặtPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frm_datphong"] == null)
            {
                frm_datphong fs = new frm_datphong();
                fs.MdiParent = this;
                fs.Show();
            }
            else
            {
                Application.OpenForms["frm_datphong"].Activate();
            }
        }

        private void quảnLýĐặtPhòngTrướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frm_Datphongtruoc"] == null)
            {
                frm_Datphongtruoc fs = new frm_Datphongtruoc();
                fs.MdiParent = this;
                fs.Show();
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
                frm_Thanhtoan fs = new frm_Thanhtoan();
                fs.MdiParent = this;
                fs.Show();
            }
            else
            {
                Application.OpenForms["frm_Thanhtoan"].Activate();
            }
        }
    }
}
