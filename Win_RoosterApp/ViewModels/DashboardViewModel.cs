using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Win_RoosterApp
{
    public class DashboardViewModel : NotifyPropertyBase
    {
        projectSecrets pos =new projectSecrets();
        private ObservableCollection<User>_users;


        public  ObservableCollection<User> Users
        {
            get { return _users; }
            set { _users = value;
                OnPropertyChanged(nameof(Users));
            }

        }

        
        
        public DashboardViewModel() 
        {
            Users = User.FetchUsers();
        }
    }
}
