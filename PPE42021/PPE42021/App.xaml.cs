using PPE42021.Services;
using PPE42021.Vues;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PPE42021
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            
            MainPage = new testNavigationPageVue();
        }

        

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
