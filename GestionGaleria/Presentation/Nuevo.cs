using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionGaleria.Models;

namespace GestionGaleria.Presentation
{
    public partial class Nuevo : Form
    {
        Tbl_Persona model = new Tbl_Persona();
        Tbl_DocumentoIdentidad model2 = new Tbl_DocumentoIdentidad();
        public Nuevo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (GaleriaEntities db = new GaleriaEntities())
            {
                model2.TipoDocumento = textBoxTipoDoc.Text.Trim();
                model2.NumeroDocumento = textBoxNumDoc.Text.Trim();
                
                
                if (model2.Id_DocumentoIdentidad == 0)
                    db.Tbl_DocumentoIdentidad.Add(model2);
                else
                {
                    db.Entry(model2).State = EntityState.Modified;
                }
                

                db.SaveChanges();
                
                
                model.Id_DocumentoIdentidad = model2.Id_DocumentoIdentidad;
                model.Nombre = textBoxNombre.Text;
                model.Correo = textBoxCorreo.Text;
                model.Telefono = textBoxTel.Text;
                model.Direccion = textBoxDireccion.Text;
                model.FechaNacimiento = dateTimePicker1.Value;
                model.Nacionalidad = textBoxNacionalidad.Text;



                //db.Tbl_Persona.Add(model);

                 
                if (model.Id_Persona == 0)
                    db.Tbl_Persona.Add(model);
                else
                {
                    db.Entry(model).State = EntityState.Modified;
                }
                

                db.SaveChanges();
                Clear();
                MessageBox.Show("Usuario guardado");
                PopulateDaraGridView();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Nuevo_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDaraGridView();
        }

        void Clear()
        {
            textBoxCorreo.Text = textBoxDireccion.Text = textBoxNacionalidad.Text = textBoxNombre.Text = textBoxNumDoc.Text = textBoxTel.Text = textBoxTipoDoc.Text = "";
            btnSave.Text = "Guardar";
            btnDelete.Enabled = false;
            model.Id_Persona = 0;
            model2.Id_DocumentoIdentidad = 0;
        }

        void PopulateDaraGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (GaleriaEntities db = new GaleriaEntities())
            {
                dataGridView1.DataSource = db.Tbl_Persona.ToList<Tbl_Persona>();
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                model.Id_Persona = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_Persona"].Value);
                model2.Id_DocumentoIdentidad = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_DocumentoIdentidad"].Value);

                using (GaleriaEntities db = new GaleriaEntities())
                {
                    model = db.Tbl_Persona.Where(x => x.Id_Persona == model.Id_Persona).FirstOrDefault();
                    model2 = db.Tbl_DocumentoIdentidad.Where(y => y.Id_DocumentoIdentidad == model.Id_DocumentoIdentidad).FirstOrDefault();
                    textBoxNumDoc.Text = model2.NumeroDocumento;
                    textBoxTipoDoc.Text = model2.TipoDocumento;
                    textBoxNombre.Text = model.Nombre;
                    textBoxCorreo.Text = model.Correo;
                    textBoxTel.Text = model.Telefono;
                    textBoxDireccion.Text = model.Direccion;
                    dateTimePicker1.Value = model.FechaNacimiento;
                    textBoxNacionalidad.Text = model.Nacionalidad;
                }
                btnSave.Text = "Actualizar";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea borrar este record?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (GaleriaEntities db = new GaleriaEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.Tbl_Persona.Attach(model);
                    db.Tbl_Persona.Remove(model);
                    db.SaveChanges();
                    PopulateDaraGridView();
                    Clear();
                    MessageBox.Show("Borrado Exitosamente");
                }
            }
        }
    }
}