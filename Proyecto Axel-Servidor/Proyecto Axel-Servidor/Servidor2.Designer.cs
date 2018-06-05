namespace Proyecto_Axel_Servidor
{
    partial class Servidor2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servidor2));
            this.Pantalla = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pantalla)).BeginInit();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pantalla.Location = new System.Drawing.Point(0, 0);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(800, 450);
            this.Pantalla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pantalla.TabIndex = 0;
            this.Pantalla.TabStop = false;
            // 
            // Servidor2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pantalla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Servidor2";
            this.Text = "Servidor2";
            ((System.ComponentModel.ISupportInitialize)(this.Pantalla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pantalla;
    }
}