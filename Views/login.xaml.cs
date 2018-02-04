using System;
using System.Collections.Generic;
using OnlineDrive.Modal;
using Xamarin.Forms;

namespace OnlineDrive.Views
{
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var users = new User
            {
                Username = user.Text,
                Password = pass.Text
            };

            var isValid = AreCredentialsCorrect(users);
            if (isValid)
            {
                App.IsUserLoggedIn = true;
                OnlineDrive.Helper.Settings.Email = user.Text;
                OnlineDrive.Helper.Settings.Password = pass.Text;
                var newpage = new DashBoard();
                //   await Navigation.PushModalAsync(newpage);
                Navigation.InsertPageBefore(new DashBoard(), this);
                await Navigation.PopAsync();
                // await Navigation.PopAsync();
            }
            else
            {
                //  messageLabel.Text = "Login failed";
                pass.Text = string.Empty;
            }

        }
        bool AreCredentialsCorrect(User users)
        {
            return users.Username == "Abhi" && users.Password == "Yes";
        }
    }
}
