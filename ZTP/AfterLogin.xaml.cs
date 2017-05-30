using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using MahApps.Metro.Controls;
using ZTP.Controllers;
using ZTP.Models;
using ZTP.Properties;

namespace ZTP
{
    /// <summary>
    /// Interaction logic for AfterLogin.xaml
    /// </summary>
    public partial class AfterLogin 
    {
        SettingsController settingsController = new SettingsController();
        public AfterLogin()
        {
            
            InitializeComponent();            
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void SwitchUpdateEveryMin_Click(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toogleSwitch = sender as ToggleSwitch;
            if (toogleSwitch != null)
            {
                if (toogleSwitch.IsChecked == true)
                {
                    settingsController.UpdateEveryMin(true,txtUpdateEveryMin.Text);
                }
                else
                {
                    settingsController.UpdateEveryMin(false, txtUpdateEveryMin.Text);
                }
            }
        }

        private void SettingsTile_Click(object sender, RoutedEventArgs e)
        {
            SettingsFlyOut.IsOpen = true;
        }

        private void SwitchSoundWhenActionWasBought_Click(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toogleSwitch = sender as ToggleSwitch;
            if (toogleSwitch != null)
            {
                if (toogleSwitch.IsChecked == true)
                {
                    settingsController.ToggleUpdate(true, "SoundWhenActionWasBought");
                }
                else
                {
                    settingsController.ToggleUpdate(false, "SoundWhenActionWasBought");
                }
            }
        }

        private void SwitchSoundWhenActionWasSold_Click(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toogleSwitch = sender as ToggleSwitch;
            if (toogleSwitch != null)
            {
                if (toogleSwitch.IsChecked == true)
                {
                    settingsController.ToggleUpdate(true, "SoundWhenActionWasSold");
                }
                else
                {
                    settingsController.ToggleUpdate(false, "SoundWhenActionWasSold");
                }
            }
        }

        private void SwitchSoundWhenEmailWasSend_Click(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toogleSwitch = sender as ToggleSwitch;
            if (toogleSwitch != null)
            {
                if (toogleSwitch.IsChecked == true)
                {
                    settingsController.ToggleUpdate(true, "SoundWhenEmailWasSend");
                }
                else
                {
                    settingsController.ToggleUpdate(false, "SoundWhenEmailWasSend");
                }
            }
        }

        private void SwitchWhenPercentageWasChanged_Click(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toogleSwitch = sender as ToggleSwitch;
            if (toogleSwitch != null)
            {
                if (toogleSwitch.IsChecked == true)
                {
                    settingsController.ToggleUpdate(true, "SoundWhenPercentageWasChanged");
                }
                else
                {
                    settingsController.ToggleUpdate(false, "SoundWhenPercentageWasChanged");
                }
            }
        }
    }
}
