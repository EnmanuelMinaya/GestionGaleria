namespace GestionGaleria.Presentation
{
    partial class FormExplorarPinturas
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
            this.dgPinturas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPinturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPinturas
            // 
            this.dgPinturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPinturas.Location = new System.Drawing.Point(12, 28);
            this.dgPinturas.Name = "dgPinturas";
            this.dgPinturas.RowHeadersWidth = 47;
            this.dgPinturas.Size = new System.Drawing.Size(416, 329);
            this.dgPinturas.TabIndex = 0;
            // 
            // FormExplorarPinturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 363);
            this.Controls.Add(this.dgPinturas);
            this.Name = "FormExplorarPinturas";
            this.Text = "FormExplorarPinturas";
            this.Load += new System.EventHandler(this.FormExplorarPinturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPinturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPinturas;
    }
}