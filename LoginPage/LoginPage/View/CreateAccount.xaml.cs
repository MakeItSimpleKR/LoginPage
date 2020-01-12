using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginPage.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginPage.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateAccount : ContentPage
    {
        public CreateAccount()
        {
            InitializeComponent();
            BindingContext = new CreateAccountViewModel();
        }
    }
}