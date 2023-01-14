using MySqlConnector;
using SmartHome;
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

        public static MySqlConnection con = Program.GetConnection();
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            try
            {
                if (con.State != ConnectionState.Open) { con.Open(); }
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
                    UserV ff = new UserV();
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
