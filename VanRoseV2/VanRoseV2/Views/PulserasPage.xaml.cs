using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VanRoseV2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PulserasPage : ContentPage
	{
        private int currentIndexCarousel1 = 0;
        private int currentIndexCarousel2 = 0;
        private readonly int totalItemsCarousel1;
        private readonly int totalItemsCarousel2;
        public PulserasPage ()
		{
			InitializeComponent ();
            totalItemsCarousel1 = Carousel1.ItemsSource.Cast<object>().Count();
            totalItemsCarousel2 = Carousel2.ItemsSource.Cast<object>().Count();
            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
                currentIndexCarousel1 = (currentIndexCarousel1 + 1) % totalItemsCarousel1;
                Carousel1.Position = currentIndexCarousel1;
                currentIndexCarousel2 = (currentIndexCarousel2 + 1) % totalItemsCarousel2;
                Carousel2.Position = currentIndexCarousel2;
                return true;
            });
        }
	}
}