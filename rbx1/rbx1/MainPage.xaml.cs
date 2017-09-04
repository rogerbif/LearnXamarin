using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace rbx1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            InitializeComponent();
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var product = e.Item as Product;
            var vm = BindingContext as MainViewModel;
            vm?.ShowOrHidePoducts(product);
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
