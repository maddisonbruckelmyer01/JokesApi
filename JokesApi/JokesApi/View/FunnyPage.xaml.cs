using JokesApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JokesApi.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FunnyPage : ContentPage
    {
        FunnyViewModel viewModel;
        public FunnyPage()
        {
            BindingContext = viewModel = new FunnyViewModel();
            InitializeComponent();
        }
    }
}