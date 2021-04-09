using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                var lst = from d in db.Tbl_Persona
                          select d;
                dataGridView1.DataSource = lst.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presentation.Nuevo nuevo = new Presentation.Nuevo();
            nuevo.ShowDialog();

            Refrescar();
        }
    }
}
