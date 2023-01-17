
using MySqlConnector;
using SmartParking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Bibliotheque
{
    public partial class Statistique : Form
    {
        private int nbreclient;

        public static MySqlConnection cnx = Program.GetConnection();
        public Statistique()
        {
            cnx.Close();
            InitializeComponent();
            loadclient();
            loademploye();
            loademprunt();
            Loadretard();
            Loadrendu();

        }
        private void Loadretard()
        {


            MySqlCommand msqlq = new MySqlCommand("select count(*) as quantite from  emprunt where dateRetour is  NULL and NOW() > FinEmprunt", cnx);
            DataTable ds = new DataTable();
            cnx.Open();
            MySqlDataReader dr = msqlq.ExecuteReader();
            if (dr.Read())
            {
                label11.Text = dr["quantite"].ToString();

            }
            dr.Close();
            cnx.Close();

        }
        private void Loadrendu()
        {


            MySqlCommand msqlq = new MySqlCommand("select count(*) as quantite from  emprunt where dateRetour is not NULL ", cnx);
            DataTable ds = new DataTable();
            cnx.Open();
            MySqlDataReader dr = msqlq.ExecuteReader();
            if (dr.Read())
            {
                label15.Text = dr["quantite"].ToString();

            }
            dr.Close();
            cnx.Close();

        }
        private void loadclient()
        {
            MySqlCommand msqlq = new MySqlCommand("SELECT count(distinct cin) as quantite FROM emprunt ", cnx);
            cnx.Open();
            MySqlDataReader dr = msqlq.ExecuteReader();
            if (dr.Read())
            {
                label5.Text = dr["quantite"].ToString();
                
            }
            dr.Close();
            cnx.Close();
        }
        private void loademploye()
        {
            MySqlCommand msqlq = new MySqlCommand("SELECT count(*) as quantite FROM user ", cnx);
            cnx.Open();
            MySqlDataReader dr = msqlq.ExecuteReader();
            if (dr.Read())
            {
                label8.Text = dr["quantite"].ToString();

            }
            dr.Close();
            cnx.Close();
        }
        private void loademprunt()
        {
            MySqlCommand msqlq = new MySqlCommand("SELECT count(*) as quantite FROM emprunt ", cnx);
            cnx.Open();
            MySqlDataReader dr = msqlq.ExecuteReader();
            if (dr.Read())
            {
                label2.Text = dr["quantite"].ToString();

            }
            dr.Close();
            cnx.Close();
        }

        private void Statistique_Load(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
