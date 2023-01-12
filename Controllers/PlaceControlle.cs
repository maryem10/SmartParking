﻿using MySqlConnector;
using SmartParking.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking.Controllers
{
    internal class PlaceControlle
    {
        public static MySqlConnection cnn = Program.GetConnection();
        //id	code	status	type	
        public static void AjouterPlace(Place user)
        {
            string sql = "INSERT INTO place VALUES (@id, @code, @status, @type)";

            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = user.Id;
      
            cmd.Parameters.Add("@code", MySqlDbType.VarChar).Value = user.Code;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = user.Status;
        
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = user.Type;
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
        public static void UpdatePlace(Place user, string id)
        {
            string sql = "UPDATE place SET code=@code, status=@status, typerole=@type WHERE id = @id ";

            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            cmd.Parameters.Add("@code", MySqlDbType.VarChar).Value = user.Code;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = user.Status;

            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = user.Type;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Place modifier aves success.", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Place n'est pas modifier ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            cnn.Close();
        }

        public static void SupprimerPlace(string idC)
        {
            string sql = "DELETE FROM place WHERE id = @id ";

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
    }
}
