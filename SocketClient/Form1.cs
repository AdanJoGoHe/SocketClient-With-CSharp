using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketClient
{
    public partial class Form1 : Form
    {
        //Variables globlase
        public TcpClient tcpclnt = null;
        
        //Constructor
        public Form1()
        {
            InitializeComponent();
        }
        //Metodos
        private void herramientasDeConexion(bool bo)
        {
            TextoIP.Enabled = bo;
            TextoPuerto.Enabled = bo;
            BotonConectar.Enabled = bo;
        }
        private void herramientasDeMensajeria(bool bo)
        {
            TextoAEnviar.Enabled = bo;
            BotonEnviar.Enabled = bo;
            Desconectar.Visible = bo;
        }

        private void BotonConectar_Click(object sender, EventArgs e)
        {
            
            if(TextoIP.Text == "" || TextoPuerto.Text == "")
            {
                string error = "Has dejado vacio la IP o el Puerto \n";

                AppendText(TextoChat, Color.Red, error);
            }
            else
            {
                try
                {
                    herramientasDeConexion(false);
                    tcpclnt = new TcpClient();
                    int puerto = Convert.ToInt32(TextoPuerto.Text);
                    tcpclnt.Connect(TextoIP.Text, puerto);
                    if (tcpclnt.Connected)
                    {
                        herramientasDeMensajeria(true);
                        AppendText(TextoChat,Color.DarkBlue, "Se ha conectado satisfactoriamente \n"); 
                        ThreadStart RunLeer = new ThreadStart(leerServidor);
                        Thread HiloLeer = new Thread(RunLeer);
                        HiloLeer.Start();
                    }
                }
                catch (SocketException _se)
                {
                    bool bo = true;
                    herramientasDeConexion(bo);
                    AppendText(TextoChat, Color.Red, "\n"+_se.ToString());

                }
                catch (Exception _e)
                {
                    bool bo = true;
                    herramientasDeConexion(bo);
                    AppendText(TextoChat,Color.Red, "\n" + _e.ToString());
                }
            }
            
        }

        private void AppendText(RichTextBox box, Color color, string text)
        {
            int start = box.TextLength;
            box.AppendText(text);
            int end = box.TextLength;

            // Textbox may transform chars, so (end-start) != text.Length
            box.Select(start, end - start);
            {
                box.SelectionColor = color;
                // could set box.SelectionBackColor, box.SelectionFont too.
            }
            box.SelectionLength = 0; // clear
        }
        
        private void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            string mensaje = "\n" + value;
            AppendText(TextoChat,Color.Black, mensaje) ;
        }

        private void leerServidor()
        {
            try
            {
                while(tcpclnt.Connected)
                {
                    string mensaje = null;
                    Stream stm = null;
                    stm = tcpclnt.GetStream();
                    byte[] bb = new byte[300];
                    int k = stm.Read(bb, 0, 300);
                    for (int i = 0; i < k; i++)
                    {
                        mensaje+=Convert.ToChar(bb[i]);
                    }
                    AppendTextBox(mensaje);                        
                }             
            }
            catch (Exception _e)
            {

            }

            

        }

        private void BotonEnviar_Click(object sender, EventArgs e)
        {
            string str = null;
            str = TextoAEnviar.Text;
            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes(str);
            Stream stream = tcpclnt.GetStream();
            stream.Write(ba, 0, ba.Length);
            TextoAEnviar.Text = "";
        }

        private void DevIP_Click(object sender, EventArgs e)
        {
            TextoIP.Text = "192.168.201.90";
            TextoPuerto.Text = "8000";
        }

        private void Desconectar_Click(object sender, EventArgs e)
        {
            try
            {
                tcpclnt.Close();
                if (tcpclnt.Connected)
                {
                    AppendText(TextoChat, Color.Red, "Ha ocurrido un error al intentar desconectarse : \n");
                }
                else
                {
                    herramientasDeConexion(true);
                    herramientasDeMensajeria(false);
                    AppendText(TextoChat, Color.DarkBlue, "Se ha desconectado Correctamente \n");
                }
            }
            catch (Exception)
            {

                throw;
            }
                
            
        }
    }
}
