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


namespace GestionGaleria.Models
{
    public partial class FormGestionPinturas : Form
    {
        Tbl_Pintura PinturaModel = new Tbl_Pintura();
        public FormGestionPinturas()
        {
            InitializeComponent();
        }

        private void FormGestionPinturas_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PinturaModel.NombrePintura = tBNombrePintura.Text;
            PinturaModel.Tamano = tBTamanoPintura.Text;
            PinturaModel.Valor = decimal.Parse(tBValorEstimado.Text);
            PinturaModel.FechaCreacion = datepickerCreacionPintura.Value;

        }
    }
}
