using System;
using System.Threading.Tasks;
using WSTowerGrupo2.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowerGrupo2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CadastroView();
        }

        protected override void OnStart()
        {
            //Task.Delay(3000);
            //InitializeComponent();
            //MainPage = new SplashView();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
