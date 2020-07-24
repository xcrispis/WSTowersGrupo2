using System;
using System.Collections.Generic;
using System.IO;
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

        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notesAppLogin.txt");
        public LoginView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }


       
        private async void User_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                var email = txtEmail.Text ?? "";

                if (!string.IsNullOrEmpty(email) && email.Length >= 4)
                {
                    var usuarios = await App.Database.GetUsuarioAsync();

                    var usuario = usuarios.Where(p => p.Email == email && p.Senha != "").FirstOrDefault();

                    if (usuario != null)
                    {
                        var result = await DisplayAlert("", "Existe uma senha salva para esse usuário, deseja usar esta senha?", "SIM", "NÃO");

                        if (result)
                        {
                            txtSenha.Text = usuario.Senha;
                            txtSenha.IsPassword = false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }


        private async void loginButton_Clicked(object sender, EventArgs e)
        {
            var email = txtEmail.Text ?? "";
            var senha = txtSenha.Text ?? "";
            var usuarios = await App.Database.GetUsuarioAsync();
            var usuario = usuarios.Where(p => p.Email == email && p.Senha = Senha).FirstOrDefault();
            App.Current.MainPage = new NavigationPage(new PrincipalView());
            if (usuario != null)
            {
                Navigation.PushAsync(new PrincipalView());
            }
           
        }
        private void cadastroButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroView());
        }
    }
}