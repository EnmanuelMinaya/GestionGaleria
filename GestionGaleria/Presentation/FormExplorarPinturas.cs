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


namespace GestionGaleria.Presentation
{
    
    public partial class FormExplorarPinturas : Form
    {
        
        public FormExplorarPinturas()
        {
            InitializeComponent();
        }
        private void populateDGPinturas()
        {
            using (var pinturas = new GaleriaEntities())
            {
                dgPinturas.AutoGenerateColumns = true;
                dgPinturas.DataSource = pinturas.ViewPinturas.ToList();

            }
        }

        private void FormExplorarPinturas_Load(object sender, EventArgs e)
        {
            populateDGPinturas();
        }
    }
}
