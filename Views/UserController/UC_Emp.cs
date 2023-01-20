using System;
using System.Collections.Generic;
using SmartParking.Controllers;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SmartParking.Models;
using System.Web.UI.WebControls;
using Guna.UI2.WinForms;

namespace SmartParking.Views.UserController
{
    public partial class UC_Emp : UserControl
    {

        DataGridViewRow selectedRow;
        Boolean isSelected = false;
        int currRowIndex = 0;
        public UC_Emp()
        {
            InitializeComponent();
            UserControlle uc = new UserControlle();

           
        }
        

        private void UC_Emp_Load(object sender, EventArgs e)
        {
            clearInputs();
            dataGridView1.DataSource = Controllers.UserControlle.LoadData();
        }

        private void clearInputs()
        {
            txttxt_Password.Clear();
            txt_Id.Clear();
            txt_UserName.Clear();
            txtId.Clear();
            textBox_Nom.Clear();
            textBox_Prenom.Clear();
            text_CIN.Clear();
            comboBox1_role.SelectedIndex = -1;
        }
      
        private void pictureBox_Ajouter_Click(object sender, EventArgs e)
        {// public User(string role, string username, string password, string nom, string prenom, string cin)

            User u = new User(comboBox1_role.Items[comboBox1_role.SelectedIndex].ToString(), txt_UserName.Text, txttxt_Password.Text, textBox_Nom.Text, textBox_Prenom.Text, text_CIN.Text);
            UserControlle.AjouterUser(u);


            dataGridView1.DataSource = UserControlle.LoadData();

        }

        private void pictureBox_Rechercher_Click(object sender, EventArgs e)
        {
            SearchData();
        }
        public void SearchData()
        {
            if (txtSrch.Text != "")
            {
                dataGridView1.DataSource = UserControlle.Rechercher(txtSrch.Text);
            }
            else
            {
                dataGridView1.DataSource = UserControlle.LoadData();
                MessageBox.Show("Veuillez remplir le champ du recherche");
            }


        }

        private void pictureBox_Modifier_Click(object sender, EventArgs e)
        {
           
            if (txtId.Text != "")
            {
                if (txt_UserName.Text != "" && txttxt_Password.Text != "" && textBox_Nom.Text != "" && text_CIN.Text != "" && comboBox1_role.SelectedIndex == -1)
                {
                    DialogResult result = MessageBox.Show("voulez-vous vraiment modifier le l'employe ?", "Modifier", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        User u = new User(comboBox1_role.Items[comboBox1_role.SelectedIndex].ToString(), txt_UserName.Text, txttxt_Password.Text, textBox_Nom.Text, textBox_Prenom.Text, text_CIN.Text);

                        UserControlle.UpdateUser(u, currRowIndex);
                        clearInputs();
                    }

                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs");
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectioner le client que vous-voulez modifier");

            }



        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            if (dataGridView1.SelectedCells.Count > 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                
                isSelected = true;
                currRowIndex = Convert.ToInt32(row.Cells[0].Value);
                selectedRow = dataGridView1.Rows[currRowIndex];
                comboBox1_role.Text = row.Cells[1].Value.ToString();
                txt_UserName.Text = row.Cells[2].Value.ToString();
                txttxt_Password.Text = row.Cells[3].Value.ToString();
                textBox_Nom.Text = row.Cells[4].Value.ToString();
                textBox_Prenom.Text = row.Cells[5].Value.ToString();
                textBox_Prenom.Text = row.Cells[6].Value.ToString();
            }

            
        }

    }
}
