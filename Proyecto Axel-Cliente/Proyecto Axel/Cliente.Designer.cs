namespace Proyecto_Axel
{
    partial class Cliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.IpLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PuertoLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textIP = new System.Windows.Forms.TextBox();
            this.textPuerto = new System.Windows.Forms.TextBox();
            this.ConectarButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CompartirButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // IpLabel
            // 
            this.IpLabel.AutoSize = true;
            this.IpLabel.ForeColor = System.Drawing.Color.White;
            this.IpLabel.Location = new System.Drawing.Point(8, 23);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(23, 13);
            this.IpLabel.TabIndex = 0;
            this.IpLabel.Text = "IP :";
            // 
            // PuertoLabel
            // 
            this.PuertoLabel.AutoSize = true;
            this.PuertoLabel.ForeColor = System.Drawing.Color.White;
            this.PuertoLabel.Location = new System.Drawing.Point(223, 23);
            this.PuertoLabel.Name = "PuertoLabel";
            this.PuertoLabel.Size = new System.Drawing.Size(44, 13);
            this.PuertoLabel.TabIndex = 1;
            this.PuertoLabel.Text = "Puerto :";
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(37, 20);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(164, 20);
            this.textIP.TabIndex = 2;
            this.textIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPuerto
            // 
            this.textPuerto.Location = new System.Drawing.Point(280, 20);
            this.textPuerto.Name = "textPuerto";
            this.textPuerto.Size = new System.Drawing.Size(164, 20);
            this.textPuerto.TabIndex = 3;
            this.textPuerto.Text = "8000";
            this.textPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConectarButton
            // 
            this.ConectarButton.ActiveBorderThickness = 1;
            this.ConectarButton.ActiveCornerRadius = 20;
            this.ConectarButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConectarButton.ActiveForecolor = System.Drawing.Color.White;
            this.ConectarButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ConectarButton.BackColor = System.Drawing.Color.Black;
            this.ConectarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConectarButton.BackgroundImage")));
            this.ConectarButton.ButtonText = "Conectar";
            this.ConectarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConectarButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConectarButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.ConectarButton.IdleBorderThickness = 2;
            this.ConectarButton.IdleCornerRadius = 20;
            this.ConectarButton.IdleFillColor = System.Drawing.Color.Black;
            this.ConectarButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ConectarButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ConectarButton.Location = new System.Drawing.Point(175, 64);
            this.ConectarButton.Margin = new System.Windows.Forms.Padding(5);
            this.ConectarButton.Name = "ConectarButton";
            this.ConectarButton.Size = new System.Drawing.Size(123, 39);
            this.ConectarButton.TabIndex = 4;
            this.ConectarButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConectarButton.Click += new System.EventHandler(this.ConectarButton_Click);
            // 
            // CompartirButton
            // 
            this.CompartirButton.ActiveBorderThickness = 1;
            this.CompartirButton.ActiveCornerRadius = 20;
            this.CompartirButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CompartirButton.ActiveForecolor = System.Drawing.Color.White;
            this.CompartirButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.CompartirButton.BackColor = System.Drawing.Color.Black;
            this.CompartirButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CompartirButton.BackgroundImage")));
            this.CompartirButton.ButtonText = "Transmitir Pantalla";
            this.CompartirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompartirButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompartirButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.CompartirButton.IdleBorderThickness = 2;
            this.CompartirButton.IdleCornerRadius = 20;
            this.CompartirButton.IdleFillColor = System.Drawing.Color.Black;
            this.CompartirButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.CompartirButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.CompartirButton.Location = new System.Drawing.Point(132, 64);
            this.CompartirButton.Margin = new System.Windows.Forms.Padding(5);
            this.CompartirButton.Name = "CompartirButton";
            this.CompartirButton.Size = new System.Drawing.Size(220, 39);
            this.CompartirButton.TabIndex = 5;
            this.CompartirButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CompartirButton.Visible = false;
            this.CompartirButton.Click += new System.EventHandler(this.CompartirButton_Click);
            // 
            // Reloj
            // 
            this.Reloj.Tick += new System.EventHandler(this.Reloj_Tick);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(459, 117);
            this.Controls.Add(this.CompartirButton);
            this.Controls.Add(this.ConectarButton);
            this.Controls.Add(this.textPuerto);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.PuertoLabel);
            this.Controls.Add(this.IpLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel IpLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel PuertoLabel;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.TextBox textPuerto;
        private Bunifu.Framework.UI.BunifuThinButton2 ConectarButton;
        private Bunifu.Framework.UI.BunifuThinButton2 CompartirButton;
        private System.Windows.Forms.Timer Reloj;
    }
}

