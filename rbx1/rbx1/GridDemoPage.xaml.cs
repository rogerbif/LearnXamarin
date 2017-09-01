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
            //await Navigation.PushModalAsync(new GridDemoPage());
            await Navigation.PopModalAsync();
        }
    }
}