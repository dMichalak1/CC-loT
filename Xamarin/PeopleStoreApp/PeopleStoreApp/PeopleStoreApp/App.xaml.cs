using System;
using PeopleStoreApp.DataContracts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PeopleStoreApp
{
    public partial class App : Application
    {
        private const string API_URL = "http://192.168.1.16:45024";
        public App()
        {
            InitializeComponent();

            var client = RestEase.RestClient.For<IPeopleClient>("http://192.168.1.4:6001/api");
         
            MainPage = new MainPage(client);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
