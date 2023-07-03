using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_RoosterApp
{
    public class User : NotifyPropertyBase
    {
        private int _id;
        private string _username;
        public int Id { 
            get { return _id; }
            set {
                _id = value; 
                OnPropertyChanged(nameof(Id));
            }
        }
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public static ObservableCollection<User> FetchUsers()
        {
            projectSecrets pos = new projectSecrets();
            string query = "SELECT * FROM users";
            MySqlConnection conn = null;
            MySqlDataReader rdr = null;

            conn = new MySqlConnection(pos.connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            rdr = cmd.ExecuteReader();
            ObservableCollection<User> users = new ObservableCollection<User>();
            while (rdr.Read())
            {
                users.Add(new User()
                {
                    Id = rdr.GetInt32(0),
                    Username = rdr.GetString(1)
                });
            
            }
            conn.Close();
            return users;
        }
    }
}
