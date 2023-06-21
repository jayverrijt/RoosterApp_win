using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Interaction logic for UserControl.xaml
    /// </summary>
    public partial class UserControl : Window
    {
        string connect;
     

        public UserControl()
        {
            InitializeComponent();
        }

        private void btnMenuUsers_Click(object sender, RoutedEventArgs e)
        {
            ioGridUser.Visibility = Visibility.Visible;
            ioGridAdmins.Visibility = Visibility.Hidden;
        }

        private void btnMenuAdmins_Click(object sender, RoutedEventArgs e)
        {

            ioGridAdmins.Visibility = Visibility.Visible;
            ioGridUser.Visibility = Visibility.Hidden;
        }

        private void btnMenuClose_Click(object sender, RoutedEventArgs e) { this.Close(); }

        public void ioAddUsers(object sender, RoutedEventArgs e)
        {
            string connectionString = @"server=localhost;userid=root;password=;database=ratest0";
            MySqlConnection conn = null;
            MySqlDataReader rdr = null;

            try 
            {
                List<Button> buttonList = new List<Button>();
                conn = new MySqlConnection(connectionString);
                conn.Open();
                string query = "SELECT * FROM users";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                string vypis = "";
                while (rdr.Read())
                {

                    vypis += (rdr.GetString(1) + "\n");

                }
                ioListBox.Text = vypis;
                conn.Close();

            } catch (MySqlException ex) {
                MessageBox.Show("Err");
            }
        }

        public void btnToRemoveUser(object sender, RoutedEventArgs e)
        {
            rmUser rmUser = new rmUser();
            rmUser.Show();
        }

        public void btnToAddUser(object sender, RoutedEventArgs e)
        {
            addUser addUser = new addUser();
            addUser.Show();
        }
     }
}
