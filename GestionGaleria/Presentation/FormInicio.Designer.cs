namespace GestionGaleria.Presentation
{
    partial class FormInicio
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
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnExplorarPinturas = new System.Windows.Forms.Button();
            this.btnExplorarPintor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(306, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ingresar como administrador";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExplorarPinturas
            // 
            this.btnExplorarPinturas.Font = new System.Drawing.Font("Microsoft JhengHei", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplorarPinturas.ForeColor = System.Drawing.Color.Black;
            this.btnExplorarPinturas.Location = new System.Drawing.Point(67, 63);
            this.btnExplorarPinturas.Name = "btnExplorarPinturas";
            this.btnExplorarPinturas.Size = new System.Drawing.Size(354, 101);
            this.btnExplorarPinturas.TabIndex = 1;
            this.btnExplorarPinturas.Text = "Explorar Pinturas";
            this.btnExplorarPinturas.UseVisualStyleBackColor = true;
            this.btnExplorarPinturas.Click += new System.EventHandler(this.btnExplorarPinturas_Click);
            // 
            // btnExplorarPintor
            // 
            this.btnExplorarPintor.Font = new System.Drawing.Font("Microsoft JhengHei", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplorarPintor.ForeColor = System.Drawing.Color.Black;
            this.btnExplorarPintor.Location = new System.Drawing.Point(67, 195);
            this.btnExplorarPintor.Name = "btnExplorarPintor";
            this.btnExplorarPintor.Size = new System.Drawing.Size(354, 80);
            this.btnExplorarPintor.TabIndex = 2;
            this.btnExplorarPintor.Text = "Pintores";
            this.btnExplorarPintor.UseVisualStyleBackColor = true;
            this.btnExplorarPintor.Click += new System.EventHandler(this.btnExplorarPintor_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(493, 370);
            this.Controls.Add(this.btnExplorarPintor);
            this.Controls.Add(this.btnExplorarPinturas);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "FormInicio";
            this.Text = "Galeria Desktop App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnExplorarPinturas;
        private System.Windows.Forms.Button btnExplorarPintor;
    }
}