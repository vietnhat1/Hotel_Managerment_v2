using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Managerment.Model
{
    internal class BookingModel
    {
        private readonly LopDungChung ldc = new LopDungChung();

        public bool InsertBooking(string roomID, string customerID, DateTime checkin, DateTime checkout, decimal total)
        {
            using (SqlConnection connection = new SqlConnection(ldc.duongDan))
            {
                SqlTransaction transaction = null;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    string sql = @"
                        INSERT INTO Booking(room_id, customer_id, checkin, checkout, total)
                        VALUES(@roomID, @customerID, @checkin, @checkout, @total)";

                    using (SqlCommand cmd = new SqlCommand(sql, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@roomID", roomID);
                        cmd.Parameters.AddWithValue("@customerID", customerID);
                        cmd.Parameters.AddWithValue("@checkin", checkin);
                        cmd.Parameters.AddWithValue("@checkout", checkout);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.ExecuteNonQuery();
                    }

                    string updateRoom = "UPDATE Room SET status = N'Occupied' WHERE room_id = @roomID";
                    using (SqlCommand cmd = new SqlCommand(updateRoom, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@roomID", roomID);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    MessageBox.Show("Lỗi đặt phòng: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable GetAllBookings()
        {
            string sql = @"
               SELECT 
    b.booking_id,
    b.room_id,
    b.customer_id,
    rt.name AS room_type,
    b.checkin,
    b.checkout,
    b.total,
    r.status
FROM Booking b
JOIN Room r ON b.room_id = r.room_id
JOIN RoomType rt ON r.room_type_id = rt.room_type_id

                ORDER BY b.booking_id DESC";
            return ldc.LoadDuLieu(sql);
        }

        public DataTable GetAllRooms()
        {
            string sql = "SELECT * FROM Room";
            return ldc.LoadDuLieu(sql);
        }

        public DataTable GetAllRoomTypes()
        {
            string sql = "SELECT room_type_id, name FROM RoomType";
            return ldc.LoadDuLieu(sql);
        }

        public decimal GetRoomPrice(string roomID)
        {
            string sql = "SELECT price FROM Room WHERE room_id = @roomID";
            using (SqlConnection conn = new SqlConnection(ldc.duongDan))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@roomID", roomID);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToDecimal(result) : 0;
                }
            }
        }

        public object GetRoomTypeID(string roomID)
        {
            string sql = "SELECT room_type_id FROM Room WHERE room_id = @roomID";
            return ldc.Scalar(sql.Replace("@roomID", roomID));
        }
    }

}