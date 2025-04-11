using Hotel_Managerment.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Managerment.Controller
{

    public class ReservationController
    {
        private ReservationModel model = new ReservationModel();

        public bool DatPhongTruoc(string roomID, string customerID, DateTime reservationDate, DateTime expectedCheckin, string status)
        {
            return model.InsertReservation(roomID, customerID, reservationDate, expectedCheckin, status);
        }

        public DataTable LayTatCaDatPhongTruoc()
        {
            return model.GetAllReservations();
        }

        public DataTable LayTatCaPhong()
        {
            return model.GetAllRooms();
        }

        public DataTable LayTatCaLoaiPhong()
        {
            return model.GetAllRoomTypes();
        }

        public object LayLoaiPhongTheoRoomID(string roomID)
        {
            return model.GetRoomTypeID(roomID);
        }

        public bool CapNhatPhong(string roomID, string status)
        {
            return model.UpdateRoomStatus(roomID, status);
        }
    }
}

