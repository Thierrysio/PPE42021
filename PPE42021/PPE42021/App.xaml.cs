using PPE42021.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PPE42021
{
    public partial class App : Application
    {
        private readonly Api _apiServices = new Api();

        public App()
        {
            InitializeComponent();
            Task.Run(async () =>
            {
                await _apiServices.GetAllRestaurants("api/restaurants");

            });
            MainPage = new MainPage();
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
