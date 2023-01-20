using MySqlConnector;
using SmartParking.Models;
using System;
using System.Data;
using System.Speech.Synthesis;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SmartParking.Views.UserController
{
    public partial class UC_Home : UserControl
    {
        public static MySqlConnection cnx = Program.GetConnection1();
        public UC_Home()
        {
            cnx.Close();
            InitializeComponent();
            load_profit();
            Load_currentParck();
            Load_ticket();
            load_ClientToday();
            StatChart1();
            StatChart2();
            chart2_Click();
            load_data();
        }

        //nombre des place reserve au le status occupeé
        private void Load_currentParck()
        {
            //Had l req mazala khasha tbadel ela hasb chnu dar aimrane f status dial reservation 
            MySqlCommand req = new MySqlCommand("select count(*) as Quantite from reservation where status =1", cnx);
            DataTable ds = new DataTable();
            cnx.Open();
            MySqlDataReader dr = req.ExecuteReader();
            if (dr.Read())
            {
                label5.Text = dr["Quantite"].ToString();
            }
            dr.Close();
            cnx.Close();

        }//card Nb Client/reservation par jour
        private void load_ClientToday()
        {

            MySqlCommand req = new MySqlCommand("SELECT count(*) as Client from reservation where dateEnreg = CURRENT_DATE ();", cnx);
            DataTable ds = new DataTable();
            cnx.Open();
            MySqlDataReader dr = req.ExecuteReader();
            if (dr.Read())
            {
                label8.Text = dr["Client"].ToString();
            }
            dr.Close();
            cnx.Close();

        }
        //card profit par jour
        private void load_profit()
        {
            MySqlCommand req = new MySqlCommand("SELECT SUM(total) as Profit FROM ticket WHERE dateEmp = CURRENT_DATE();", cnx);
            DataTable ds = new DataTable();
            cnx.Open();
            MySqlDataReader dr = req.ExecuteReader();
            if (dr.Read())
            {
                if (dr["Profit"].ToString() == "")
                {
                    label14.Text = "0";
                }
                else label14.Text = dr["Profit"].ToString();

            }
            dr.Close();
            cnx.Close();
        }
        //nbr des ticket au bien nombre des reservation liberé par jour
        private void Load_ticket()
        {
            MySqlCommand req = new MySqlCommand("SELECT count(*) as ticket from ticket where dateEmp = CURRENT_DATE ();", cnx);
            DataTable ds = new DataTable();
            cnx.Open();
            MySqlDataReader dr = req.ExecuteReader();
            if (dr.Read())
            {
                label11.Text = dr["ticket"].ToString();
            }
            dr.Close();
            cnx.Close();
        }


        public void StatChart1()
        {
            MySqlCommand req = new MySqlCommand("select YEAR(`dateEnreg`) as Annee ,count(YEAR(`dateEnreg`)) as NB_Res  from reservation  GROUP by year(`dateEnreg`);", cnx);
            DataTable ds = new DataTable();
            cnx.Open();
            MySqlDataReader dr = req.ExecuteReader();
            if (dr.Read())
            {
                chart1.Series["NB_Res"].IsVisibleInLegend = false;
                this.chart1.Series["NB_Res"].Points.AddXY((dr["Annee"].ToString()), int.Parse(dr["NB_Res"].ToString()));
            }
            dr.Close();
            cnx.Close();
        }

        public void StatChart2()
        {
            MySqlCommand req1 = new MySqlCommand("select type , count(type) as nb from reservation GROUP by type;;", cnx);


            cnx.Open();
            MySqlDataReader dr = req1.ExecuteReader();

            while (dr.Read())
            {

                chart2.Series["Type"].IsValueShownAsLabel = true;
                chart2.Series["Type"].LegendText = dr["type"].ToString();
                chart2.Series["Type"].Points.AddXY((dr["type"].ToString()), int.Parse(dr["nb"].ToString()));
            }
            dr.Close();
            cnx.Close();
        }
        //
        private void chart2_Click()
        {

            MySqlCommand req1 = new MySqlCommand("select YEAR(`dateEmp`) as Annee, SUM(total)as totalAnnee from ticket GROUP by year(`dateEmp`) ", cnx);


            cnx.Open();
            MySqlDataReader dr = req1.ExecuteReader();

            while (dr.Read())
            {


                chart3.Series["Profit"].Points.AddXY((dr["Annee"].ToString()), dr["totalAnnee"]);
            }
            dr.Close();
            cnx.Close();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
       private void load_data()
        {
            dataGridView1.DataSource = Controllers.ReservationControlle.LoadData();
        }

       
    }
    
}
