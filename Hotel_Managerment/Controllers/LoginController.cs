using Hotel_Managerment.Model;

namespace Hotel_Managerment.Controller
{
    public class LoginController
    {
        private LoginModel model = new LoginModel();

        public string Authenticate(string username, string password)
        {
            return model.CheckLogin(username, password);
        }
    }
}
