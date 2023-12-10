using System;
using System.Collections.Generic;
using VanRoseV2.Views;
using Xamarin.Forms;

namespace VanRoseV2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AretesPage), typeof(AretesPage));
            Routing.RegisterRoute(nameof(CollaresPage), typeof(CollaresPage));
            Routing.RegisterRoute(nameof(PulserasPage), typeof(PulserasPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
