using System;
using System.Collections.Generic;
using System.Data;
using Hotel_Managerment.Model;

namespace Hotel_Managerment.Controller
{
    public class SystemLogController
    {
        private readonly SystemLogModel model = new SystemLogModel();


        public DataTable LoadLogs(string logType)
        {
            return model.GetLogsByType(logType);
        }

        public bool DeleteLog(int logId)
        {
            return model.DeleteLogById(logId);
        }

        public bool GhiLogDatPhong(int customerID, int roomID, DateTime checkin, DateTime checkout, decimal total)
        {
            return model.InsertLog("UserLog", customerID, roomID, 0, checkin, checkout, "Available", "Occupied", total, "Room was checked in");
        }

        public bool GhiLogDatPhongTruoc(int customerID, int roomID, DateTime expectedCheckin)
        {
            return model.InsertLog("UserLog", customerID, roomID, 0, expectedCheckin, expectedCheckin, "Available", "Reservation", 0, "Room was reservation");
        }

        public bool GhiLogThanhToan(int customerID, int roomID, int billID, decimal total)
        {
            return model.InsertLog("BillLog", customerID, roomID, billID, DateTime.Now, DateTime.Now, "Occupied", "Available", total, "Bill generated after checkout");
        }

        public bool GhiLogTrangThaiPhong(int roomID, string oldStatus, string newStatus)
        {
            return model.InsertLog("RoomLog", 0, roomID, 0, DateTime.Now, DateTime.Now, oldStatus, newStatus, 0, newStatus);
        }

        public int GetCustomerIDFromBill(string billID)
        {
            return model.GetCustomerIDFromBill(billID);
        }

       

        
    }
}
