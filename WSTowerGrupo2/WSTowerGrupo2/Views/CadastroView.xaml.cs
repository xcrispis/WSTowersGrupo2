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
    public partial class CadastroView : ContentPage
    {
        public CadastroView()
        {
            InitializeComponent();
        }

        private void cadastroButton__Clicked(object sender, EventArgs e)
        {
           
        }

        private void cadastroButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginView());
        }
    }
}