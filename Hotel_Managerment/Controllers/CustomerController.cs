using Hotel_Managerment.Model;
using System.Data;

namespace Hotel_Managerment.Controller
{
    public class CustomerController
    {
        private CustomerModel model = new CustomerModel();

        public DataTable LoadCustomers() => model.GetAllCustomers();

        public bool AddCustomer(string name, string gender, int age, string address, string phone, out string message)
        {
            if (model.IsPhoneExist(phone))
            {
                message = "Số điện thoại đã tồn tại!";
                return false;
            }

            bool result = model.AddCustomer(name, gender, age, address, phone);
            message = result ? "Thêm khách hàng thành công!" : "Thêm khách hàng thất bại!";
            return result;
        }

        public bool UpdateCustomer(int id, string name, string gender, int age, string address, string phone, out string message)
        {
            if (!model.IsCustomerExist(id))
            {
                message = "Khách hàng không tồn tại!";
                return false;
            }

            bool result = model.UpdateCustomer(id, name, gender, age, address, phone);
            message = result ? "Cập nhật khách hàng thành công!" : "Cập nhật thất bại!";
            return result;
        }

        public bool DeleteCustomer(int id, out string message)
        {
            if (!model.IsCustomerExist(id))
            {
                message = "Khách hàng không tồn tại!";
                return false;
            }

            bool result = model.DeleteCustomer(id);
            message = result ? "Xóa khách hàng thành công!" : "Xóa thất bại!";
            return result;
        }
        public int GetLatestCustomerID()
        {
            return model.GetLatestCustomerID();
        }
    }
}