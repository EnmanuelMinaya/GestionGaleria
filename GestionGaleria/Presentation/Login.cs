using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGaleria.Presentation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbContrasena.Text == "admin" && tbUsuario.Text == "admin")
            {
                Form1 inicio = new Form1();
                inicio.ShowDialog();

            }
        }
    }
}
