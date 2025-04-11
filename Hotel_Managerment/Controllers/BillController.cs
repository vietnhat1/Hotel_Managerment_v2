using Hotel_Managerment.Model;
using System;
using System.Data;

namespace Hotel_Managerment.Controller
{
    public class BillController
    {
        private BillModel model = new BillModel();

        public DataTable LoadBills() => model.GetAllBills();

        public bool AddBill(int bookingID, decimal total, DateTime created_day)
        {
            return model.AddBill(bookingID, total, created_day);
        }

        public bool UpdateBill(int id,int bookingID, decimal total, DateTime created_day)
        {
            return model.BillExists(id) && model.UpdateBill(id, bookingID, total, created_day);
        }

        public bool DeleteBill(int billID)
        {
            return model.BillExists(billID) && model.DeleteBill(billID);
        }
        public bool ThanhToan(int bookingID, decimal total, DateTime createdAt)
        {
            return model.AddBill(bookingID, total, createdAt);
        }
        public DataTable LayTatCaHoaDon()
        {
            return model.GetAllBills();
        }
        public DataTable LayDanhSachBooking()
        {
            return model.GetBookings();
        }
        public void CapNhatTrangThaiPhong(string bookingID)
        {
            model.UpdateRoomStatusToAvailable(bookingID);
        }
    }
}
