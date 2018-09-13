using System;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;

namespace Nutshell
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EventsPage());
        }
    }
}
