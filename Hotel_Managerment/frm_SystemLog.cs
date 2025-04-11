using Hotel_Managerment.Controller;
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
    public partial class frm_SystemLog : Form
    {
        private SystemLogController controller = new SystemLogController();
        private int selectedLogID = -1;
        public frm_SystemLog()
        {
            InitializeComponent();
        }

        private void btn_BillLog_Click(object sender, EventArgs e)
        {
            LoadLogs("BillLog");
        }

        private void btn_UserLog_Click(object sender, EventArgs e)
        {
            LoadLogs("UserLog");
        }

        private void btn_Roomlog_Click(object sender, EventArgs e)
        {
            LoadLogs("RoomLog");
        }
        private void LoadLogs(string logType)
        {
            DataTable data = controller.LoadLogs(logType);
            dgrv_log.Columns.Clear();
            dgrv_log.Rows.Clear();

            // 🟦 Cột chung cho tất cả
            dgrv_log.Columns.Add("log_id", "Log ID");
            dgrv_log.Columns.Add("log_type", "Log Type");

            if (logType == "UserLog" || logType == "BillLog")
                dgrv_log.Columns.Add("customer_id", "Customer ID");

            dgrv_log.Columns.Add("room_id", "Room ID");

            if (logType == "BillLog")
                dgrv_log.Columns.Add("bill_id", "Bill ID");

            dgrv_log.Columns.Add("checkin", "Check In");
            dgrv_log.Columns.Add("checkout", "Check Out");
            dgrv_log.Columns.Add("old_status", "Old Status");
            dgrv_log.Columns.Add("new_status", "New Status");
            dgrv_log.Columns.Add("change_time", "Change Time");
            dgrv_log.Columns.Add("total", "Total");
            dgrv_log.Columns.Add("note", "Note");

            // 🟦 Ghi dữ liệu theo đúng thứ tự
            foreach (DataRow row in data.Rows)
            {
                List<object> rowData = new List<object>();

                rowData.Add(row["log_id"]);
                rowData.Add(row["log_type"]);

                if (logType == "UserLog" || logType == "BillLog")
                    rowData.Add(row["customer_id"]);

                rowData.Add(row["room_id"]);

                if (logType == "BillLog")
                    rowData.Add(row["bill_id"]);

                rowData.Add(Convert.ToDateTime(row["checkin"]).ToString("dd/MM/yyyy"));
                rowData.Add(Convert.ToDateTime(row["checkout"]).ToString("dd/MM/yyyy"));
                rowData.Add(row["old_status"]);
                rowData.Add(row["new_status"]);
                rowData.Add(Convert.ToDateTime(row["change_time"]).ToString("dd/MM/yyyy HH:mm"));
                rowData.Add(row["total"]);
                rowData.Add(row["note"]);

                dgrv_log.Rows.Add(rowData.ToArray());
            }

            dgrv_log.ClearSelection();
        }



        private void frm_SystemLog_Load(object sender, EventArgs e)
        {
            dgrv_log.AutoGenerateColumns = true;
            dgrv_log.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrv_log.Rows.Clear();
        }
        
    }
}
