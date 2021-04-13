namespace GestionGaleria
{
    partial class Form1
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
            this.btnGestionarPinturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gestionar personas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnGestionarPinturas
            // 
            this.btnGestionarPinturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarPinturas.Location = new System.Drawing.Point(74, 100);
            this.btnGestionarPinturas.Name = "btnGestionarPinturas";
            this.btnGestionarPinturas.Size = new System.Drawing.Size(200, 50);
            this.btnGestionarPinturas.TabIndex = 2;
            this.btnGestionarPinturas.Text = "Gestionar Pinturas";
            this.btnGestionarPinturas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 359);
            this.Controls.Add(this.btnGestionarPinturas);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGestionarPinturas;
    }
}

