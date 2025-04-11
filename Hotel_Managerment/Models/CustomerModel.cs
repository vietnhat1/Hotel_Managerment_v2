using System;
using System.Collections.Generic;
using System.Data;

namespace Hotel_Managerment.Model
{
    public class CustomerModel
    {
        private LopDungChung db = new LopDungChung();

        public DataTable GetAllCustomers()
        {
            return db.LoadDuLieu("SELECT * FROM Customer ");
        }

        public bool IsCustomerExist(int id)
        {
            var query = "SELECT COUNT(*) FROM Customer WHERE customer_id = @id";
            var param = new Dictionary<string, object> { { "@id", id } };
            return (int)db.ExecuteScalar(query, param) > 0;
        }

        public bool IsPhoneExist(string phone)
        {
            var query = "SELECT COUNT(*) FROM Customer WHERE phone = @phone";
            var param = new Dictionary<string, object> { { "@phone", phone } };
            return (int)db.ExecuteScalar(query, param) > 0;
        }

        public bool AddCustomer(string name, string gender, int age, string address, string phone)
        {
            string query = "INSERT INTO Customer (name, gender, age, address, phone) VALUES (@name, @gender, @age, @address, @phone)";
            var param = new Dictionary<string, object>
            {
                { "@name", name },
                { "@gender", gender },
                { "@age", age },
                { "@address", address },
                { "@phone", phone }
            };
            return db.ExecuteNonQuery(query, param);
        }

        public bool UpdateCustomer(int id, string name, string gender, int age, string address, string phone)
        {
            string query = "UPDATE Customer SET name = @name, gender = @gender, age = @age, address = @address, phone = @phone WHERE customer_id = @id";
            var param = new Dictionary<string, object>
            {
                { "@id", id },
                { "@name", name },
                { "@gender", gender },
                { "@age", age },
                { "@address", address },
                { "@phone", phone }
            };
            return db.ExecuteNonQuery(query, param);
        }

        public bool DeleteCustomer(int id)
        {
            string query = "DELETE FROM Customer WHERE customer_id = @id";
            var param = new Dictionary<string, object> { { "@id", id } };
            return db.ExecuteNonQuery(query, param);
        }
        public int GetLatestCustomerID()
        {
            string query = "SELECT MAX(customer_id) FROM Customer";
            object result = db.Scalar(query);
            return result != null ? Convert.ToInt32(result) : 0;
        }
    }
}
