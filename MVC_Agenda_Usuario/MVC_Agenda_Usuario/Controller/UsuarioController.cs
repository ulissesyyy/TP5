using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Agenda_Usuario.Model;

namespace MVC_Agenda_Usuario.Controller
{
    internal class UsuarioController
    {
        UsuarioModel model = new UsuarioModel();

        public string saveUsuario(string nome, string zapText, string email)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email))
            {
                return "Campos obrigatórios.";
            }
            if (!int.TryParse(zapText, out int zap))
            {
                return "Digite um numero";
            }
            Usuario u = new Usuario()
            {
                nome = nome,
                zapText = zap,
                email = email
            };
            model.setUsuario(u);
            return "Usuário salvo.";
        }
        public List<Usuario> GetAllUsuarios()
        {
            return model.getUsuarios();
        }
    }
}
