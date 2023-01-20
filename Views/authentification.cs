using MySqlConnector;
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

namespace SmartParking
{
    public partial class authentification : Form
    {
        public authentification()
        {
            InitializeComponent(); 

            label4.Hide();
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
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = GetConnection();

            try
            {
                if (cnn.State != ConnectionState.Open) { cnn.Open(); }
                User us = new User();
                us.Username = textBox1_name.Text;
                us.Username = textBox_pswd.Text;
                //    Users u1 = homeService.AfficherUser(us);
                if (textBox1_name.Text == "" || textBox_pswd.Text == "")
                {
                    label4.Show();
                    //textBox1_name.BorderColor = Color.Red;
                    // textBox_pswd.BorderColor = Color.Red;
                    label1.Hide();
                }
                /*else if (homeService.LogUser(us))
                {
                    
                    ff.Getus(us.Name);
                    Console.WriteLine(us.Name);
                    //     Console.WriteLine(u1.Name+" Role :  "+ u1.Role);
                    ff.Show();
                    this.Hide();
                }*/

                else
                {

                    //textBox1_name.BorderColor = Color.Red;
                    // textBox_pswd.BorderColor = Color.Red;
                    textBox1_name.Clear();
                    textBox_pswd.Clear();
                    MessageBox.Show("Merhba !!");
                    Dashboard ff = new Dashboard();
                    ff.Show();
                    label1.Show();
                    label4.Hide();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DialogResult dd = MessageBox.Show("sql login !!");
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
