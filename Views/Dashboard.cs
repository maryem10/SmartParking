using MySqlConnector;
using SmartParking.Views.UserController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=smartparking";
            MySqlConnection cnn = new MySqlConnection(sql);

            try
            {
                cnn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Can not open connection ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cnn;

        }
        private void addUserControl( UserControl userControl)
        {
            userControl.Dock= DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        { 
            UC_Home uc = new UC_Home();
            addUserControl(uc);
            label2.Text = button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
            label2.Text = button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UC_Emp uc = new UC_Emp();
            addUserControl(uc);
            label2.Text = button7.Text;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            park uc = new park();
            addUserControl(uc);
            label2.Text = button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            Tickets uc = new Tickets();
            addUserControl(uc);
            label2.Text = button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddPlace uc = new AddPlace();
            addUserControl(uc);
            label2.Text = button9.Text;
        }
    }
}
