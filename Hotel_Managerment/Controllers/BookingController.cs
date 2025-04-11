using Hotel_Managerment.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Managerment.Controller
{
    public class BookingController
    {
        private BookingModel model = new BookingModel();

        public bool DatPhong(string roomID, string customerID, DateTime checkin, DateTime checkout, decimal total)
        {
            return model.InsertBooking(roomID, customerID, checkin, checkout, total);
        }

        public DataTable LayDanhSachBooking()
        {
            return model.GetAllBookings();
        }

        public DataTable LayTatCaPhong()
        {
            return model.GetAllRooms();
        }

        public DataTable LayTatCaLoaiPhong()
        {
            return model.GetAllRoomTypes();
        }

        public decimal LayGiaPhong(string roomID)
        {
            return model.GetRoomPrice(roomID);
        }

        public object LayLoaiPhongTheoRoomID(string roomID)
        {
            return model.GetRoomTypeID(roomID);
        }
    }
}
