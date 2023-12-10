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
	public partial class CollectionPage : ContentPage
	{
		public CollectionPage ()
		{
			InitializeComponent ();

            aretesClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(async () =>
                {
                    
                    var newPage = new AretesPage(); 
                    await Navigation.PushAsync(newPage);
                })
            });
            aretesImgClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(async () =>
                {

                    var newPage = new AretesPage();
                    await Navigation.PushAsync(newPage);
                })
            });
            pulserasImgClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(async () =>
                {

                    var newPage = new PulserasPage();
                    await Navigation.PushAsync(newPage);
                })
            });
            pulserasClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(async () =>
                {

                    var newPage = new PulserasPage();
                    await Navigation.PushAsync(newPage);
                })
            });
            collaresImgClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(async () =>
                {

                    var newPage = new CollaresPage();
                    await Navigation.PushAsync(newPage);
                })
            });
            collaresClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(async () =>
                {

                    var newPage = new CollaresPage();
                    await Navigation.PushAsync(newPage);
                })
            });
        }
	}
}