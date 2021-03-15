using Newtonsoft.Json;
using PPE42021.Modeles;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PPE42021.Services
{
    public class Api
    {
        #region Restaurant
        public async Task GetAllRestaurants(string paramUrl)
        {
            try
            {


                var clientHttp = new HttpClient();
                var json = await clientHttp.GetStringAsync(Constantes.BaseApiAddress + paramUrl);
                JsonConvert.DeserializeObject<List<Restaurant>>(json);

            }
            catch (Exception ex)
            {
                
             }



        }
        public async Task GetAllPlats(string paramUrl)
        {
            try
            {


                var clientHttp = new HttpClient();
                var json = await clientHttp.GetStringAsync(Constantes.BaseApiAddress + paramUrl);
                JsonConvert.DeserializeObject<List<Plat>>(json);

            }
            catch (Exception ex)
            {

            }



        }
        public async Task GetAllMenus(string paramUrl)
        {
            try
            {


                var clientHttp = new HttpClient();
                var json = await clientHttp.GetStringAsync(Constantes.BaseApiAddress + paramUrl);
                JsonConvert.DeserializeObject<List<Menu>>(json);

            }
            catch (Exception ex)
            {

            }



        }
        #endregion
    }
}
