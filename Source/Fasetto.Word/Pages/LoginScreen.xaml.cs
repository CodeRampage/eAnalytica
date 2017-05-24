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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Emissions_Analytica.Pages
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Page
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            string uid = txtUsername.Text;
            string pwd = txtPassword.Text;

            DBHelper.init(uid, pwd);
            if (DBHelper.login())
                MessageBox.Show("Successful Login");
            else
            {
                lblLoginStatus.Content = "Login Failed, check credentials";
                lblLoginStatus.Visibility = Visibility.Visible;
            }                
        }

        private void hideErrorMessage(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).Text = "";
        }

        private void hideErrorMessage(object sender, TextChangedEventArgs e)
        {
            lblLoginStatus.Visibility = Visibility.Hidden;
        }
    }
}
