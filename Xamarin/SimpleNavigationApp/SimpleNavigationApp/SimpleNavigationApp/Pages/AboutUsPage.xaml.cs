using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleNavigationApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutUsPage : ContentPage
    {
        public AboutUsPage()
        {
            InitializeComponent();
        }

        private void btnContactUs_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactPage(), animated: true);
        }
    }
}