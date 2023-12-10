using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VanRoseV2.Views;

namespace VanRoseV2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}
        private async void Servicios_Clicked(object sender, EventArgs e)
        {
            var currentPage = Application.Current.MainPage;
            var newPage = new ServicePage();
            await currentPage.Navigation.PushAsync(newPage);
        }

        private async void Coleccion_Clicked(object sender, EventArgs e)
        {
            var currentPage = Application.Current.MainPage;
            var newPage = new CollectionPage();
            await currentPage.Navigation.PushAsync(newPage);
        }

        private async void SobreMi_Clicked(object sender, EventArgs e)
        {
            var currentPage = Application.Current.MainPage;
            var newPage = new AboutmePage();
            await currentPage.Navigation.PushAsync(newPage);
        }

        private async void Contacto_Clicked(object sender, EventArgs e)
        {
            var currentPage = Application.Current.MainPage;
            var newPage = new ContactPage();
            await currentPage.Navigation.PushAsync(newPage);
        }
    }
}