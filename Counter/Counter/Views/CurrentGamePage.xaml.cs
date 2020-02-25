using Counter.ViewModels;
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
    public partial class CurrentGamePage : ContentPage
    {
        CustomGameViewModel viewModel;
        public CurrentGamePage()
        {
            InitializeComponent();
        }
        public CurrentGamePage(CustomGameViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel = new CustomGameViewModel();
        }
    }
}