using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tchat
{
    public partial class Form1 : Form
    {
        IPAddress mon_ip, cible_ip;
        IPEndPoint cible_EndPoint;
        IPEndPoint mon_EndPoint;
        int mon_Port = 43310;
        int cible_Port = 43310;
        Socket mon_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        private void Form1_Load(object sender, EventArgs e)
        {
            mon_textBox.Enabled = false;

            Tchat_richTextBox.Enabled = false;


            foreach (NetworkInterface carte in NetworkInterface.GetAllNetworkInterfaces())

                if (carte.NetworkInterfaceType != NetworkInterfaceType.Loopback &&
               carte.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties adapterProperties = carte.GetIPProperties();
                    foreach (UnicastIPAddressInformation adresse in adapterProperties.UnicastAddresses)
                        if (adresse.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            mon_ip = adresse.Address;
                }


                    mon_IP_Label.Text = mon_ip.ToString();
                    cible_ip = mon_ip;
                    cible_IP_textBox.Text = cible_ip.ToString();
                    mon_Port = 8080;
                    cible_Port = 8080;
                    mon_port_num.Value = mon_Port;
                    cible_port_num.Value = cible_Port;

        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            connect_button.Enabled = false;
            mon_port_num.Enabled = false;
            cible_port_num.Enabled = false;
            cible_IP_textBox.Enabled = false;
            mon_Port = (int)mon_port_num.Value;
            mon_EndPoint = new IPEndPoint(mon_ip, mon_Port);
            mon_Socket.Bind(mon_EndPoint);
            cible_ip = IPAddress.Parse(cible_IP_textBox.Text);
            cible_Port = (int)cible_port_num.Value;
            cible_EndPoint = new IPEndPoint(cible_ip, cible_Port);
            mon_Socket.Connect(cible_EndPoint);
            mon_textBox.Enabled = true;
            Tchat_richTextBox.Enabled = true;
            timer1.Enabled = true;
            mon_textBox.Focus();


        }
        private void mon_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true; 

                
                Tchat_richTextBox.SelectionStart = Tchat_richTextBox.TextLength;
                Tchat_richTextBox.SelectionLength = 0;
                Tchat_richTextBox.SelectionColor = Color.Red;

               
                Tchat_richTextBox.AppendText("moi : " + mon_textBox.Text + "\r\n");

               
                Tchat_richTextBox.ScrollToCaret();

                
                byte[] data = Encoding.UTF8.GetBytes(mon_textBox.Text);

               
                mon_Socket.Send(data);

               
                mon_textBox.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            byte[] data = new byte[1000];

            
            if (mon_Socket.Available > 0)
            {
                
                int taille = mon_Socket.Receive(data);

               
                string texte = Encoding.UTF8.GetString(data, 0, taille);

                
                Tchat_richTextBox.SelectionStart = Tchat_richTextBox.TextLength;
                Tchat_richTextBox.SelectionLength = 0;
                Tchat_richTextBox.SelectionColor = Color.Red;

               
                Tchat_richTextBox.AppendText("cible : " + texte + "\r\n");

                Tchat_richTextBox.ScrollToCaret();
            }
        }

        public Form1()
        {

            InitializeComponent();

        }
    }
}
