﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartParking.Models;
//using MySql.Data.MySqlClient;
using MySqlConnector;

namespace SmartParking.Controllers
{
    internal class UserControlle
    {

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
        public static void AjouterUser(User user)
        {
            string sql = "INSERT INTO user VALUES (@id, @role, @username, @password, @nom, @prenom, @cin)";
            MySqlConnection cnn = GetConnection(); MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value=  user.Id;
            cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = user.Role;
            cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value =user.Username;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = user.Password;
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = user.Nom;
            cmd.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = user.Prenom;
            cmd.Parameters.Add("@cin", MySqlDbType.VarChar).Value = user.Cin;
            try
            {
                cmd.ExecuteNonQuery();
                
                MessageBox.Show(" ajouter aves success.", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(" n'est pas ajouter ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            cnn.Close();
        }
        public static void UpdateUser(User user, int id)
        {
            string sql = "UPDATE users SET role = @role, username = @username, password = @password, nom = @nom, prenom = @prenom, nom = @nom , cin = cin    WHERE id = @id ";
            MySqlConnection cnn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = user.Role;
            cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value =user.Username;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = user.Password;
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value =user.Nom;
            cmd.Parameters.Add("@prenom", MySqlDbType.VarChar).Value =user.Password;
            cmd.Parameters.Add("@cin", MySqlDbType.VarChar).Value = user.Cin;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("L'utilisatauer modifier aves success.", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("L'utilisateur n'est pas modifier ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            cnn.Close();
        }

        public static void SupprimerUser(int idC)
        {
            MySqlConnection cnn = GetConnection();
            string sql = "DELETE FROM user WHERE id = @id ";
            
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idC; ;
           

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(" supprimer aves success.", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(" n'est pas supprimer ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            cnn.Close();
        }
        public static DataTable Rechercher(string cin)
        {
            MySqlConnection cnn = GetConnection();
            string loadData = "select * from user where cin='" + cin + "'";
            MySqlCommand cmd = new MySqlCommand(loadData,  cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            cnn.Close();
            return dt;
        }
        public static DataTable LoadData()
        {
            MySqlConnection cnn = GetConnection();
            string loadData = "select * from user";
            MySqlCommand cmd = new MySqlCommand(loadData, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            cnn.Close();
            return dt;
        }
    }
}
