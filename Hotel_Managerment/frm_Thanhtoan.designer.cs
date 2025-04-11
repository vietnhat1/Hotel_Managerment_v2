namespace Hotel_Managerment.View
{
    partial class frm_Thanhtoan
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
            this.txt_Tongtien = new System.Windows.Forms.TextBox();
            this.txt_IDPhong = new System.Windows.Forms.TextBox();
            this.txt_IDBill = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flp_dsPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Thanhtoan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.date_ngaytao = new System.Windows.Forms.DateTimePicker();
            this.dtgv_Thanhtoan = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Thanhtoan)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Tongtien
            // 
            this.txt_Tongtien.Location = new System.Drawing.Point(1052, 26);
            this.txt_Tongtien.Name = "txt_Tongtien";
            this.txt_Tongtien.Size = new System.Drawing.Size(124, 22);
            this.txt_Tongtien.TabIndex = 60;
            // 
            // txt_IDPhong
            // 
            this.txt_IDPhong.Location = new System.Drawing.Point(778, 61);
            this.txt_IDPhong.Name = "txt_IDPhong";
            this.txt_IDPhong.Size = new System.Drawing.Size(124, 22);
            this.txt_IDPhong.TabIndex = 59;
            // 
            // txt_IDBill
            // 
            this.txt_IDBill.Location = new System.Drawing.Point(778, 26);
            this.txt_IDBill.Name = "txt_IDBill";
            this.txt_IDBill.Size = new System.Drawing.Size(124, 22);
            this.txt_IDBill.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(972, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "ID Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "ID Bill";
            // 
            // flp_dsPhong
            // 
            this.flp_dsPhong.BackColor = System.Drawing.Color.Gray;
            this.flp_dsPhong.Location = new System.Drawing.Point(19, 15);
            this.flp_dsPhong.Name = "flp_dsPhong";
            this.flp_dsPhong.Size = new System.Drawing.Size(442, 420);
            this.flp_dsPhong.TabIndex = 65;
            // 
            // btn_Thanhtoan
            // 
            this.btn_Thanhtoan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Thanhtoan.Location = new System.Drawing.Point(1026, 98);
            this.btn_Thanhtoan.Name = "btn_Thanhtoan";
            this.btn_Thanhtoan.Size = new System.Drawing.Size(97, 32);
            this.btn_Thanhtoan.TabIndex = 64;
            this.btn_Thanhtoan.Text = "Thanh toán";
            this.btn_Thanhtoan.UseVisualStyleBackColor = false;
            this.btn_Thanhtoan.Click += new System.EventHandler(this.btn_Thanhtoan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(973, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "Ngày tạo";
            // 
            // date_ngaytao
            // 
            this.date_ngaytao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaytao.Location = new System.Drawing.Point(1052, 61);
            this.date_ngaytao.Name = "date_ngaytao";
            this.date_ngaytao.Size = new System.Drawing.Size(124, 22);
            this.date_ngaytao.TabIndex = 72;
            // 
            // dtgv_Thanhtoan
            // 
            this.dtgv_Thanhtoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Thanhtoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtgv_Thanhtoan.Location = new System.Drawing.Point(494, 169);
            this.dtgv_Thanhtoan.Name = "dtgv_Thanhtoan";
            this.dtgv_Thanhtoan.RowHeadersWidth = 51;
            this.dtgv_Thanhtoan.RowTemplate.Height = 24;
            this.dtgv_Thanhtoan.Size = new System.Drawing.Size(929, 266);
            this.dtgv_Thanhtoan.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "Trạng thái";
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Location = new System.Drawing.Point(778, 98);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(121, 24);
            this.cb_trangthai.TabIndex = 75;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Bill ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Booking ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Room ID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Customer ID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Time";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Create At";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // frm_Thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 450);
            this.Controls.Add(this.cb_trangthai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgv_Thanhtoan);
            this.Controls.Add(this.date_ngaytao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Tongtien);
            this.Controls.Add(this.txt_IDPhong);
            this.Controls.Add(this.txt_IDBill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flp_dsPhong);
            this.Controls.Add(this.btn_Thanhtoan);
            this.Name = "frm_Thanhtoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.frm_Thanhtoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Thanhtoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Tongtien;
        private System.Windows.Forms.TextBox txt_IDPhong;
        private System.Windows.Forms.TextBox txt_IDBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flp_dsPhong;
        private System.Windows.Forms.Button btn_Thanhtoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_ngaytao;
        private System.Windows.Forms.DataGridView dtgv_Thanhtoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}