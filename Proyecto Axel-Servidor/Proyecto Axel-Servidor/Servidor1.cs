using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Axel_Servidor
{
    public partial class Servidor1 : Form
    {

        public Servidor1()
        {
            InitializeComponent();
        }

        private void escucharButton_Click(object sender, EventArgs e)
        {
            //int port = int.Parse(textPort.Text);
            //Servidor2 servidor2 = new Servidor2(port);
            //servidor2.Show();
            new Servidor2(int.Parse(textPort.Text)).Show();
        }
    }
}
