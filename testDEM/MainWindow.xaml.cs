using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace testDEM
{
    
    public partial class MainWindow : Window
    {
        public BindingList<User> Users { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Users = new BindingList<User>
        {
            new User { Name = "Имя 1", Email = "email1@example.com", Product = "Товар 1" },
            new User { Name = "Имя 2", Email = "email2@example.com", Product = "Товар 2" },
        };
            this.DataContext = this;
            BindingOperations.SetBinding(userListView, ListView.ItemsSourceProperty, new Binding("Users"));
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow();
            if (addUserWindow.ShowDialog() == true)
            {
                Users.Add(new User { Name = addUserWindow.Name, Email = addUserWindow.Email, Product = addUserWindow.Product });
            }
        }

        private void RemoveUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditUser_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Product { get; set; }
    }
   
       

    }
