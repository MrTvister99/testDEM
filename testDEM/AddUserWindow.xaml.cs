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

namespace testDEM
{
   
    public partial class AddUserWindow : Window
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Product { get; set; }
        public AddUserWindow()
        {
            InitializeComponent();
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Name = NameTextBox.Text;
            Email = EmailTextBox.Text;
            Product = ProductTextBox.Text;
            this.DialogResult = true;
        }
    }
}
