namespace Proyecto_Axel_Servidor
{
    partial class Servidor1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servidor1));
            this.escucharButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.puerto = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // escucharButton
            // 
            this.escucharButton.ActiveBorderThickness = 2;
            this.escucharButton.ActiveCornerRadius = 20;
            this.escucharButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.escucharButton.ActiveForecolor = System.Drawing.Color.White;
            this.escucharButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.escucharButton.BackColor = System.Drawing.Color.Black;
            this.escucharButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("escucharButton.BackgroundImage")));
            this.escucharButton.ButtonText = "Escuchar";
            this.escucharButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.escucharButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escucharButton.ForeColor = System.Drawing.Color.White;
            this.escucharButton.IdleBorderThickness = 1;
            this.escucharButton.IdleCornerRadius = 20;
            this.escucharButton.IdleFillColor = System.Drawing.Color.Black;
            this.escucharButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.escucharButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.escucharButton.Location = new System.Drawing.Point(29, 76);
            this.escucharButton.Margin = new System.Windows.Forms.Padding(5);
            this.escucharButton.Name = "escucharButton";
            this.escucharButton.Size = new System.Drawing.Size(181, 41);
            this.escucharButton.TabIndex = 0;
            this.escucharButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.escucharButton.Click += new System.EventHandler(this.escucharButton_Click);
            // 
            // puerto
            // 
            this.puerto.AutoSize = true;
            this.puerto.BackColor = System.Drawing.Color.Black;
            this.puerto.ForeColor = System.Drawing.Color.White;
            this.puerto.Location = new System.Drawing.Point(41, 33);
            this.puerto.Name = "puerto";
            this.puerto.Size = new System.Drawing.Size(44, 13);
            this.puerto.TabIndex = 1;
            this.puerto.Text = "Puerto :";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(91, 30);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(100, 20);
            this.textPort.TabIndex = 2;
            this.textPort.Text = "8000";
            this.textPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Servidor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(236, 131);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.puerto);
            this.Controls.Add(this.escucharButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Servidor1";
            this.Text = "Servidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 escucharButton;
        private Bunifu.Framework.UI.BunifuCustomLabel puerto;
        private System.Windows.Forms.TextBox textPort;
    }
}

