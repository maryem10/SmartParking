using Guna.UI2.WinForms;
using MySqlConnector;
using SmartParking.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking.Views.UserController
{
    public partial class Tickets : UserControl
    {
        public Tickets()
        {
            InitializeComponent();
        }
        

        public void load()
        {
            dataGridView1.DataSource = Controllers.TicketControlle.LoadData();

        }
        
        public void load_ticket()
        {

            DataTable data = new DataTable();
                 MySqlConnection cnn = TicketControlle.GetConnection();
       

            
           

            string request = "SELECT id, titre, auteur, editeur,isEmprunt as Etat FROM ouvrage WHERE type = 'l' and isEmprunt = 0";
            // MySqlCommand cmd = new MySqlCommand(request, connection);

            MySqlCommand cmd = new MySqlCommand(request, cnn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);

            dataGridView1.DataSource = data;

            cnn.Close();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
