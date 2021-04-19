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
    public partial class FormExplorarDuenos : Form
    {
        public FormExplorarDuenos()
        {
            InitializeComponent();
        }

        private void FormExplorarDuenos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'galeriaDataSet3.ViewDueno' table. You can move, or remove it, as needed.
            this.viewDuenoTableAdapter.Fill(this.galeriaDataSet3.ViewDueno);

        }
    }
}
