using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZTP.Annotations;
using ZTP.Models;

namespace ZTP.Controllers
{
    public class SettingsController
    {
        public SettingsNotification notifications = new SettingsNotification();
        public void LoadSettings()
        {           
            User user = CurrentLoggedUser.Instance.GetLoggedUser();
            using (var ctx = new dbContext())
            {               
                Setting CurrentUserSettings = ctx.Settings.SingleOrDefault(x => x.Id == user.Id);
                notifications.SwitchUpdateEveryMinNotification = CurrentUserSettings.isUpdateEveryOn;
                notifications.IsUpdateEveryMinutesNotification = CurrentUserSettings.UpdateEveryMin.ToString();
                notifications.SoundWhenActionWasBoughtNotification = CurrentUserSettings.SoundWhenActionWasBought;
                notifications.SoundWhenActionWasSoldNotification = CurrentUserSettings.SoundWhenActionWasSold;
                notifications.SoundWhenEmailWasSendNotification = CurrentUserSettings.SoundWhenEmailWasSend;
                notifications.SoundWhenPercentageWasChangedNotification = CurrentUserSettings.SoundWhenPercentageWasChanged;
                notifications.NotificationAfterBought = CurrentUserSettings.NotificationAfterBought;
                notifications.NotificationAfterSold = CurrentUserSettings.NotificationAfterSold;
                notifications.NotificationAfterSendReports = CurrentUserSettings.NotificationAfterSendReport;
                notifications.NotificationAfterProvisionChanged = CurrentUserSettings.NotificationAfterProvisionChanged;
            }
        }

        public void UpdateEveryMin(bool isUpdateEveryOn, string updateEveryMin)
        {
            var user = CurrentLoggedUser.Instance.GetLoggedUser();
            using (var ctx = new dbContext())
            {
                User usrSettings = ctx.Users.FirstOrDefault(x => x.Id == user.Id);
                if (usrSettings.Settings == null)
                {
                    Setting settings = new Setting();
                    settings.isUpdateEveryOn = isUpdateEveryOn;
                    settings.UpdateEveryMin = Convert.ToInt32(updateEveryMin);
                    usrSettings.Settings = settings;
                    ctx.Entry(usrSettings.Settings).State = EntityState.Added;
                    ctx.SaveChanges();
                }
                else
                {
                    usrSettings.Settings.isUpdateEveryOn = isUpdateEveryOn;
                    usrSettings.Settings.UpdateEveryMin = Convert.ToInt32(updateEveryMin);
                    ctx.Entry(usrSettings.Settings).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
        }

        public void ToggleUpdate(bool isChecked, string propertyName)
        {
            var user = CurrentLoggedUser.Instance.GetLoggedUser();          
            using (var ctx=new dbContext())
            {
                User usrSettings = ctx.Users.FirstOrDefault(x => x.Id == user.Id);
                if (usrSettings.Settings == null)
                {
                    Setting settings = new Setting();
                    Type type = settings.GetType();
                    PropertyInfo prop = type.GetProperty(propertyName);
                    prop.SetValue(settings, isChecked, null);

                    usrSettings.Settings = settings;
                    ctx.Entry(usrSettings.Settings).State = EntityState.Added;
                    ctx.SaveChanges();
                }
                else
                {
                    Type type = usrSettings.Settings.GetType();
                    PropertyInfo prop = type.GetProperty(propertyName);
                    prop.SetValue(usrSettings.Settings,isChecked,null);
                    ctx.Entry(usrSettings.Settings).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
        }
    }
}
