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
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            Detail = new PrincipalView();
        
        }

        private void Sair_button_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PopAsync();
        }

        private void SobreNosBtn_Clicked(object sender, EventArgs e)
        {
            NavigationPage.SetHasNavigationBar(this, false);

            Detail = new AboutView();
           
        }

        private void BtnList_Clicked(object sender, EventArgs e)
        {
            NavigationPage.SetHasNavigationBar(this, false);

            Detail = new ListajogosView();

        }

        private void BtnListgrl_Clicked(object sender, EventArgs e)
        {
            NavigationPage.SetHasNavigationBar(this, false);

            Detail = new ListaGeralView();
          
        }
    }
}