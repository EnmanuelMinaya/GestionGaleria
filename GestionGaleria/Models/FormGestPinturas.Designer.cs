namespace GestionGaleria.Models
{
    partial class FormGestionPinturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblPinturaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.galeriaDataSetPintur = new GestionGaleria.GaleriaDataSetPintur();
            this.tBNombrePintura = new System.Windows.Forms.TextBox();
            this.tBTamanoPintura = new System.Windows.Forms.TextBox();
            this.datepickerCreacionPintura = new System.Windows.Forms.DateTimePicker();
            this.tBValorEstimado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.galeriaDataSet = new GestionGaleria.GaleriaDataSet();
            this.tblPinturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PinturaTableAdapter = new GestionGaleria.GaleriaDataSetTableAdapters.Tbl_PinturaTableAdapter();
            this.cBRetrato = new System.Windows.Forms.CheckBox();
            this.CBDesnudo = new System.Windows.Forms.CheckBox();
            this.CBBodegón = new System.Windows.Forms.CheckBox();
            this.CBPaisaje = new System.Windows.Forms.CheckBox();
            this.CBMitologia = new System.Windows.Forms.CheckBox();
            this.CBHistoria = new System.Windows.Forms.CheckBox();
            this.CBReligiosa = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblPintorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.galeriaDataSetPintor = new GestionGaleria.GaleriaDataSetPintor();
            this.tbl_PintorTableAdapter = new GestionGaleria.GaleriaDataSetPintorTableAdapters.Tbl_PintorTableAdapter();
            this.galeriaDataSet1 = new GestionGaleria.GaleriaDataSet1();
            this.tblPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PersonaTableAdapter = new GestionGaleria.GaleriaDataSet1TableAdapters.Tbl_PersonaTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tblDuenoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.galeriaDataSet2 = new GestionGaleria.GaleriaDataSet2();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBUbicacion = new System.Windows.Forms.TextBox();
            this.galeriaDataSetPintura = new GestionGaleria.GaleriaDataSetPintura();
            this.tblPinturaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PinturaTableAdapter1 = new GestionGaleria.GaleriaDataSetPinturaTableAdapters.Tbl_PinturaTableAdapter();
            this.tbl_DuenoTableAdapter = new GestionGaleria.GaleriaDataSet2TableAdapters.Tbl_DuenoTableAdapter();
            this.tbl_PinturaTableAdapter2 = new GestionGaleria.GaleriaDataSetPinturTableAdapters.Tbl_PinturaTableAdapter();
            this.idPintura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPintorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDuenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePinturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPinturaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriaDataSetPintur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPinturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPintorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriaDataSetPintor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuenoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriaDataSetPintura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPinturaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPintura,
            this.idPintorDataGridViewTextBoxColumn,
            this.idDuenoDataGridViewTextBoxColumn,
            this.nombrePinturaDataGridViewTextBoxColumn,
            this.tamanoDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.fechaIngresoDataGridViewTextBoxColumn,
            this.fechaSalidaDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.Ubicacion});
            this.dataGridView1.DataSource = this.tblPinturaBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(432, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.Size = new System.Drawing.Size(623, 497);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick_1);
            // 
            // tblPinturaBindingSource2
            // 
            this.tblPinturaBindingSource2.DataMember = "Tbl_Pintura";
            this.tblPinturaBindingSource2.DataSource = this.galeriaDataSetPintur;
            // 
            // galeriaDataSetPintur
            // 
            this.galeriaDataSetPintur.DataSetName = "GaleriaDataSetPintur";
            this.galeriaDataSetPintur.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBNombrePintura
            // 
            this.tBNombrePintura.Location = new System.Drawing.Point(156, 86);
            this.tBNombrePintura.Name = "tBNombrePintura";
            this.tBNombrePintura.Size = new System.Drawing.Size(200, 20);
            this.tBNombrePintura.TabIndex = 1;
            // 
            // tBTamanoPintura
            // 
            this.tBTamanoPintura.Location = new System.Drawing.Point(156, 128);
            this.tBTamanoPintura.Name = "tBTamanoPintura";
            this.tBTamanoPintura.Size = new System.Drawing.Size(200, 20);
            this.tBTamanoPintura.TabIndex = 2;
            // 
            // datepickerCreacionPintura
            // 
            this.datepickerCreacionPintura.Location = new System.Drawing.Point(156, 165);
            this.datepickerCreacionPintura.Name = "datepickerCreacionPintura";
            this.datepickerCreacionPintura.Size = new System.Drawing.Size(200, 20);
            this.datepickerCreacionPintura.TabIndex = 3;
            // 
            // tBValorEstimado
            // 
            this.tBValorEstimado.Location = new System.Drawing.Point(156, 209);
            this.tBValorEstimado.Name = "tBValorEstimado";
            this.tBValorEstimado.Size = new System.Drawing.Size(200, 20);
            this.tBValorEstimado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tamaño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de Creación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor estimado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Géneros";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(75, 560);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(179, 560);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(283, 560);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // galeriaDataSet
            // 
            this.galeriaDataSet.DataSetName = "GaleriaDataSet";
            this.galeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPinturaBindingSource
            // 
            this.tblPinturaBindingSource.DataMember = "Tbl_Pintura";
            this.tblPinturaBindingSource.DataSource = this.galeriaDataSet;
            // 
            // tbl_PinturaTableAdapter
            // 
            this.tbl_PinturaTableAdapter.ClearBeforeFill = true;
            // 
            // cBRetrato
            // 
            this.cBRetrato.AutoSize = true;
            this.cBRetrato.Location = new System.Drawing.Point(156, 296);
            this.cBRetrato.Name = "cBRetrato";
            this.cBRetrato.Size = new System.Drawing.Size(61, 17);
            this.cBRetrato.TabIndex = 15;
            this.cBRetrato.Text = "Retrato";
            this.cBRetrato.UseVisualStyleBackColor = true;
            // 
            // CBDesnudo
            // 
            this.CBDesnudo.AutoSize = true;
            this.CBDesnudo.Location = new System.Drawing.Point(156, 337);
            this.CBDesnudo.Name = "CBDesnudo";
            this.CBDesnudo.Size = new System.Drawing.Size(69, 17);
            this.CBDesnudo.TabIndex = 16;
            this.CBDesnudo.Text = "Desnudo";
            this.CBDesnudo.UseVisualStyleBackColor = true;
            // 
            // CBBodegón
            // 
            this.CBBodegón.AutoSize = true;
            this.CBBodegón.Location = new System.Drawing.Point(156, 378);
            this.CBBodegón.Name = "CBBodegón";
            this.CBBodegón.Size = new System.Drawing.Size(69, 17);
            this.CBBodegón.TabIndex = 17;
            this.CBBodegón.Text = "Bodegón";
            this.CBBodegón.UseVisualStyleBackColor = true;
            // 
            // CBPaisaje
            // 
            this.CBPaisaje.AutoSize = true;
            this.CBPaisaje.Location = new System.Drawing.Point(156, 416);
            this.CBPaisaje.Name = "CBPaisaje";
            this.CBPaisaje.Size = new System.Drawing.Size(60, 17);
            this.CBPaisaje.TabIndex = 18;
            this.CBPaisaje.Text = "Paisaje";
            this.CBPaisaje.UseVisualStyleBackColor = true;
            // 
            // CBMitologia
            // 
            this.CBMitologia.AutoSize = true;
            this.CBMitologia.Location = new System.Drawing.Point(288, 296);
            this.CBMitologia.Name = "CBMitologia";
            this.CBMitologia.Size = new System.Drawing.Size(70, 17);
            this.CBMitologia.TabIndex = 19;
            this.CBMitologia.Text = "Mitológía";
            this.CBMitologia.UseVisualStyleBackColor = true;
            // 
            // CBHistoria
            // 
            this.CBHistoria.AutoSize = true;
            this.CBHistoria.Location = new System.Drawing.Point(288, 337);
            this.CBHistoria.Name = "CBHistoria";
            this.CBHistoria.Size = new System.Drawing.Size(61, 17);
            this.CBHistoria.TabIndex = 20;
            this.CBHistoria.Text = "Historia";
            this.CBHistoria.UseVisualStyleBackColor = true;
            // 
            // CBReligiosa
            // 
            this.CBReligiosa.AutoSize = true;
            this.CBReligiosa.Location = new System.Drawing.Point(288, 378);
            this.CBReligiosa.Name = "CBReligiosa";
            this.CBReligiosa.Size = new System.Drawing.Size(69, 17);
            this.CBReligiosa.TabIndex = 21;
            this.CBReligiosa.Text = "Religiosa";
            this.CBReligiosa.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tblPintorBindingSource;
            this.comboBox1.DisplayMember = "Id_Pintor";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 456);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // tblPintorBindingSource
            // 
            this.tblPintorBindingSource.DataMember = "Tbl_Pintor";
            this.tblPintorBindingSource.DataSource = this.galeriaDataSetPintor;
            // 
            // galeriaDataSetPintor
            // 
            this.galeriaDataSetPintor.DataSetName = "GaleriaDataSetPintor";
            this.galeriaDataSetPintor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PintorTableAdapter
            // 
            this.tbl_PintorTableAdapter.ClearBeforeFill = true;
            // 
            // galeriaDataSet1
            // 
            this.galeriaDataSet1.DataSetName = "GaleriaDataSet1";
            this.galeriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonaBindingSource
            // 
            this.tblPersonaBindingSource.DataMember = "Tbl_Persona";
            this.tblPersonaBindingSource.DataSource = this.galeriaDataSet1;
            // 
            // tbl_PersonaTableAdapter
            // 
            this.tbl_PersonaTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tblDuenoBindingSource;
            this.comboBox2.DisplayMember = "Id_Dueno";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(156, 508);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // tblDuenoBindingSource
            // 
            this.tblDuenoBindingSource.DataMember = "Tbl_Dueno";
            this.tblDuenoBindingSource.DataSource = this.galeriaDataSet2;
            // 
            // galeriaDataSet2
            // 
            this.galeriaDataSet2.DataSetName = "GaleriaDataSet2";
            this.galeriaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Pintor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Dueño";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ubicación";
            // 
            // TBUbicacion
            // 
            this.TBUbicacion.Location = new System.Drawing.Point(156, 249);
            this.TBUbicacion.Name = "TBUbicacion";
            this.TBUbicacion.Size = new System.Drawing.Size(200, 20);
            this.TBUbicacion.TabIndex = 27;
            // 
            // galeriaDataSetPintura
            // 
            this.galeriaDataSetPintura.DataSetName = "GaleriaDataSetPintura";
            this.galeriaDataSetPintura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPinturaBindingSource1
            // 
            this.tblPinturaBindingSource1.DataMember = "Tbl_Pintura";
            this.tblPinturaBindingSource1.DataSource = this.galeriaDataSetPintura;
            // 
            // tbl_PinturaTableAdapter1
            // 
            this.tbl_PinturaTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_DuenoTableAdapter
            // 
            this.tbl_DuenoTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_PinturaTableAdapter2
            // 
            this.tbl_PinturaTableAdapter2.ClearBeforeFill = true;
            // 
            // idPintura
            // 
            this.idPintura.DataPropertyName = "Id_Pintura";
            this.idPintura.HeaderText = "Id_Pintura";
            this.idPintura.MinimumWidth = 6;
            this.idPintura.Name = "idPintura";
            this.idPintura.ReadOnly = true;
            this.idPintura.Visible = false;
            this.idPintura.Width = 115;
            // 
            // idPintorDataGridViewTextBoxColumn
            // 
            this.idPintorDataGridViewTextBoxColumn.DataPropertyName = "Id_Pintor";
            this.idPintorDataGridViewTextBoxColumn.HeaderText = "Id_Pintor";
            this.idPintorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPintorDataGridViewTextBoxColumn.Name = "idPintorDataGridViewTextBoxColumn";
            this.idPintorDataGridViewTextBoxColumn.Visible = false;
            this.idPintorDataGridViewTextBoxColumn.Width = 115;
            // 
            // idDuenoDataGridViewTextBoxColumn
            // 
            this.idDuenoDataGridViewTextBoxColumn.DataPropertyName = "Id_Dueno";
            this.idDuenoDataGridViewTextBoxColumn.HeaderText = "Id_Dueno";
            this.idDuenoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDuenoDataGridViewTextBoxColumn.Name = "idDuenoDataGridViewTextBoxColumn";
            this.idDuenoDataGridViewTextBoxColumn.Visible = false;
            this.idDuenoDataGridViewTextBoxColumn.Width = 115;
            // 
            // nombrePinturaDataGridViewTextBoxColumn
            // 
            this.nombrePinturaDataGridViewTextBoxColumn.DataPropertyName = "NombrePintura";
            this.nombrePinturaDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombrePinturaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombrePinturaDataGridViewTextBoxColumn.Name = "nombrePinturaDataGridViewTextBoxColumn";
            this.nombrePinturaDataGridViewTextBoxColumn.Width = 115;
            // 
            // tamanoDataGridViewTextBoxColumn
            // 
            this.tamanoDataGridViewTextBoxColumn.DataPropertyName = "Tamano";
            this.tamanoDataGridViewTextBoxColumn.HeaderText = "Tamaño";
            this.tamanoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tamanoDataGridViewTextBoxColumn.Name = "tamanoDataGridViewTextBoxColumn";
            this.tamanoDataGridViewTextBoxColumn.Width = 115;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "Fecha de creación";
            this.fechaCreacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.Width = 115;
            // 
            // fechaIngresoDataGridViewTextBoxColumn
            // 
            this.fechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaIngreso";
            this.fechaIngresoDataGridViewTextBoxColumn.HeaderText = "FechaIngreso";
            this.fechaIngresoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaIngresoDataGridViewTextBoxColumn.Name = "fechaIngresoDataGridViewTextBoxColumn";
            this.fechaIngresoDataGridViewTextBoxColumn.Visible = false;
            this.fechaIngresoDataGridViewTextBoxColumn.Width = 115;
            // 
            // fechaSalidaDataGridViewTextBoxColumn
            // 
            this.fechaSalidaDataGridViewTextBoxColumn.DataPropertyName = "FechaSalida";
            this.fechaSalidaDataGridViewTextBoxColumn.HeaderText = "FechaSalida";
            this.fechaSalidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaSalidaDataGridViewTextBoxColumn.Name = "fechaSalidaDataGridViewTextBoxColumn";
            this.fechaSalidaDataGridViewTextBoxColumn.Visible = false;
            this.fechaSalidaDataGridViewTextBoxColumn.Width = 115;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor Estimado";
            this.valorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.Width = 115;
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "Ubicacion";
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.MinimumWidth = 6;
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.Width = 115;
            // 
            // FormGestionPinturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 607);
            this.Controls.Add(this.TBUbicacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CBReligiosa);
            this.Controls.Add(this.CBHistoria);
            this.Controls.Add(this.CBMitologia);
            this.Controls.Add(this.CBPaisaje);
            this.Controls.Add(this.CBBodegón);
            this.Controls.Add(this.CBDesnudo);
            this.Controls.Add(this.cBRetrato);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBValorEstimado);
            this.Controls.Add(this.datepickerCreacionPintura);
            this.Controls.Add(this.tBTamanoPintura);
            this.Controls.Add(this.tBNombrePintura);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGestionPinturas";
            this.Text = "FormGestionPinturas";
            this.Load += new System.EventHandler(this.FormGestionPinturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPinturaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriaDataSetPintur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPinturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPintorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriaDataSetPintor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuenoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriaDataSetPintura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPinturaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tBNombrePintura;
        private System.Windows.Forms.TextBox tBTamanoPintura;
        private System.Windows.Forms.DateTimePicker datepickerCreacionPintura;
        private System.Windows.Forms.TextBox tBValorEstimado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private GaleriaDataSet galeriaDataSet;
        private System.Windows.Forms.BindingSource tblPinturaBindingSource;
        private GaleriaDataSetTableAdapters.Tbl_PinturaTableAdapter tbl_PinturaTableAdapter;
        private System.Windows.Forms.CheckBox cBRetrato;
        private System.Windows.Forms.CheckBox CBDesnudo;
        private System.Windows.Forms.CheckBox CBBodegón;
        private System.Windows.Forms.CheckBox CBPaisaje;
        private System.Windows.Forms.CheckBox CBMitologia;
        private System.Windows.Forms.CheckBox CBHistoria;
        private System.Windows.Forms.CheckBox CBReligiosa;
        private System.Windows.Forms.ComboBox comboBox1;
        private GaleriaDataSetPintor galeriaDataSetPintor;
        private System.Windows.Forms.BindingSource tblPintorBindingSource;
        private GaleriaDataSetPintorTableAdapters.Tbl_PintorTableAdapter tbl_PintorTableAdapter;
        private GaleriaDataSet1 galeriaDataSet1;
        private System.Windows.Forms.BindingSource tblPersonaBindingSource;
        private GaleriaDataSet1TableAdapters.Tbl_PersonaTableAdapter tbl_PersonaTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBUbicacion;
        private GaleriaDataSetPintura galeriaDataSetPintura;
        private System.Windows.Forms.BindingSource tblPinturaBindingSource1;
        private GaleriaDataSetPinturaTableAdapters.Tbl_PinturaTableAdapter tbl_PinturaTableAdapter1;
        private GaleriaDataSet2 galeriaDataSet2;
        private System.Windows.Forms.BindingSource tblDuenoBindingSource;
        private GaleriaDataSet2TableAdapters.Tbl_DuenoTableAdapter tbl_DuenoTableAdapter;
        private GaleriaDataSetPintur galeriaDataSetPintur;
        private System.Windows.Forms.BindingSource tblPinturaBindingSource2;
        private GaleriaDataSetPinturTableAdapters.Tbl_PinturaTableAdapter tbl_PinturaTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPintura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPintorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDuenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePinturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
    }
}