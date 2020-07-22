using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowerGrupo2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }
        

            private void loginButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Menu());

        }
        private void cadastroButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroView());
        }
    }
}