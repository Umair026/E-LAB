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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string abc;
       // private delegate void check_data();
        //check_data rec_data = new check_data(serial_data);
        //private Thread demoThread = null;
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
           // this.SetText("This text was set safely.");
            this.textBox1.Text = abc;
         
        }


        private void check(object sender,EventArgs e)
        {
          
          //abc.charAt(0);
          if (abc.Substring(0, 1) == "T")
          {
              this.textBox1.Text = abc.Substring(1, 3);
              abc = "";
          }
          else if (abc.Substring(0, 1) == "C")
          {
              this.textBox2.Text = abc.Substring(1, 3);
              abc = "";
          }
          else if (abc.Substring(0, 1) == "F")
          {
              this.textBox3.Text = abc.Substring(1, 3);
              abc = "";
          }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }
    }
}
