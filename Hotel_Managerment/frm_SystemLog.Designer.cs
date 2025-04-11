
namespace Hotel_Managerment
{
    partial class frm_SystemLog
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_BillLog = new System.Windows.Forms.Button();
            this.btn_UserLog = new System.Windows.Forms.Button();
            this.btn_Roomlog = new System.Windows.Forms.Button();
            this.dgrv_log = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_log)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1269, 122);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "\r\nQuản Lý Log";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_BillLog
            // 
            this.btn_BillLog.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_BillLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BillLog.Location = new System.Drawing.Point(191, 172);
            this.btn_BillLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BillLog.Name = "btn_BillLog";
            this.btn_BillLog.Size = new System.Drawing.Size(117, 95);
            this.btn_BillLog.TabIndex = 1;
            this.btn_BillLog.Text = "Bill Log";
            this.btn_BillLog.UseVisualStyleBackColor = false;
            this.btn_BillLog.Click += new System.EventHandler(this.btn_BillLog_Click);
            // 
            // btn_UserLog
            // 
            this.btn_UserLog.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_UserLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserLog.Location = new System.Drawing.Point(574, 172);
            this.btn_UserLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_UserLog.Name = "btn_UserLog";
            this.btn_UserLog.Size = new System.Drawing.Size(117, 95);
            this.btn_UserLog.TabIndex = 2;
            this.btn_UserLog.Text = "User Log";
            this.btn_UserLog.UseVisualStyleBackColor = false;
            this.btn_UserLog.Click += new System.EventHandler(this.btn_UserLog_Click);
            // 
            // btn_Roomlog
            // 
            this.btn_Roomlog.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Roomlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Roomlog.Location = new System.Drawing.Point(987, 172);
            this.btn_Roomlog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Roomlog.Name = "btn_Roomlog";
            this.btn_Roomlog.Size = new System.Drawing.Size(117, 95);
            this.btn_Roomlog.TabIndex = 3;
            this.btn_Roomlog.Text = " Room Status Log";
            this.btn_Roomlog.UseVisualStyleBackColor = false;
            this.btn_Roomlog.Click += new System.EventHandler(this.btn_Roomlog_Click);
            // 
            // dgrv_log
            // 
            this.dgrv_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_log.Location = new System.Drawing.Point(0, 348);
            this.dgrv_log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrv_log.Name = "dgrv_log";
            this.dgrv_log.RowHeadersWidth = 62;
            this.dgrv_log.RowTemplate.Height = 28;
            this.dgrv_log.Size = new System.Drawing.Size(1269, 289);
            this.dgrv_log.TabIndex = 6;
            // 
            // frm_SystemLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 639);
            this.Controls.Add(this.dgrv_log);
            this.Controls.Add(this.btn_Roomlog);
            this.Controls.Add(this.btn_UserLog);
            this.Controls.Add(this.btn_BillLog);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_SystemLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_SystemLog";
            this.Load += new System.EventHandler(this.frm_SystemLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_log)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_BillLog;
        private System.Windows.Forms.Button btn_UserLog;
        private System.Windows.Forms.Button btn_Roomlog;
        private System.Windows.Forms.DataGridView dgrv_log;
    }
}