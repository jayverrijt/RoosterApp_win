using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        private string _username;
        private connection conn = new connection();
        private MySqlCommand command;
        private MySqlCommand commandb;

        public void main ()
        {
            
        }
        public Dashboard(string username)
        {
            InitializeComponent();
            main();
            _username = username;
            DataContext = new DashboardViewModel();
        }

        private void usersBtn(object sender, RoutedEventArgs e) {
            UserControl userctrlwindow = new UserControl();
            userctrlwindow.Show();
        }

        private void logOffbtn(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.OpenConnection();
                string quUpdateSession = "UPDATE users SET insession='0' WHERE username =" + _username + "";
                MySqlCommand cmdc;
                cmdc = new MySqlCommand(quUpdateSession, conn.get_connection());
                MySqlDataReader MyReaderC;
                MyReaderC = cmdc.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
            
        }

        private void btnSelectedUser(object sender, RoutedEventArgs e)
        {
            projectSecrets pos = new projectSecrets();
            ioLabelSelUser.Visibility = Visibility.Hidden;
            ioUserListBorder.Visibility = Visibility.Visible;
        }

        class connection
        {
            private MySqlConnection conn;

            public connection()
            {
                Initilize();
            }

            private void Initilize()
            {
                projectSecrets pos = new projectSecrets();
                conn = new MySqlConnection(pos.connectionString);
            }
            public bool OpenConnection()
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (MySqlException e)
                {
                    switch (e.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot conn to server");
                            break;
                        case 1045:
                            MessageBox.Show("Invalid Username/Passwrd - Server");
                            break;
                    }
                    return false;
                }
            }
            public void close_conn()
            {
                this.conn.Close();
            }

            public MySqlConnection get_connection()
            {
                return this.conn;
            }


        }


    }
}
