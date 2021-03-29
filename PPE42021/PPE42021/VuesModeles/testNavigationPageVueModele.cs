using PPE42021.Modeles;
using PPE42021.Services;
using PPE42021.Vues;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PPE42021.VuesModeles
{
    class testNavigationPageVueModele : BaseVueModele
    {
        #region Attributs
        private readonly Api _apiServices = new Api();
        private ObservableCollection<Restaurant> _maListeRestaurant;
        private Restaurant _selectedRestaurant;

        #endregion
        #region Constructeurs
        public testNavigationPageVueModele()
        {
             this.GetListe();
        }
        #endregion
        #region Getters - Setters
        public ObservableCollection<Restaurant> MaListeRestaurant
        {
            get { return _maListeRestaurant; }
            set { SetProperty(ref _maListeRestaurant, value); }
        }
        public Restaurant SelectedRestaurant
        {
            get { return _selectedRestaurant; }
            set { 
                SetProperty(ref _selectedRestaurant, value);
                this.LancerPageMenu();
            }
        }
        #endregion
        #region Methodes
        public void LancerPageMenu()
        {
            Application.Current.MainPage = new NavigationPage(new MenuPage(_selectedRestaurant));

        }
        public async Task GetListe()
        {
            IsBusy = true;
            await _apiServices.GetAllRestaurants("api/restaurants");
            await _apiServices.GetAllUtilisateurs("api/utilisateurs");
            await _apiServices.GetAllMenus("api/menus");
            IsBusy = false;
            MaListeRestaurant = this.RemplirListeResto();
        }

        private ObservableCollection<Restaurant> RemplirListeResto()
        {
            ObservableCollection<Restaurant> resultat = new ObservableCollection<Restaurant>();

            foreach (Restaurant unRestaurant in Restaurant.CollClasse)
            {
                resultat.Add(unRestaurant);
            }

            return resultat;
        }
    }
    #endregion
}

