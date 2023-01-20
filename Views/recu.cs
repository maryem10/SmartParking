using SmartParking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking.Views.UserController
{
    public partial class recu : Form
    {
        private Ticket ticket;
        private readonly park _prunt;

        public recu(park prunt)
        {
            InitializeComponent();
            this._prunt = prunt;
        }

        public recu()
        {
        }

        internal Ticket Ticket { get => ticket; set => ticket = value; }

        private void Form6_Load(object sender, EventArgs e)
        {
            /*DateTime dateF = ticket.DateEmp;
            labelDate.Text = dateF.ToString("dddd, dd MMMM yyyy HH:mm:ss");

            labelDateS.Text = dateF.ToString("MM/dd/yyyy HH:mm:ss");

            DateTime finTime = dateF;
            TimeSpan span = finTime.Subtract(dateD);

            nbrHours.Text = span.Days + " Jours, " + span.Hours + " Heurs, " + span.Minutes + " Min, " + span.Seconds + " Sec";
            labelCost.Text = cost.ToString();*/

            richBox.Clear();
            richBox.Text += "        Ticket : "+ticket+"   \n";
            richBox.Text += "*********************************\n";
            richBox.Text += "***         Bienvenue         ***\n";
            richBox.Text += "*********************************\n\n\n";
            richBox.Text += " Responsable : "+ticket.IdUser.Nom+" "+ticket.IdUser.Prenom;
            richBox.Text += " Client : "+ ticket.IdRes.Ownername;
            richBox.Text += " Model : "+ ticket.IdRes.Model;
            richBox.Text += " Matricule : "+ ticket.IdRes.Matricule;
            richBox.Text += " Matricule : " + ticket.IdRes.Matricule;

            richBox.Text += " Total : "+ ticket.Total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richBox.Text, new Font("Microsoft sans serif", 18, FontStyle.Bold), Brushes.Black, new Point());
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
