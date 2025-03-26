using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_Login_2.Controller;
using MVC_Login_2.Model;

namespace MVC_Login_2
{
    public partial class Form1: Form
    {
        private LoginController controller = new LoginController();
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            string password = txt_password.Text;
            string msg = controller.saveLogin(user, password);

            MessageBox.Show(msg, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
