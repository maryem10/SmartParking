using System.Windows.Forms;


namespace SmartParking.Views.UserController
{
    partial class checkout
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.nbrHours = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelDateS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.nbrHours);
            this.panel3.Controls.Add(this.labelDateS);
            this.panel3.Controls.Add(this.labelTotal);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(46, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 10);
            this.panel3.TabIndex = 12;
            // 
            // nbrHours
            // 
            this.nbrHours.AutoSize = true;
            this.nbrHours.BackColor = System.Drawing.Color.LimeGreen;
            this.nbrHours.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nbrHours.ForeColor = System.Drawing.Color.White;
            this.nbrHours.Location = new System.Drawing.Point(232, 45);
            this.nbrHours.Name = "nbrHours";
            this.nbrHours.Size = new System.Drawing.Size(195, 28);
            this.nbrHours.TabIndex = 12;
            this.nbrHours.Text = "\t05/29/2015 05:50:06";
            this.nbrHours.Visible = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotal.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelTotal.Location = new System.Drawing.Point(213, 125);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(53, 28);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "2.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(22, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(187, 28);
            this.label16.TabIndex = 9;
            this.label16.Text = "Total à payer (DH) :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(329, 16);
            this.label15.TabIndex = 8;
            this.label15.Text = "==============================================";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label14.Location = new System.Drawing.Point(22, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(261, 28);
            this.label14.TabIndex = 2;
            this.label14.Text = "Coût heure de parking (DH) :";
            this.label14.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.Location = new System.Drawing.Point(22, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 28);
            this.label12.TabIndex = 1;
            this.label12.Text = "Total de temps parking : ";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.Location = new System.Drawing.Point(22, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Date Sortie : ";
            this.label11.Visible = false;
            // 
            // labelDateS
            // 
            this.labelDateS.AutoSize = true;
            this.labelDateS.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDateS.Location = new System.Drawing.Point(141, 15);
            this.labelDateS.Name = "labelDateS";
            this.labelDateS.Size = new System.Drawing.Size(195, 28);
            this.labelDateS.TabIndex = 11;
            this.labelDateS.Text = "\t05/29/2015 05:50:06";
            this.labelDateS.Visible = false;
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(670, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(185, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "checkout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(40, 399);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(231, 26);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "Friday, 29 May 2015 05:50:06";
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelCost.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelCost.Location = new System.Drawing.Point(161, 448);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(53, 28);
            this.labelCost.TabIndex = 17;
            this.labelCost.Text = "2.00";
            this.labelCost.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(532, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "2.00";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(70, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 15);
            this.textBox1.TabIndex = 45;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Bauhaus 93", 10.8F);
            this.label19.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label19.Location = new System.Drawing.Point(505, 111);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 20);
            this.label19.TabIndex = 46;
            this.label19.Text = "Model";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(438, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 15);
            this.textBox2.TabIndex = 47;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bauhaus 93", 10.8F);
            this.label18.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label18.Location = new System.Drawing.Point(120, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 20);
            this.label18.TabIndex = 48;
            this.label18.Text = "Matricule";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(71, 163);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(177, 1);
            this.panel5.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(439, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 1);
            this.panel2.TabIndex = 50;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(67, 295);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(178, 15);
            this.textBox4.TabIndex = 52;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 10.8F);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(117, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "CIN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bauhaus 93", 10.8F);
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(533, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel6.Location = new System.Drawing.Point(68, 315);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(177, 1);
            this.panel6.TabIndex = 54;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(466, 295);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(178, 15);
            this.textBox5.TabIndex = 52;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel7.Location = new System.Drawing.Point(467, 315);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(177, 1);
            this.panel7.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label13.Location = new System.Drawing.Point(14, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 28);
            this.label13.TabIndex = 1;
            this.label13.Text = "Cash : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label17.Location = new System.Drawing.Point(16, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 28);
            this.label17.TabIndex = 2;
            this.label17.Text = "Reste : ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(16, 47);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(109, 22);
            this.textBox6.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(16, 114);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(109, 22);
            this.textBox7.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox7);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(654, 485);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 10);
            this.panel4.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(311, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 95;
            this.label9.Text = "Paiement";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(260, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 20);
            this.label10.TabIndex = 94;
            this.label10.Text = "Informationde Client";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label20.Location = new System.Drawing.Point(248, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(200, 20);
            this.label20.TabIndex = 93;
            this.label20.Text = "Information de vehicule";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(426, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 34);
            this.button2.TabIndex = 96;
            this.button2.Text = "Annuler ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(410, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 97;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(70, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 98;
            this.label4.Text = "Cost";
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(715, 551);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel3;
        private Label label15;
        private Label label14;
        private Label nbrHours;
        private Label labelTotal;
        private Label label16;
        private Label labelDateS;
        private Label label12;
        private Label label11;
        private Panel panel1;
        private Button button1;
        private Label labelDate;
        private Label labelCost;
        private Label label1;
        private TextBox textBox1;
        private Label label19;
        private TextBox textBox2;
        private Label label18;
        private Panel panel5;
        private Panel panel2;
        private TextBox textBox4;
        private Label label5;
        private Label label7;
        private Panel panel6;
        private TextBox textBox5;
        private Panel panel7;
        private Label label13;
        private Label label17;
        private TextBox textBox6;
        private TextBox textBox7;
        private Panel panel4;
        private Label label9;
        private Label label10;
        private Label label20;
        private Button button2;
        private Label label3;
        private Label label4;
    }
}