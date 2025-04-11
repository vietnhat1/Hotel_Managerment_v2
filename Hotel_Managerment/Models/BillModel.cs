using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Managerment.Model
{
    public class BillModel
    {
        private LopDungChung db = new LopDungChung();

        public DataTable GetAllBills()
        {
            return db.LoadDuLieu("SELECT a.bill_id,b.booking_id,b.room_id,b.customer_id,DATEDIFF(day,b.checkin, b.checkout) AS total_time,a.total,a.created_at FROM Bill a JOIN Booking b ON b.booking_id = a.booking_id");
        } 
            public bool BillExists(int billID)
        {
            string query = "SELECT COUNT(*) FROM Bill WHERE bill_id = @id";
            var param = new Dictionary<string, object> { { "@id", billID } };
            return Convert.ToInt32(db.Scalar(query, param)) > 0;
        }

        public bool AddBill(int bookingID, decimal total, DateTime created_day)
        {
            string query = @"INSERT INTO Bill (booking_id, total,created_at)
                             VALUES (@booking_id, @total,@created_at)";
            var param = new Dictionary<string, object>
            {
                
                { "@booking_id", bookingID},

                { "@total", total },
                { "@created_at", created_day }
            };
            return db.ExecuteNonQuery(query, param, true);
        }

        public bool UpdateBill(int billID, int bookingID, decimal total,DateTime created_day)
        {
            string query = @"UPDATE Bill SET booking_id = @booking_id, total = @total , created_at =@created_at WHERE bill_id = @bill_id";
            var param = new Dictionary<string, object>
            {
                { "@bill_id", billID },
                { "@booking_id", bookingID },
                { "@total", total },
                {"@created_at", created_day }
            };
            return db.ExecuteNonQuery(query, param);
        }

        public bool DeleteBill(int billID)
        {
            string query = "DELETE FROM Bill WHERE bill_id = @bill_id";
            var param = new Dictionary<string, object> { { "@bill_id", billID } };
            return db.ExecuteNonQuery(query, param);
        }
        public DataTable GetBookings()
        {
            string sql = @"
        SELECT 
    b.booking_id,
    b.room_id,
    b.customer_id,
    DATEDIFF(DAY, b.checkin, b.checkout) AS total_time,
    b.total,
    r.status
FROM Booking b
JOIN Room r ON b.room_id = r.room_id
WHERE r.status = 'Occupied'
";
            return db.LoadDuLieu(sql);
        }
        public void UpdateRoomStatusToAvailable(string bookingID)
        {
            try
            {
                string sql = @"
    UPDATE Room
    SET status = N'Available'
    WHERE room_id = (
        SELECT room_id FROM Booking WHERE booking_id = @bookingID
    )";
                using (SqlConnection conn = new SqlConnection(db.duongDan))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@bookingID", bookingID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái phòng: " + ex.Message);
            }
        }
    }
}
