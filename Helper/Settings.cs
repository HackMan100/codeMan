using System;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using Xamarin.Forms;

namespace OnlineDrive.Helper
{
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string emailkey = "email";
        private const string passwordkey = "password";
        private static readonly string SettingsDefault = string.Empty;

        #endregion


        public static string Email
        {
            get
            {
                return AppSettings.GetValueOrDefault(emailkey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(emailkey, value);
            }
        }
        public static string Password
        {
            get
            {
                return AppSettings.GetValueOrDefault(passwordkey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(passwordkey, value);
            }
        }


    }
}

