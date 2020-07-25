using System;
using System.IO;
using System.Threading.Tasks;
using WSTowerGrupo2.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowerGrupo2
{
    public partial class App : Application
    {
        static UsuarioRepository database;
        public static UsuarioRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new UsuarioRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "usuario.db3"));
                }

                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new CadastroView();
        }

        protected override void OnStart()
        {
            Task.Delay(3000);
            InitializeComponent();
            MainPage = new SplashView();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
