using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Counter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewCustomGamePage : ContentPage
    {
        public NewCustomGamePage()
        {
            InitializeComponent();
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Success", "Game saved", "Done");
            await Navigation.PopModalAsync();
        }
        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}