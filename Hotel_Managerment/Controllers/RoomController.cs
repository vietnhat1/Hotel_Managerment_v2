using Hotel_Managerment.Model;
using System.Data;

namespace Hotel_Managerment.Controller
{
    public class RoomController
    {
        private RoomModel model = new RoomModel();

        public DataTable LoadRooms() => model.GetAllRooms();
        public DataTable LoadRoomTypes() => model.GetAllRoomTypes();

        public bool AddRoom(decimal price, string status, int typeID)
        {
            return model.AddRoom(price, status, typeID);
        }

        public bool UpdateRoom(int id, decimal price, string status, int typeID)
        {
            return model.RoomExists(id) && model.UpdateRoom(id, price, status, typeID);
        }

        public bool DeleteRoom(int id)
        {
            return model.RoomExists(id) && !model.IsRoomBooked(id) && model.DeleteRoom(id);
        }
    }
}