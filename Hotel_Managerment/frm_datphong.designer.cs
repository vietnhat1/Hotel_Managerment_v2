namespace Hotel_Managerment
{
    partial class frm_datphong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Datphong = new System.Windows.Forms.Button();
            this.date_Checkout = new System.Windows.Forms.DateTimePicker();
            this.date_Checkin = new System.Windows.Forms.DateTimePicker();
            this.txt_IDKhachhang = new System.Windows.Forms.TextBox();
            this.txt_IDPhong = new System.Windows.Forms.TextBox();
            this.txt_IDDatphong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Tongtien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_loaiphong = new System.Windows.Forms.ComboBox();
            this.dtgv_Booking = new System.Windows.Forms.DataGridView();
            this.flp_dsPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_Tuoi = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_Gioitinh = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Booking)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Datphong
            // 
            this.btn_Datphong.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Datphong.Location = new System.Drawing.Point(943, 244);
            this.btn_Datphong.Name = "btn_Datphong";
            this.btn_Datphong.Size = new System.Drawing.Size(103, 37);
            this.btn_Datphong.TabIndex = 27;
            this.btn_Datphong.Text = "Đặt phòng";
            this.btn_Datphong.UseVisualStyleBackColor = false;
            this.btn_Datphong.Click += new System.EventHandler(this.btn_Datphong_Click_1);
            // 
            // date_Checkout
            // 
            this.date_Checkout.CustomFormat = "yyyy-MM-dd";
            this.date_Checkout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Checkout.Location = new System.Drawing.Point(812, 119);
            this.date_Checkout.Name = "date_Checkout";
            this.date_Checkout.Size = new System.Drawing.Size(136, 22);
            this.date_Checkout.TabIndex = 25;
            // 
            // date_Checkin
            // 
            this.date_Checkin.CustomFormat = "yyyy-MM-dd";
            this.date_Checkin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Checkin.Location = new System.Drawing.Point(812, 82);
            this.date_Checkin.Name = "date_Checkin";
            this.date_Checkin.Size = new System.Drawing.Size(136, 22);
            this.date_Checkin.TabIndex = 24;
            // 
            // txt_IDKhachhang
            // 
            this.txt_IDKhachhang.Location = new System.Drawing.Point(1117, 14);
            this.txt_IDKhachhang.Name = "txt_IDKhachhang";
            this.txt_IDKhachhang.Size = new System.Drawing.Size(142, 22);
            this.txt_IDKhachhang.TabIndex = 23;
            // 
            // txt_IDPhong
            // 
            this.txt_IDPhong.Location = new System.Drawing.Point(812, 49);
            this.txt_IDPhong.Name = "txt_IDPhong";
            this.txt_IDPhong.Size = new System.Drawing.Size(136, 22);
            this.txt_IDPhong.TabIndex = 22;
            // 
            // txt_IDDatphong
            // 
            this.txt_IDDatphong.Location = new System.Drawing.Point(812, 14);
            this.txt_IDDatphong.Name = "txt_IDDatphong";
            this.txt_IDDatphong.Size = new System.Drawing.Size(136, 22);
            this.txt_IDDatphong.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(716, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Check Out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(716, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Check In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(999, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID Đặt phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(724, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tổng tiền";
            // 
            // txt_Tongtien
            // 
            this.txt_Tongtien.Location = new System.Drawing.Point(812, 203);
            this.txt_Tongtien.Name = "txt_Tongtien";
            this.txt_Tongtien.ReadOnly = true;
            this.txt_Tongtien.Size = new System.Drawing.Size(136, 22);
            this.txt_Tongtien.TabIndex = 33;
            this.txt_Tongtien.TextChanged += new System.EventHandler(this.txt_Tongtien_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(716, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Loại phòng";
            // 
            // cb_loaiphong
            // 
            this.cb_loaiphong.FormattingEnabled = true;
            this.cb_loaiphong.Location = new System.Drawing.Point(812, 159);
            this.cb_loaiphong.Name = "cb_loaiphong";
            this.cb_loaiphong.Size = new System.Drawing.Size(136, 24);
            this.cb_loaiphong.TabIndex = 36;
            // 
            // dtgv_Booking
            // 
            this.dtgv_Booking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Booking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dtgv_Booking.Location = new System.Drawing.Point(486, 288);
            this.dtgv_Booking.Name = "dtgv_Booking";
            this.dtgv_Booking.RowHeadersWidth = 51;
            this.dtgv_Booking.RowTemplate.Height = 24;
            this.dtgv_Booking.Size = new System.Drawing.Size(1037, 269);
            this.dtgv_Booking.TabIndex = 37;
            // 
            // flp_dsPhong
            // 
            this.flp_dsPhong.BackColor = System.Drawing.Color.Gray;
            this.flp_dsPhong.Location = new System.Drawing.Point(12, 12);
            this.flp_dsPhong.Name = "flp_dsPhong";
            this.flp_dsPhong.Size = new System.Drawing.Size(468, 545);
            this.flp_dsPhong.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(999, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 49;
            this.label8.Text = "Tên khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(999, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 50;
            this.label9.Text = "Tuổi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(999, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 51;
            this.label10.Text = "Giới tính";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(999, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 52;
            this.label11.Text = "Địa chỉ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(999, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 16);
            this.label12.TabIndex = 53;
            this.label12.Text = "Số điện thoại";
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(1117, 46);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(142, 22);
            this.txt_tenkh.TabIndex = 54;
            // 
            // txt_Tuoi
            // 
            this.txt_Tuoi.Location = new System.Drawing.Point(1117, 82);
            this.txt_Tuoi.Multiline = true;
            this.txt_Tuoi.Name = "txt_Tuoi";
            this.txt_Tuoi.Size = new System.Drawing.Size(142, 22);
            this.txt_Tuoi.TabIndex = 55;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(1117, 203);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(142, 22);
            this.txt_DiaChi.TabIndex = 56;
            // 
            // txt_Gioitinh
            // 
            this.txt_Gioitinh.Location = new System.Drawing.Point(1117, 117);
            this.txt_Gioitinh.Multiline = true;
            this.txt_Gioitinh.Name = "txt_Gioitinh";
            this.txt_Gioitinh.Size = new System.Drawing.Size(142, 24);
            this.txt_Gioitinh.TabIndex = 57;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(1117, 159);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(142, 24);
            this.txt_sdt.TabIndex = 58;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Booking ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Room ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Customer ID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Room Type";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Check In";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Check Out";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Room Status";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // frm_datphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 569);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_Gioitinh);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_Tuoi);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.flp_dsPhong);
            this.Controls.Add(this.dtgv_Booking);
            this.Controls.Add(this.cb_loaiphong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Tongtien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Datphong);
            this.Controls.Add(this.date_Checkout);
            this.Controls.Add(this.date_Checkin);
            this.Controls.Add(this.txt_IDKhachhang);
            this.Controls.Add(this.txt_IDPhong);
            this.Controls.Add(this.txt_IDDatphong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_datphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.frm_datphong_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Booking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Datphong;
        private System.Windows.Forms.DateTimePicker date_Checkout;
        private System.Windows.Forms.DateTimePicker date_Checkin;
        private System.Windows.Forms.TextBox txt_IDKhachhang;
        private System.Windows.Forms.TextBox txt_IDPhong;
        private System.Windows.Forms.TextBox txt_IDDatphong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Tongtien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_loaiphong;
        private System.Windows.Forms.DataGridView dtgv_Booking;
        private System.Windows.Forms.FlowLayoutPanel flp_dsPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.TextBox txt_Tuoi;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_Gioitinh;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}