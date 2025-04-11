using System;
using System.Collections.Generic;
using System.Data;

namespace Hotel_Managerment.Model
{
    public class RoomModel
    {
        private LopDungChung db = new LopDungChung();

        public DataTable GetAllRooms()
        {
            return db.LoadDuLieu("SELECT * FROM Room ");
        }

        public DataTable GetAllRoomTypes()
        {
            return db.LoadDuLieu("SELECT * FROM RoomType");
        }

        public bool RoomExists(int roomID)
        {
            string query = "SELECT COUNT(*) FROM Room WHERE room_id = @id";
            var param = new Dictionary<string, object> { { "@id", roomID } };
            return Convert.ToInt32(db.Scalar(query, param)) > 0;
        }

        public bool IsRoomBooked(int roomID)
        {
            string query = "SELECT COUNT(*) FROM Booking WHERE room_id = @id";
            var param = new Dictionary<string, object> { { "@id", roomID } };
            return Convert.ToInt32(db.Scalar(query, param)) > 0;
        }

        public bool AddRoom(decimal price, string status, int roomTypeID)
        {
            string query = "INSERT INTO Room (price, status, room_type_id) VALUES (@price, @status, @typeID)";
            var param = new Dictionary<string, object>
            {
                { "@price", price },
                { "@status", status },
                { "@typeID", roomTypeID }
            };
            return db.ExecuteNonQuery(query, param, true);
        }

        public bool UpdateRoom(int roomID, decimal price, string status, int roomTypeID)
        {
            string query = "UPDATE Room SET price = @price, status = @status, room_type_id = @typeID WHERE room_id = @id";
            var param = new Dictionary<string, object>
            {
                { "@id", roomID },
                { "@price", price },
                { "@status", status },
                { "@typeID", roomTypeID }
            };
            return db.ExecuteNonQuery(query, param, true);
        }

        public bool DeleteRoom(int roomID)
        {
            string query = "DELETE FROM Room WHERE room_id = @id";
            var param = new Dictionary<string, object> { { "@id", roomID } };
            return db.ExecuteNonQuery(query, param, true);
        }
    }
}