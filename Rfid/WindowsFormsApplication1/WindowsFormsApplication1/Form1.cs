using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string abc;
        string Comdata;
        string strHeading = "Mobile Robot Controlled VIA wi-fi";
        System.Net.Sockets.TcpClient clientSocket1 = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            abc = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(check));
        }
        private void ThreadProcSafe()
        {
           
        }


        private void check(object sender,EventArgs e)
        {
          
          //abc.charAt(0);
          //if (abc.Substring(0, 1) == "T")
          //{
            string data = abc.Substring(0, 11);
            string c = data.Substring(9, 1);
           // textBox1.Text = c.ToString();
            if (data.Substring(9, 1) == "3")
            {
                label1.Text = "OBJECT 1";
                label4.Text = "45 degree ";
                byte[] outStream4;
                outStream4 = System.Text.Encoding.ASCII.GetBytes("X");
                serverStream.Write(outStream4, 0, outStream4.Length);
                serverStream.Flush();
                Thread.Sleep(500);
            }
            if (data.Substring(9, 1) == "6")
            {
                label1.Text = "OBJECT 2";
                label4.Text = "90 degree ";
                byte[] outStream4;
                outStream4 = System.Text.Encoding.ASCII.GetBytes("Y");
                serverStream.Write(outStream4, 0, outStream4.Length);
                serverStream.Flush();
                Thread.Sleep(500);
            }
         
        }
        /*private void button1_Click(object sender, EventArgs e)
        {
            //serialPort1.Write("A");
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes("A");
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
            Thread.Sleep(500);
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
            //lbl_heading.Text = strHeading;
            try
            {
                clientSocket1.Connect("192.168.0.102", 800);
                serverStream = clientSocket1.GetStream();
            }
            catch (Exception err)
            {
                //label3.Text = Convert.ToString(err);
            }
        }

      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           // serialPort1.Write("F");
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes("F");
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
            Thread.Sleep(500);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // serialPort1.Write("R");
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes("R");
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
            Thread.Sleep(500);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //serialPort1.Write("L");
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes("L");
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
            Thread.Sleep(500);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //serialPort1.Write("B");
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes("B");
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
            Thread.Sleep(500);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //serialPort1.Write("U");
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes("U");
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
            Thread.Sleep(500);
        }

        private void button9_Click(object sender, EventArgs e)
        {
           // serialPort1.Write("D");
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes("D");
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
            Thread.Sleep(500);
        }

        private void button8_Click(object sender, EventArgs e)
        {
          //  serialPort1.Write("O");
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes("O");
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
            Thread.Sleep(500);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //serialPort1.Write("C");
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes("C");
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
            Thread.Sleep(500);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // serialPort1.Write("Q");
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes("Q");
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
            Thread.Sleep(500);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // serialPort1.Write("A");
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes("A");
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
            Thread.Sleep(500);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            label4.Text = " ";

        }

       
    }
}
