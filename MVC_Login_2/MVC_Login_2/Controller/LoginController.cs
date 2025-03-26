using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_Login_2.Model;

namespace MVC_Login_2.Controller
{
    public class LoginController
    {
        LoginModel model = new LoginModel();
        List<Login> logins = new List<Login>();

        public string saveLogin(string user, string password)
        {
            if(string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                return "Campos obrigatórios.";
            }
            foreach (var i in logins)
            {
                if (i.usuario == user)
                {
                    return "Existe usuário na lista.";
                }
            }
            Login newUser = new Login { usuario = user, password = password };
            logins.Add(newUser);
            Login l = new Login()
            {
                usuario = user,
                password = password
            };
            return "Usuario salvo";
        }
        public List<Login> GetAllUser()
        {
            return model.getLogin();
        }
    }
}
