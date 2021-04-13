﻿using System;
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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presentation.Login login = new Presentation.Login();
            login.ShowDialog();

        }

        private void btnExplorarPintor_Click(object sender, EventArgs e)
        {
            Presentation.ExplorarPintores EPintores = new Presentation.ExplorarPintores();
            EPintores.ShowDialog();
        }

        private void btnExplorarPinturas_Click(object sender, EventArgs e)
        {
            Presentation.FormExplorarPinturas EPinturas = new Presentation.FormExplorarPinturas();
            EPinturas.ShowDialog();
        }
    }
}