using PPE42021.Modeles;
using PPE42021.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PPE42021.VuesModeles
{
    class CategorieVueModele : BaseVueModele
    {
        #region Attributs
        private readonly Api _apiServices = new Api();

        private string _test;
        private Restaurant _leRestaurant;
        #endregion
        #region Constructeurs
        public CategorieVueModele()
        {
            GetListe();
            Test = "j'ai reussi";
            
        }
        #endregion
        #region Getters setters
        public string Test
        {
            get { return _test; }
            set { SetProperty(ref _test, value); }
        }
        public Restaurant LeRestaurant
        {
            get { return _leRestaurant; }
            set { SetProperty(ref _leRestaurant, value); }
        }

        #endregion
        #region Methodes
        public async Task GetListe()
        {

            await _apiServices.GetAllRestaurants("api/restaurants");
            //await _apiServices.GetAllPlats("api/plats");
            await _apiServices.GetAllMenus("api/menus");

            LeRestaurant = Restaurant.CollClasse[0];
        }
        #endregion
    }
}
