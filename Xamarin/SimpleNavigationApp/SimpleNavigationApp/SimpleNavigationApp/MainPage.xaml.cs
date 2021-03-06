using SimpleNavigationApp.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleNavigationApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAboutUs_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutUsPage());
        }

        private void btnContactUs_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactPage(), animated: true);
        }
    }
}
