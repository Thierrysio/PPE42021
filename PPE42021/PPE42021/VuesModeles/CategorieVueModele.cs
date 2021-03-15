using PPE42021.Modeles;
using PPE42021.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace PPE42021.VuesModeles
{
    class CategorieVueModele : BaseVueModele
    {
        #region Attributs
        private readonly Api _apiServices = new Api();
        private string _libelle;
        private string _test;
        private Restaurant _leRestaurant;
        private ObservableCollection<Restaurant> _maListeRestaurant;
        private bool _isBusy;

        #endregion
        #region Constructeurs
        public CategorieVueModele()
        {
            GetListe();
            Test = "j'ai reussi";

        }
        #endregion
        #region Getters setters
        public string Libelle
        {
            get { return _libelle; }
            set { SetProperty(ref _libelle, value); }
        }

        public string Test
        {
            get { return _test; }
            set { SetProperty(ref _test, value); }
        }

        public bool IsBusy
        {
            get { return _isBusy; }
            set { SetProperty(ref _isBusy, value); }
        }
        public Restaurant LeRestaurant
        {
            get { return _leRestaurant; }
            set { SetProperty(ref _leRestaurant, value); }
        }

        public ObservableCollection<Restaurant> MaListeRestaurant
        {
            get { return _maListeRestaurant; }
            set { SetProperty(ref _maListeRestaurant, value); }
        }

        #endregion
        #region Methodes
        public async Task GetListe()
        {
            IsBusy = true;
            await _apiServices.GetAllRestaurants("api/restaurants");
            //await _apiServices.GetAllPlats("api/plats");
            await _apiServices.GetAllMenus("api/menus");
            IsBusy = false;
            LeRestaurant = Restaurant.CollClasse[0];
            Libelle = Restaurant.CollClasse[0].LesTypesCuisines[0].Libelle;
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
        #endregion
    }
}
