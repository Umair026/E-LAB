namespace WindowsFormsApplication2
{
    partial class Frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Btn_forw = new System.Windows.Forms.Button();
            this.Btn_right = new System.Windows.Forms.Button();
            this.Btn_left = new System.Windows.Forms.Button();
            this.Btn_rev = new System.Windows.Forms.Button();
            this.Btn_stp = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(7, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "rec";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(413, 360);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 66);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(413, 432);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 52);
            this.textBox2.TabIndex = 3;
            this.textBox2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 503);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(323, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Disconnect";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_heading
            // 
            this.lbl_heading.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl_heading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_heading.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.Color.White;
            this.lbl_heading.Location = new System.Drawing.Point(7, 7);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(836, 44);
            this.lbl_heading.TabIndex = 6;
            this.lbl_heading.Text = "label1";
            this.lbl_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_exit.ForeColor = System.Drawing.Color.White;
            this.Btn_exit.Location = new System.Drawing.Point(228, 279);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(208, 41);
            this.Btn_exit.TabIndex = 8;
            this.Btn_exit.Text = "Exit";
            this.Btn_exit.UseVisualStyleBackColor = false;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(103, 331);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 35);
            this.button5.TabIndex = 14;
            this.button5.Text = "Ip-Camera";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Btn_forw
            // 
            this.Btn_forw.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_forw.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_forw.ForeColor = System.Drawing.Color.Black;
            this.Btn_forw.Location = new System.Drawing.Point(129, 96);
            this.Btn_forw.Name = "Btn_forw";
            this.Btn_forw.Size = new System.Drawing.Size(173, 41);
            this.Btn_forw.TabIndex = 20;
            this.Btn_forw.Text = "Forward";
            this.Btn_forw.UseVisualStyleBackColor = false;
            this.Btn_forw.Click += new System.EventHandler(this.Btn_forw_Click);
            // 
            // Btn_right
            // 
            this.Btn_right.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_right.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_right.ForeColor = System.Drawing.Color.Black;
            this.Btn_right.Location = new System.Drawing.Point(290, 150);
            this.Btn_right.Name = "Btn_right";
            this.Btn_right.Size = new System.Drawing.Size(131, 41);
            this.Btn_right.TabIndex = 21;
            this.Btn_right.Text = "Right";
            this.Btn_right.UseVisualStyleBackColor = false;
            this.Btn_right.Click += new System.EventHandler(this.Btn_right_Click);
            // 
            // Btn_left
            // 
            this.Btn_left.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_left.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_left.ForeColor = System.Drawing.Color.Black;
            this.Btn_left.Location = new System.Drawing.Point(9, 150);
            this.Btn_left.Name = "Btn_left";
            this.Btn_left.Size = new System.Drawing.Size(131, 41);
            this.Btn_left.TabIndex = 22;
            this.Btn_left.Text = "Left";
            this.Btn_left.UseVisualStyleBackColor = false;
            this.Btn_left.Click += new System.EventHandler(this.Btn_left_Click);
            // 
            // Btn_rev
            // 
            this.Btn_rev.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_rev.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_rev.ForeColor = System.Drawing.Color.Black;
            this.Btn_rev.Location = new System.Drawing.Point(129, 204);
            this.Btn_rev.Name = "Btn_rev";
            this.Btn_rev.Size = new System.Drawing.Size(173, 41);
            this.Btn_rev.TabIndex = 23;
            this.Btn_rev.Text = "Reverse";
            this.Btn_rev.UseVisualStyleBackColor = false;
            this.Btn_rev.Click += new System.EventHandler(this.Btn_rev_Click);
            // 
            // Btn_stp
            // 
            this.Btn_stp.BackColor = System.Drawing.Color.White;
            this.Btn_stp.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_stp.ForeColor = System.Drawing.Color.Black;
            this.Btn_stp.Location = new System.Drawing.Point(156, 150);
            this.Btn_stp.Name = "Btn_stp";
            this.Btn_stp.Size = new System.Drawing.Size(116, 41);
            this.Btn_stp.TabIndex = 24;
            this.Btn_stp.Text = "Stop";
            this.Btn_stp.UseVisualStyleBackColor = false;
            this.Btn_stp.Click += new System.EventHandler(this.Btn_stp_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(442, 55);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(401, 331);
            this.webBrowser1.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 385);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Btn_stp);
            this.Controls.Add(this.Btn_rev);
            this.Controls.Add(this.Btn_left);
            this.Controls.Add(this.Btn_right);
            this.Controls.Add(this.Btn_forw);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.lbl_heading);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Frm_main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Btn_forw;
        private System.Windows.Forms.Button Btn_right;
        private System.Windows.Forms.Button Btn_left;
        private System.Windows.Forms.Button Btn_rev;
        private System.Windows.Forms.Button Btn_stp;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer timer1;
    }
}

