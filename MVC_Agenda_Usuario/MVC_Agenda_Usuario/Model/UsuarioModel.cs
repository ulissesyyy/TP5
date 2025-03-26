using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agenda_Usuario.Model
{
    internal class UsuarioModel
    {
        public List<Usuario> usuarios = new List<Usuario>();

        public void setUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }
        public List<Usuario> getUsuarios()
        {
            return usuarios;
        }
    }
}
