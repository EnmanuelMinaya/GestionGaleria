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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBNombrePintura = new System.Windows.Forms.TextBox();
            this.tBTamanoPintura = new System.Windows.Forms.TextBox();
            this.datepickerCreacionPintura = new System.Windows.Forms.DateTimePicker();
            this.tBValorEstimado = new System.Windows.Forms.TextBox();
            this.tBGenero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(432, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.Size = new System.Drawing.Size(302, 265);
            this.dataGridView1.TabIndex = 0;
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
            // tBGenero
            // 
            this.tBGenero.Location = new System.Drawing.Point(156, 252);
            this.tBGenero.Name = "tBGenero";
            this.tBGenero.Size = new System.Drawing.Size(200, 20);
            this.tBGenero.TabIndex = 6;
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
            this.label5.Location = new System.Drawing.Point(113, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Género";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(73, 363);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(177, 363);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(281, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormGestionPinturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBGenero);
            this.Controls.Add(this.tBValorEstimado);
            this.Controls.Add(this.datepickerCreacionPintura);
            this.Controls.Add(this.tBTamanoPintura);
            this.Controls.Add(this.tBNombrePintura);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGestionPinturas";
            this.Text = "FormGestionPinturas";
            this.Load += new System.EventHandler(this.FormGestionPinturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tBNombrePintura;
        private System.Windows.Forms.TextBox tBTamanoPintura;
        private System.Windows.Forms.DateTimePicker datepickerCreacionPintura;
        private System.Windows.Forms.TextBox tBValorEstimado;
        private System.Windows.Forms.TextBox tBGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
    }
}