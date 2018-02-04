using System;
using System.Collections.Generic;
using OnlineDrive.CustomControls;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;
using XLabs.Forms.Controls;
namespace OnlineDrive.Views
{
    public partial class AddAccount : ContentPage
    {
        public List<MyRadioButton> radioButtons;
        public AddAccount()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            radioButtons = new List<MyRadioButton>()
                {
                radio1,
                radio2,
                radio3,
                radio4,
                };

        }
        public void radioclicked(object sender, System.EventArgs e)
        {

            var radiobtn = (Grid)sender;
            var isselectedvalue = radiobtn.GetType().GetProperties()[0];

            foreach (MyRadioButton rbl in radioButtons)
            {

                if (rbl == radiobtn)
                {
                    rbl.isselected = 1;
                    rbl.IsVisible = false;

                }
                else
                {
                    rbl.isselected = 2;
                    rbl.IsVisible = true;
                }
                //if (rbl.isselected == 1)
                //{
                //    rbl.IsVisible = true;
                //}
                //else if (rbl.isselected == 2)
                //{
                //    rbl.IsVisible = false;
                //}
            }


        }



        public void Addclicked(object sender, System.EventArgs e)
        {

            var newpage = new SignUpAccount();
            Navigation.PushAsync(newpage);
        }
        public void Skipclicked(object sender, System.EventArgs e)
        {
            var newpage = new DashBoard();
            Navigation.PushAsync(newpage);
        }
    }
}
