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
using MahApps.Metro.Controls;
using ZTP.Controllers;

namespace ZTP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        ValidatorController validator = new ValidatorController();
        LoginController loginController = new LoginController();
        AfterLogin afterLoginWindow = new AfterLogin();
        SettingsController settingsController = new SettingsController();
        public MainWindow()
        {
            InitializeComponent();         
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (loginController.SignIn(txtUserName.Text, txtPassword.Text))
            {
                loginValidationLabel.DataContext = loginController.msg;
                afterLoginWindow.afterLoginUsername.Content = CurrentLoggedUser.Instance.GetUserName();
                this.Hide();
                settingsController.LoadSettings();
                afterLoginWindow.DataContext = settingsController.notifications;
                afterLoginWindow.Show();
            }
            else
            {
                loginValidationLabel.DataContext = loginController.msg;
            }
        }

        private void loginTyle_Click(object sender, RoutedEventArgs e)
        {
            loginFlyOut.IsOpen = true;
        }

        private void registerTile_Click(object sender, RoutedEventArgs e)
        {
            registerFlyOut.IsOpen = true;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (validator.ValidateIsLoginExists(txtRegisterLogin.Text))
            {
                registerValidationLabel.DataContext = validator.error;
            }
            else
            {
                if (validator.ValidatePasswords(txtRegisterPassword.Text, txtRegisterConfirmPassword.Text))
                {
                    RegisterController register = new RegisterController();
                    register.RegisterUser(txtRegisterLogin.Text, txtRegisterPassword.Text);
                    registerValidationLabel.DataContext = register.msg;
                    //Go to Login Page
                    registerFlyOut.IsOpen = false;
                    loginFlyOut.IsOpen = true;
                }
                else
                {
                    registerValidationLabel.DataContext = validator.error;
                }
            }
           
        }
    }
}
