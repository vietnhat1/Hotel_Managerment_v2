namespace Hotel_Managerment.View
{
    partial class frm_Datphongtruoc
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
            this.label7 = new System.Windows.Forms.Label();
            this.flp_dsPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Datphongtruoc = new System.Windows.Forms.Button();
            this.date_Checkin = new System.Windows.Forms.DateTimePicker();
            this.txt_IDKhachhang = new System.Windows.Forms.TextBox();
            this.txt_IDPhong = new System.Windows.Forms.TextBox();
            this.txt_IDDatphong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date_Ngaydatphong = new System.Windows.Forms.DateTimePicker();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.cb_loaiphong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgv_Reservation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Reservation)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(868, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Ngày đặt phòng";
            // 
            // flp_dsPhong
            // 
            this.flp_dsPhong.BackColor = System.Drawing.Color.Gray;
            this.flp_dsPhong.Location = new System.Drawing.Point(10, 11);
            this.flp_dsPhong.Name = "flp_dsPhong";
            this.flp_dsPhong.Size = new System.Drawing.Size(468, 420);
            this.flp_dsPhong.TabIndex = 47;
            // 
            // btn_Datphongtruoc
            // 
            this.btn_Datphongtruoc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Datphongtruoc.Location = new System.Drawing.Point(975, 124);
            this.btn_Datphongtruoc.Name = "btn_Datphongtruoc";
            this.btn_Datphongtruoc.Size = new System.Drawing.Size(135, 46);
            this.btn_Datphongtruoc.TabIndex = 45;
            this.btn_Datphongtruoc.Text = "Đặt phòng trước";
            this.btn_Datphongtruoc.UseVisualStyleBackColor = false;
            this.btn_Datphongtruoc.Click += new System.EventHandler(this.btn_Datphongtruoc_Click);
            // 
            // date_Checkin
            // 
            this.date_Checkin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Checkin.Location = new System.Drawing.Point(992, 48);
            this.date_Checkin.Name = "date_Checkin";
            this.date_Checkin.Size = new System.Drawing.Size(136, 22);
            this.date_Checkin.TabIndex = 42;
            // 
            // txt_IDKhachhang
            // 
            this.txt_IDKhachhang.Location = new System.Drawing.Point(696, 83);
            this.txt_IDKhachhang.Name = "txt_IDKhachhang";
            this.txt_IDKhachhang.Size = new System.Drawing.Size(124, 22);
            this.txt_IDKhachhang.TabIndex = 41;
            // 
            // txt_IDPhong
            // 
            this.txt_IDPhong.Location = new System.Drawing.Point(696, 48);
            this.txt_IDPhong.Name = "txt_IDPhong";
            this.txt_IDPhong.Size = new System.Drawing.Size(124, 22);
            this.txt_IDPhong.TabIndex = 40;
            // 
            // txt_IDDatphong
            // 
            this.txt_IDDatphong.Location = new System.Drawing.Point(696, 13);
            this.txt_IDDatphong.Name = "txt_IDDatphong";
            this.txt_IDDatphong.Size = new System.Drawing.Size(124, 22);
            this.txt_IDDatphong.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(868, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Check In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "ID Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID Đặt phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(868, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Trạng thái";
            // 
            // date_Ngaydatphong
            // 
            this.date_Ngaydatphong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Ngaydatphong.Location = new System.Drawing.Point(992, 13);
            this.date_Ngaydatphong.Name = "date_Ngaydatphong";
            this.date_Ngaydatphong.Size = new System.Drawing.Size(136, 22);
            this.date_Ngaydatphong.TabIndex = 52;
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Location = new System.Drawing.Point(992, 83);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(136, 24);
            this.cb_trangthai.TabIndex = 53;
            // 
            // cb_loaiphong
            // 
            this.cb_loaiphong.FormattingEnabled = true;
            this.cb_loaiphong.Location = new System.Drawing.Point(696, 124);
            this.cb_loaiphong.Name = "cb_loaiphong";
            this.cb_loaiphong.Size = new System.Drawing.Size(124, 24);
            this.cb_loaiphong.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Loại phòng";
            // 
            // dtgv_Reservation
            // 
            this.dtgv_Reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Reservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtgv_Reservation.Location = new System.Drawing.Point(484, 178);
            this.dtgv_Reservation.Name = "dtgv_Reservation";
            this.dtgv_Reservation.RowHeadersWidth = 51;
            this.dtgv_Reservation.RowTemplate.Height = 24;
            this.dtgv_Reservation.Size = new System.Drawing.Size(936, 243);
            this.dtgv_Reservation.TabIndex = 57;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Reservation ID";
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
            this.Column4.HeaderText = "RoomType";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Reservation Date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Check In";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Status";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // frm_Datphongtruoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 450);
            this.Controls.Add(this.dtgv_Reservation);
            this.Controls.Add(this.cb_loaiphong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_trangthai);
            this.Controls.Add(this.date_Ngaydatphong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flp_dsPhong);
            this.Controls.Add(this.btn_Datphongtruoc);
            this.Controls.Add(this.date_Checkin);
            this.Controls.Add(this.txt_IDKhachhang);
            this.Controls.Add(this.txt_IDPhong);
            this.Controls.Add(this.txt_IDDatphong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Datphongtruoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Đặt phòng trước";
            this.Load += new System.EventHandler(this.frm_Datphongtruoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Reservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flp_dsPhong;
        private System.Windows.Forms.Button btn_Datphongtruoc;
        private System.Windows.Forms.DateTimePicker date_Checkin;
        private System.Windows.Forms.TextBox txt_IDKhachhang;
        private System.Windows.Forms.TextBox txt_IDPhong;
        private System.Windows.Forms.TextBox txt_IDDatphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.DateTimePicker date_Ngaydatphong;
        private System.Windows.Forms.ComboBox cb_trangthai;
        private System.Windows.Forms.ComboBox cb_loaiphong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgv_Reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}