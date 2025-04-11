using System.Collections.Generic;
using System.Data;

namespace Hotel_Managerment.Model
{
    public class LoginModel
    {
        private LopDungChung lopchung = new LopDungChung();

        public string CheckLogin(string username, string password)
        {
            string query = "SELECT role FROM Users WHERE username = @username AND password = @password";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@username", username },
                { "@password", password }
            };
            object roleObj = lopchung.Scalar(query, parameters);
            return roleObj != null ? roleObj.ToString().Trim() : null;
        }
    }
}
