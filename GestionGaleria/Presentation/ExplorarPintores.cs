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
    public partial class ExplorarPintores : Form
    {
        public ExplorarPintores()
        {
            InitializeComponent();
        }

        private void ExplorarPintores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'galeriaDSPintor.ViewPintor' table. You can move, or remove it, as needed.
            this.viewPintorTableAdapter.Fill(this.galeriaDSPintor.ViewPintor);

        }
    }
}
