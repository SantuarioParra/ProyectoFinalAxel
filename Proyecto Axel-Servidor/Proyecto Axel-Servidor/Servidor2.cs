using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Axel_Servidor
{
    public partial class Servidor2 : Form
    {
        private readonly int port;
        private TcpClient cliente;
        private TcpListener servidor;
        private NetworkStream mainStream;

        private readonly Thread escucha;
        private readonly Thread obtenerPantalla;
        public Servidor2(int Port)
        {
            port = Port;
            cliente = new TcpClient();
            escucha = new Thread(iniciarEscucha);
            obtenerPantalla = new Thread(recibirImagen);
            InitializeComponent();
        }

        public void iniciarEscucha() {
            while (cliente.Connected == false) {
                servidor.Start();
                cliente = servidor.AcceptTcpClient();
            }
            obtenerPantalla.Start();
        }

        public void recibirImagen() {
            BinaryFormatter formatoBinario = new BinaryFormatter();
            while (cliente.Connected) {
                try
                {
                    mainStream = cliente.GetStream();
                    Pantalla.Image = (Image)formatoBinario.Deserialize(mainStream);
                }
                catch (Exception) {
               MessageBox.Show("Conexión fallida,se cerro el cliente de forma inesperada. ", "Error",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }


        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            servidor = new TcpListener(IPAddress.Any, port);
            escucha.Start();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            pararEscucha();
        }
        public void pararEscucha() {
            servidor.Stop();
            cliente = null;
            if (escucha.IsAlive) {
                escucha.Abort();
            }
            if (obtenerPantalla.IsAlive)
            {
                obtenerPantalla.Abort();
            }
        }
    }
}
