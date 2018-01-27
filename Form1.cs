using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string address = textBox1.Text;

            Ping pingSender = new Ping();
 

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "kykykykykykykykykykykykykykykyky";
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            // Wait 10 seconds for a reply.
            int timeout = 10000;

            // Set options for transmission:
            // The data can go through 64 gateways or routers
            // before it is destroyed, and the data packet
            // cannot be fragmented.
            PingOptions options = new PingOptions(86, true);

            Ping ping = new Ping();
            PingReply pingresult = ping.Send( address, timeout, buffer, options);

            label1.Text ="time: "+ pingresult.RoundtripTime.ToString()+" msec";
            label2.Text = "Adress: " + pingresult.Address.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string address = textBox1.Text;

            Ping pingSender = new Ping();


            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "kykykykykykykykykykykykykykykyky";
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            // Wait 10 seconds for a reply.
            int timeout = 10000;

            // Set options for transmission:
            // The data can go through 64 gateways or routers
            // before it is destroyed, and the data packet
            // cannot be fragmented.
            PingOptions options = new PingOptions(86, true);

            Ping ping = new Ping();
            PingReply pingresult = ping.Send(address, timeout, buffer, options);

            label1.Text = "time: " + pingresult.RoundtripTime.ToString() + " msec";
            label2.Text = "Adress: " + pingresult.Address.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Hide();
            button3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Show();
            button3.Hide();
        }
    }
}
