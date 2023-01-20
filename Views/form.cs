﻿using SmartParking.Controllers;
using SmartParking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartParking.Views.UserController
{
    public partial class checkout : Form
    {
        private string labelCode;
        private DateTime dateD;
        private DateTime dateF;
        private int cost;
        private string matricule;
        private string model;
        private string cin;
        private string fillname;
        private double total;
        private readonly park _prunt;

        public checkout(park prunt)
        {
            InitializeComponent();
            this._prunt = prunt;
        }
        public checkout()
        {
        }
        public string LabelCode { get => labelCode; set => labelCode = value; }
        public int Cost { get => cost; set => cost = value; }
        public DateTime DateD { get => dateD; set => dateD = value; }
        public string Matricule { get => matricule; set => matricule = value; }
        public string Model { get => model; set => model = value; }
        public string Cin { get => cin; set => cin = value; }
        public string Fillname { get => fillname; set => fillname = value; }
        public DateTime DateF { get => dateF; set => dateF = value; }
        public double Total { get => total; set => total = value; }

        private void button1_Click(object sender, EventArgs e)
        {


            //ParentForm.DialogResult = DialogResult.OK;

            DialogResult = DialogResult.OK;
            Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            //MessageBox.Show(matricule);
            textBox1.Text = matricule;
            textBox2.Text = model;
            textBox4.Text = cin;
            textBox5.Text = fillname;
            label1.Text = labelCode;
            labelDate.Location = new Point(169, 38);
            dateF = DateTime.Now;
            labelDate.Text = dateF.ToString("dddd, dd MMMM yyyy HH:mm:ss");

            labelDateS.Text = dateF.ToString("MM/dd/yyyy HH:mm:ss");

            DateTime finTime = dateF;
            TimeSpan span = finTime.Subtract(dateD);
            
            nbrHours.Text = span.Days + " Jours, " + span.Hours + " Heurs, " + span.Minutes + " Min, " + span.Seconds + " Sec";
            labelCost.Text = cost.ToString();
            
            double dif = (dateF - dateD).TotalHours;
            total = (dif * cost);
            labelTotal.Text = total.ToString("#.##");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ParentForm.DialogResult = DialogResult.OK;

            DialogResult = DialogResult.No;
            Hide();
        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}