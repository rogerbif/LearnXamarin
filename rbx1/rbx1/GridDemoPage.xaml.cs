using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rbx1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridDemoPage : ContentPage
	{
		public GridDemoPage ()
		{
			InitializeComponent ();
		}

        async void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            /*await DisplayAlert("Clicou!",
                "O botão '" + button.Text + "' foi clicado",
                "Vai");*/

            switch (button.Text)
            {
                case "Page Grid":
                    await Navigation.PushModalAsync(new GridDemoPage());
                    break;
                case "Page2":
                    await DisplayAlert("Clicou!",
                    "O botão '" + button.Text + "' foi clicado",
                    "Vai");
                    break;
                case "Page3":
                    await DisplayAlert("Clicou!",
                    "O botão '" + button.Text + "' foi clicado",
                    "Vai");
                    break;
                case "MainPage":
                    await Navigation.PopModalAsync();
                    break;
                default:
                    await DisplayAlert("Clicou!",
                    "O botão '" + button.Text + "' foi clicado",
                    "Vai");
                    break;
            }
            //await Navigation.PopModalAsync();
        }
    }
}