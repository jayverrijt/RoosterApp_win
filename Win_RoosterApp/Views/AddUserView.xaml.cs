using MySql.Data.MySqlClient;
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
    /// Interaction logic for addUser.xaml
    /// </summary>
    public partial class addUser : Window
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void Button_AddUser(object sender, RoutedEventArgs e)
        {
            try
            {
                projectSecrets pos = new projectSecrets();
                MySqlConnection conn = null;
                conn = new MySqlConnection(pos.connectionString);
                MySqlDataReader dra = null;
                string query = "INSERT INTO users (username,password,insession) VALUES ('" + ioUsernameBox.Text + "', '" + ioPasswdbox.Password + "', '0')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                dra = cmd.ExecuteReader();
                conn.Close();
                this.Close();
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
