using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;

namespace Win_RoosterApp
{
    public partial class MainWindow : Window
    {
        private string username, password, sql, sqlb;
        private connection conn = new connection();
        private MySqlCommand command;
        private MySqlCommand commandb;


        private void login_Button(object sender, RoutedEventArgs e)
        {
            username = userBox.Text;
            password = passBox.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) )
            {
                MessageBox.Show("Username / Password is leeg");
            } else
            {
                sql = "SELECT * FROM users WHERE username = '" + username + "' AND password = '" + password + "'";  
                if(conn.OpenConnection() == true)
                {
                    try {
                        command = new MySqlCommand(sql, conn.get_connection());
                        object a = command.ExecuteScalar();

                        if (a == null)
                        {
                            MessageBox.Show("Ingevoerde gebruikersnaam of wachtwoord is fout!");
                        } else
                        {
                            conn.close_conn();
                            // Sessions
                             sqlb = "SELECT insession FROM users WHERE username ='" + username + "' AND insession = 1";
                             if(conn.OpenConnection() == true)
                             {
                              try {
                                    commandb = new MySqlCommand(sqlb, conn.get_connection());
                                    object b = commandb.ExecuteScalar();

                                    if(b == null) {
                                        try
                                        {
                                            string quUpdateSession = "UPDATE users SET insession='1' WHERE username =" + username + "";
                                            MySqlCommand cmdc;
                                            cmdc = new MySqlCommand(quUpdateSession, conn.get_connection());
                                            MySqlDataReader MyReaderC;
                                            MyReaderC = cmdc.ExecuteReader();
                                            Dashboard dashboard = new Dashboard(username);
                                            dashboard.Show();
                                            this.Close();
                                        } catch (Exception exx)
                                        {
                                            MessageBox.Show(exx.Message);
                                        }
                                       
                                    }
                                    else {
                                        if (MessageBox.Show("Gebruiker " + username + " is al ingelogd, wil je deze uitloggen?", "Gebruiker " + username + " is al ingelogd", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                                        {
                                            try
                                            {
                                                string quUpdateSession = "UPDATE users SET insession='0' WHERE username =" + username + "";
                                                MySqlCommand cmdc;
                                                cmdc = new MySqlCommand(quUpdateSession, conn.get_connection());
                                                MySqlDataReader MyReaderC;
                                                MyReaderC = cmdc.ExecuteReader();
                                                
                                            } catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                            }
                                        } else
                                        {
                                            conn.close_conn();
                                            this.Close();
                                        }
                                    }
                               } catch (MySqlException xy)
                                {
                                    MessageBox.Show("Unexpected Error: " + xy);
                                }
                             }
                         // Eind Sessions
                        }
                    } catch (MySqlException x) {
                        MessageBox.Show("Unexpected Error:" + x);
;                   }
                }
            }
            userBox.Text = "";
            passBox.Password = "";
            conn.close_conn();
        }

        public MainWindow ()
        {
            InitializeComponent ();
        }
        class connection
        {
            private MySqlConnection conn;
            private string server;
            private string user;
            private string pass;
            private string db;

            public connection()
            {
                Initilize();
            }

            private void Initilize()
            {
                server = "localhost";
                db = "ratest0";
                user = "root";
                pass = "";
                string connectionString;
                connectionString = "Data Source=" + server + ";Database=" + db + ";User Id=" + user + ";Password=" + pass + ";SSL Mode=0";
                conn = new MySqlConnection(connectionString);
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
