using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionGaleria.Models; 

namespace GestionGaleria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
                    
        }

        private void Refrescar()
        {
            using (GaleriaEntities db = new GaleriaEntities())
            {
  
                var ListaPersonas = db.Tbl_Persona
                    .SqlQuery("Select * FROM Tbl_Persona")
                    .ToList<Tbl_Persona>();

               // dataGridView1.DataSource = ListaPersonas;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presentation.Login login = new Presentation.Login();
            login.ShowDialog();

            Refrescar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Presentation.FormGestionarPersonas nuevo = new Presentation.FormGestionarPersonas();
            nuevo.ShowDialog();

            Refrescar();
        }

        private void btnGestionarPinturas_Click(object sender, EventArgs e)
        {
            Models.FormGestionPinturas FormGPints = new FormGestionPinturas();
            FormGPints.ShowDialog();
            Refrescar();
        }
    }
}
