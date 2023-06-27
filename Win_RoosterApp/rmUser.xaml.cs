﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Win_RoosterApp
{
    /// <summary>
    /// Interaction logic for rmUser.xaml
    /// </summary>
    public partial class rmUser : Window
    {
        public rmUser()
        {
            InitializeComponent();
        }

        private void RemoveUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                projectSecrets pos = new projectSecrets();
                MySqlConnection conn = null;
                conn = new MySqlConnection(pos.connectionString);
                MySqlDataReader dra = null;
                string query = "DELETE from users WHERE username =" + ioRemoveUser.Text + "";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                dra = cmd.ExecuteReader();
                conn.Close();
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
