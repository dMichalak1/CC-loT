using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Microsoft.Extensions.DependencyInjection;
using SimpleNavigationApp.Services;
using SimpleNavigationApp.Pages;

namespace SimpleNavigationApp.ViewModels
{
   public  class AboutUsPageViewModel
    {
        private readonly IServiceProvider provider;

        public AboutUsPageViewModel(IServiceProvider provider)
        {
            this.provider = provider;
        }

        public ICommand NavigationToContact
        {
            get => new Command(async () =>
            {
                await provider.GetService<INavigationService>().PushAsync(provider.GetService<ContactPage>());
            });
        }


    }

}
