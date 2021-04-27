using PPE42021.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PPE42021.VuesModeles
{
    class PostCommandeVueModele : BaseVueModele
    {
        #region Attributs
        private readonly Api _apiServices = new Api();
        #endregion
        #region Constructeurs
        public PostCommandeVueModele()
        {
            this.GetListe();
        }
        #endregion
        #region Methodes
        private async Task GetListe()
        {
            await _apiServices.GetAllRestaurants("api/restaurants");
            await _apiServices.GetAllUtilisateurs("api/utilisateurs");
            await _apiServices.GetAllMenus("api/menus");
            await _apiServices.PostCommande();
        }
        #endregion
    }

}
