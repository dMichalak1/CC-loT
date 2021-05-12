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
    public class MainPageViewModel
    {
        private readonly IServiceProvider provider;

        public MainPageViewModel(IServiceProvider provider)
        {
            this.provider = provider;
        }
        public ICommand NavigationToAboutUs
        {
            get => new Command(async () =>
            {
                await provider
                .GetService<INavigationService>()
                .PushAsync(provider.GetService<AboutUsPage>());
            });
        }
    }
}
