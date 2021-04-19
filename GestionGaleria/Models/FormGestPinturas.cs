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
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace GestionGaleria.Models
{
    public partial class FormGestionPinturas : Form
    {
        Tbl_Pintura PinturaModel = new Tbl_Pintura();
        Tbl_PinturaGenero PinGenModel = new Tbl_PinturaGenero();
        public FormGestionPinturas()
        {
            InitializeComponent();
        }

        private void FormGestionPinturas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'galeriaDataSetPintur.Tbl_Pintura' table. You can move, or remove it, as needed.
            this.tbl_PinturaTableAdapter2.Fill(this.galeriaDataSetPintur.Tbl_Pintura);
            // TODO: This line of code loads data into the 'galeriaDataSet2.Tbl_Dueno' table. You can move, or remove it, as needed.
            this.tbl_DuenoTableAdapter.Fill(this.galeriaDataSet2.Tbl_Dueno);
            // TODO: This line of code loads data into the 'galeriaDataSetPintura.Tbl_Pintura' table. You can move, or remove it, as needed.
            this.tbl_PinturaTableAdapter1.Fill(this.galeriaDataSetPintura.Tbl_Pintura);
            // TODO: This line of code loads data into the 'galeriaDataSet1.Tbl_Persona' table. You can move, or remove it, as needed.
            this.tbl_PersonaTableAdapter.Fill(this.galeriaDataSet1.Tbl_Persona);
            // TODO: This line of code loads data into the 'galeriaDataSetPintor.Tbl_Pintor' table. You can move, or remove it, as needed.
            this.tbl_PintorTableAdapter.Fill(this.galeriaDataSetPintor.Tbl_Pintor);
            Clear();
            PopulateDaraGridView();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            using (GaleriaEntities db = new GaleriaEntities())
            {



                PinturaModel.NombrePintura = tBNombrePintura.Text;
                PinturaModel.Tamano = tBTamanoPintura.Text;
                PinturaModel.Valor = decimal.Parse(tBValorEstimado.Text);
                PinturaModel.FechaCreacion = datepickerCreacionPintura.Value;
                PinturaModel.FechaIngreso = System.DateTime.Now;
                PinturaModel.FechaSalida = null;
                PinturaModel.Ubicacion = TBUbicacion.Text;
                PinturaModel.Id_Dueno = int.Parse(comboBox2.Text);
                PinturaModel.Id_Pintor = int.Parse(comboBox1.Text);
                if (cBRetrato.Checked == true)
                {
                    PinGenModel.Id_Genero = 1;
                    PinGenModel.Id_Pintura = PinturaModel.Id_Pintura;
                    db.Tbl_PinturaGenero.Add(PinGenModel);
                }
                if (CBDesnudo.Checked == true)
                {
                    PinGenModel.Id_Genero = 2;
                    PinGenModel.Id_Pintura = PinturaModel.Id_Pintura;
                    db.Tbl_PinturaGenero.Add(PinGenModel);
                }
                if (CBBodegón.Checked == true)
                {
                    PinGenModel.Id_Genero = 3;
                    PinGenModel.Id_Pintura = PinturaModel.Id_Pintura;
                    db.Tbl_PinturaGenero.Add(PinGenModel);
                }
                if (CBPaisaje.Checked == true)
                {
                    PinGenModel.Id_Genero = 4;
                    PinGenModel.Id_Pintura = PinturaModel.Id_Pintura;
                    db.Tbl_PinturaGenero.Add(PinGenModel);
                }
                if (CBMitologia.Checked == true)
                {
                    PinGenModel.Id_Genero = 5;
                    PinGenModel.Id_Pintura = PinturaModel.Id_Pintura;
                    db.Tbl_PinturaGenero.Add(PinGenModel);
                }
                if (CBHistoria.Checked == true)
                {
                    PinGenModel.Id_Genero = 6;
                    PinGenModel.Id_Pintura = PinturaModel.Id_Pintura;
                    db.Tbl_PinturaGenero.Add(PinGenModel);
                }
                if (CBReligiosa.Checked == true)
                {
                    PinGenModel.Id_Genero = 7;
                    PinGenModel.Id_Pintura = PinturaModel.Id_Pintura;
                    db.Tbl_PinturaGenero.Add(PinGenModel);
                }




                if (PinturaModel.Id_Pintura == 0)
                    db.Tbl_Pintura.Add(PinturaModel);
                else
                {
                    db.Entry(PinturaModel).State = EntityState.Modified;
                }


  
    
                db.SaveChanges();


                db.SaveChanges();
                PopulateDaraGridView();
                Clear();

            }


        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                PinturaModel.Id_Pintura = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdPintura"].Value);
                PinGenModel.Id_Pintura = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdPintura"].Value);

                using (GaleriaEntities db = new GaleriaEntities())
                {
                    PinturaModel = db.Tbl_Pintura.Where(x => x.Id_Pintura == PinturaModel.Id_Pintura).FirstOrDefault();
                    PinGenModel = db.Tbl_PinturaGenero.Where(y => y.Id_Pintura == PinGenModel.Id_Pintura).FirstOrDefault();
                    tBNombrePintura.Text = PinturaModel.NombrePintura;
                    tBTamanoPintura.Text = PinturaModel.Tamano;
                    tBValorEstimado.Text = PinturaModel.Valor.ToString();

     
                    TBUbicacion.Text = PinturaModel.Ubicacion;
                }
                btnGuardar.Text = "Actualizar";
                btnEliminar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea borrar este record?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (GaleriaEntities db = new GaleriaEntities())
                {
                    var entry1 = db.Entry(PinGenModel);
                    if (entry1.State == EntityState.Detached)
                        db.Tbl_PinturaGenero.Attach(PinGenModel);
                    db.Tbl_PinturaGenero.Remove(PinGenModel);
    

                    var entry = db.Entry(PinturaModel);
                    if (entry.State == EntityState.Detached)
                        db.Tbl_Pintura.Attach(PinturaModel);
                    db.Tbl_Pintura.Remove(PinturaModel);
                    db.SaveChanges();
                    PopulateDaraGridView();
                    Clear();
                    MessageBox.Show("Borrado Exitosamente");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            tBNombrePintura.Text = tBTamanoPintura.Text = tBValorEstimado.Text = TBUbicacion.Text = "";
            btnGuardar.Text = "Guardar";
            btnEliminar.Enabled = false;
            PinturaModel.Id_Pintura = 0;
            CBBodegón.Checked = CBDesnudo.Checked = CBHistoria.Checked = CBMitologia.Checked = CBPaisaje.Checked = CBReligiosa.Checked = cBRetrato.Checked = false;
        }

        void PopulateDaraGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (GaleriaEntities db = new GaleriaEntities())
            {
                dataGridView1.DataSource = db.Tbl_Pintura.ToList<Tbl_Pintura>();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
