using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace WindowsFormsApplication2
{
    public partial class Frm_main : Form
    {
        string Comdata;
        string strHeading = "Mobile Robot Controlled VIA wi-fi";
        System.Net.Sockets.TcpClient clientSocket1 = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream =null;
        public Frm_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                clientSocket1.Connect("192.168.0.109", 8080);
                serverStream = clientSocket1.GetStream();
            }
            catch (Exception err)
            {

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clientSocket1.Close();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes(textBox2.Text);
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_heading.Text = strHeading; 
            try
            {
                clientSocket1.Connect("192.168.0.109", 8080);
                serverStream = clientSocket1.GetStream();
            }
            catch (Exception err)
            {
               //label3.Text = Convert.ToString(err);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
          webBrowser1.Navigate("http://192.168.1.16:81");           
        }


        private void Btn_forw_Click(object sender, EventArgs e)
        {
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes("A");
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
            Thread.Sleep(500);
        }

        private void Btn_rev_Click(object sender, EventArgs e)
        {
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes("B");
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
            Thread.Sleep(500);
        }

        private void Btn_right_Click(object sender, EventArgs e)
        {
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes("D");
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
            Thread.Sleep(500);
        }

        private void Btn_left_Click(object sender, EventArgs e)
        {
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes("C");
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
            Thread.Sleep(500);
        }

        private void Btn_stp_Click(object sender, EventArgs e)
        {
            byte[] outStream4;
            outStream4 = System.Text.Encoding.ASCII.GetBytes("E");
            serverStream.Write(outStream4, 0, outStream4.Length);
            serverStream.Flush();
            Thread.Sleep(500);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
          //  rec();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            clientSocket1.Close();
            this.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //  rec();
        }
/*
        private void rec()
        {
            byte[] inStream = new byte[1];
            shp_fir.BackColor = System.Drawing.Color.White;
            Shp_bi.BackColor = System.Drawing.Color.White;
            Shp_gass.BackColor = System.Drawing.Color.White;

            serverStream.ReadTimeout = 500;
            if (serverStream.DataAvailable)
            {
                serverStream.Read(inStream, 0, 1);
                string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                //  textBox1.Text += returndata;
                Comdata += returndata;

                if (Comdata.Substring(0, 1) == "f")
                {
                    shp_fir.BackColor = System.Drawing.Color.Red;
                    Shp_gass.BackColor = System.Drawing.Color.White;
                    Shp_bi.BackColor = System.Drawing.Color.White;
                }
                else if (Comdata.Substring(0, 1) == "b")
                {
                    Shp_bi.BackColor = System.Drawing.Color.Red;
                    shp_fir.BackColor = System.Drawing.Color.White;
                    Shp_gass.BackColor = System.Drawing.Color.White;
                }
                else if (Comdata.Substring(0, 1) == "g")
                {
                    Shp_gass.BackColor = System.Drawing.Color.Red;
                    shp_fir.BackColor = System.Drawing.Color.White;
                    Shp_bi.BackColor = System.Drawing.Color.White;
                }

                else
                {
                    shp_fir.BackColor = System.Drawing.Color.White;
                    Shp_bi.BackColor = System.Drawing.Color.White;
                    Shp_gass.BackColor = System.Drawing.Color.White;
                    Comdata = null;
                }
                //    shp_mine.BackColor = System.Drawing.Color.White;
                //  Shp_ul.BackColor = System.Drawing.Color.White;
                Comdata = null;
            }
            Comdata = null;

        }


  */      
    }
}