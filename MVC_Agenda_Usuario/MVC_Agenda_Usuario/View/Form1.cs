using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_Agenda_Usuario.Controller;
using MVC_Agenda_Usuario.Model;

namespace MVC_Agenda_Usuario
{
    public partial class Form1 : Form
    {
        private UsuarioController controller = new UsuarioController();
        public Form1()
        {
            InitializeComponent();
            dgv_usuarios.Height = 160;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            string zap = txt_numero.Text;
            string email = txt_email.Text;
            string msg = controller.saveUsuario(nome, zap, email);
            MessageBox.Show(msg);
            this.RefreshDgv();
            dgv_usuarios.Height = 160;

        }
        private void RefreshDgv()
        {
            List<Usuario> u = controller.GetAllUsuarios();
            if((u.Count * 40) <= 160)
            {
                dgv_usuarios.Height = u.Count * 40;
            }
            else {
                dgv_usuarios.Height = 160;
            }
            dgv_usuarios.DataSource = null;
            dgv_usuarios.DataSource = u;
        }
    }
}
