
using Android.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WSTowerGrupo2.Model;
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

        private bool verifyInputs()
        {
            if (!string.IsNullOrEmpty(txtNome.Text) && txtNome.Text.Trim().Length >= 3 &&
                !string.IsNullOrEmpty(txtEmail.Text) && txtEmail.Text.Trim().Length >= 3 &&
                !string.IsNullOrEmpty(txtSenha.Text) && txtSenha.Text.Trim().Length >= 3
             )

            {
                return true;
            }

            return false;
        }

        private bool verifyEmail()
        {
            string pattern =
            "[a-zA-Z{1}" +
            "[a-zA-Z0-9{3,}" +
            "[-_.]{0,1}" +
            "[a-zA-Z0-9]{4,}" +
            "[@]{1}" +
            "[a-zA-Z]{3,}" +
            "[.]{1}" +
            "[a-zA-Z]{2,}";

            if (string.IsNullOrEmpty(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, pattern))
            {
                return false;
            }

            return true;
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            cadastroButton.IsEnabled = verifyInputs() && verifyEmail();
            
        }

        private async void btnCadastrarClicked(object sender, EventArgs e)
        {

            try
            {
                //var gravasenha = salvasenha_toggle.istoggled;

                //if (gravasenha)
                //{
                //    if (string.isnullorempty(txtsenha.text))
                //    {
                //        await displayalert("atenção", "informe a senha", "ok");
                //        return;
                //    }
                //}

                if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    if (txtEmail.Text.Length >= 4)
                    {
                        await App.Database.SaveUsuarioAsync(new Usuario
                        {
                            Email = txtEmail.Text,
                            Senha = txtSenha.Text
                        });

                        txtEmail.Text = txtSenha.Text = txtNome.Text = string.Empty;

                        await DisplayAlert("SUCESSO", "Usuário cadastrado com sucesso.", "OK");
                    }
                    else
                    {
                        await DisplayAlert("ATENÇÃO", "O nome do usuáio deve possuir mais de 3 caracteres.", "OK");
                    }

                }
                else
                {
                    await DisplayAlert("ATENÇÃO", "Informe o nome do usuário.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERRO", "Ocorreu um erro desconhecido.", "OK");
            }

            //var fill = Service.ServiceWS.InsertUsuario(usuario);
        }


        }
}