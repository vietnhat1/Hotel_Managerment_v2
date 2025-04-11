using System;
using System.Collections.Generic;
using System.Data;
using Hotel_Managerment;

namespace Hotel_Managerment.Model
{
    public class SystemLogModel
    {
        private readonly LopDungChung db = new LopDungChung();

        // Lấy danh sách log theo loại
        public DataTable GetLogsByType(string logType)
        {
            string query = "SELECT * FROM SystemLog WHERE log_type = @type ORDER BY change_time DESC";
            var param = new Dictionary<string, object> { { "@type", logType } };
            return db.LoadDuLieu(query, param);
        }

        // Xóa log theo ID
        public bool DeleteLogById(int logId)
        {
            string query = "DELETE FROM SystemLog WHERE log_id = @log_id";
            var param = new Dictionary<string, object> { { "@log_id", logId } };
            return db.ExecuteNonQuery(query, param);
        }

        // Ghi log (có xử lý giá trị NULL cho khóa ngoại)
        public bool InsertLog(string logType, int customerID, int roomID, int billID,
                               DateTime checkin, DateTime checkout,
                               string oldStatus, string newStatus,
                               decimal total, string note)
        {
            try
            {
                string sql = @"
                    INSERT INTO SystemLog (
                        log_type, customer_id, room_id, bill_id,
                        checkin, checkout, old_status, new_status, total, note
                    )
                    VALUES (
                        @logType, @customerID, @roomID, @billID,
                        @checkin, @checkout, @oldStatus, @newStatus, @total, @note
                    )";

                var param = new Dictionary<string, object>
                {
                    { "@logType", logType },
                    { "@customerID", customerID == 0 ? (object)DBNull.Value : customerID },
                    { "@roomID", roomID },
                    { "@billID", billID == 0 ? (object)DBNull.Value : billID },
                    { "@checkin", checkin },
                    { "@checkout", checkout },
                    { "@oldStatus", oldStatus },
                    { "@newStatus", newStatus },
                    { "@total", total },
                    { "@note", note }
                };

                return db.ExecuteNonQuery(sql, param);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi ghi SystemLog: " + ex.Message);
                return false;
            }
        }

        // Truy xuất customer_id từ bill_id
        public int GetCustomerIDFromBill(string billID)
        {
            string query = @"
                SELECT bk.customer_id
                FROM Bill b
                JOIN Booking bk ON b.booking_id = bk.booking_id
                WHERE b.bill_id = @billID
            ";

            var param = new Dictionary<string, object> { { "@billID", billID } };
            DataTable dt = db.LoadDuLieu(query, param);

            if (dt.Rows.Count > 0)
                return Convert.ToInt32(dt.Rows[0]["customer_id"]);

            return 0;
        }
    }
}
