using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Axel
{
    public partial class Cliente : Form
    {
        private readonly TcpClient client = new TcpClient();
        private NetworkStream mainStream;
        private int nPuerto;

        private static Image imageEscritorio() {
            Rectangle marco = Screen.PrimaryScreen.Bounds;
            Bitmap capturaPantalla = new Bitmap(marco.Width, marco.Height,PixelFormat.Format32bppArgb);
            Graphics graficos = Graphics.FromImage(capturaPantalla);
            graficos.CopyFromScreen(marco.X,marco.Y,0,0,marco.Size,CopyPixelOperation.SourceCopy);
            return capturaPantalla;
        }

        private void enviarPantalla() {
            BinaryFormatter formatoBinario = new BinaryFormatter();
            mainStream = client.GetStream();
            formatoBinario.Serialize(mainStream,imageEscritorio());
        }

        public Cliente()
        {
            InitializeComponent();
        }

        private void ConectarButton_Click(object sender, EventArgs e)
        {
            nPuerto = int.Parse(textPuerto.Text);
            try {
                client.Connect(textIP.Text,nPuerto);
                MessageBox.Show("Conexión realizada con exito", "Exito",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                CompartirButton.Visible = true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Conexión fallida, algo ocurrio:\n " , "Error",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void CompartirButton_Click(object sender, EventArgs e)
        {
            if (CompartirButton.ButtonText.StartsWith("Transmitir"))
            {
                Reloj.Start();
                CompartirButton.ButtonText = "Dejar de Transmitir Pantalla";
            }
            else {
                Reloj.Stop();
                CompartirButton.ButtonText = "Transmitir Pantalla";
            }
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            enviarPantalla();
        }
    }
}
