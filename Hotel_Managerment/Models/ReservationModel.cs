using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managerment.Model
{
    internal class ReservationModel
    {
        private readonly LopDungChung ldc = new LopDungChung();

        public bool InsertReservation(string roomID, string customerID, DateTime reservationDate, DateTime expectedCheckin, string status)
        {
            try
            {
                string sql = @"
            INSERT INTO Reservation(room_id, customer_id, reservation_date, expected_checkin, status)
            VALUES(@roomID, @customerID, @reservationDate, @expectedCheckin, @status)";
                using (SqlConnection conn = new SqlConnection(ldc.duongDan))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@roomID", roomID);
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.Parameters.AddWithValue("@reservationDate", reservationDate);
                    cmd.Parameters.AddWithValue("@expectedCheckin", expectedCheckin);
                    cmd.Parameters.AddWithValue("@status", status);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                return UpdateRoomStatus(roomID, status);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đặt phòng trước: " + ex.Message);
                return false;
            }
        }


        public DataTable GetAllReservations()
        {
            string sql = @"
                SELECT r.reservation_id, r.room_id, r.customer_id, rt.name AS room_type,
                       r.reservation_date, r.expected_checkin, r.status
                FROM Reservation r
                JOIN Room ro ON r.room_id = ro.room_id
                JOIN RoomType rt ON ro.room_type_id = rt.room_type_id
                ORDER BY r.reservation_id DESC";
            return ldc.LoadDuLieu(sql);
        }

        public DataTable GetAllRooms()
        {
            return ldc.LoadDuLieu("SELECT * FROM Room");
        }

        public DataTable GetAllRoomTypes()
        {
            return ldc.LoadDuLieu("SELECT room_type_id, name FROM RoomType");
        }

        public object GetRoomTypeID(string roomID)
        {
            return ldc.Scalar($"SELECT room_type_id FROM Room WHERE room_id = {roomID}");
        }

        public bool UpdateRoomStatus(string roomID, string status)
        {
            try
            {
                string sql = "UPDATE Room SET status = @status WHERE room_id = @roomID";
                using (SqlConnection conn = new SqlConnection(ldc.duongDan))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@roomID", roomID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái phòng: " + ex.Message);
                return false;
            }
        }
    }
}
