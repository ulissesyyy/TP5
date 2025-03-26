using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Login_2.Model
{
    class LoginModel
    {
        public List<Login> usuarios = new List<Login>();

        public void setLogin(Login user)
        {
            usuarios.Add(user);
        }
        public List<Login> getLogin()
        {
            return usuarios;
        }
    }
}
