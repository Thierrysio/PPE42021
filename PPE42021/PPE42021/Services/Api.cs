using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        public async Task GetAllUtilisateurs(string paramUrl)
        {
            try
            {


                var clientHttp = new HttpClient();
                var json = await clientHttp.GetStringAsync(Constantes.BaseApiAddress + paramUrl);
                JsonConvert.DeserializeObject<List<Utilisateur>>(json);

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
        public async Task<bool> GetCategorie(string param)
        {
            try
            {
                JObject oJsonObject = new JObject();
                oJsonObject.Add("Libelle", param);
                
                var client = new HttpClient();
                var Content = new StringContent(oJsonObject.ToString());
                var response = await client.PostAsync(Constantes.BaseApiAddress + "api/testCategorie", Content);
                var content = await response.Content.ReadAsStringAsync();
                if (content.Contains("ok"))
                {
                    
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> PostUtilisateur(string Param1,string Param2)
        {
            try
            {
                JObject oJsonObject = new JObject();
                oJsonObject.Add("Nom", Param1);
                oJsonObject.Add("Mdp", Param2);
                var client = new HttpClient();
                var Content = new StringContent(oJsonObject.ToString());

                var response = await client.PostAsync(Constantes.BaseApiAddress + "api/PostUtilisateur", Content);
                var content = await response.Content.ReadAsStringAsync();
                if (content.Contains("pasok"))
                {

                    return false;
                }
                else { return true; }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> PostCommande()
        {
            try
            {
                /*
                 * creation d'une collection de INT pour
                 * recuperer les ID
                 */
                List<int> Plats = new List<int>();

                JObject oJsonObject = new JObject();
                /*
                 * formattage de date pour lecture correcte sur le serveur d'API
                 */
                oJsonObject.Add("DateCommande", new DateTime(2021,04,26).ToString("yyyy'-'MM'-'dd"));
                oJsonObject.Add("Emporter", true);
                oJsonObject.Add("IdUtilisateur", 1);
                /* lorsqu' un objet contient une collectiond'objets d'une autre classe
                 * nous devons envoyer l'ID de chaque objet de cette collection donc 
                 * une petite moulinette pour recuperer l'ID de chaque objet
                 * ATTENTION j'ai pris le collclasse pour l'exemple - a vous de prendre la collection de plats de votre commande
                 */
                foreach(Plat unPlat in Plat.CollClasse)
                {
                    Plats.Add(unPlat.Id);
                }
                /*
                 * formattage de cette collection d'ID au format JSON
                 */
                oJsonObject.Add("Plats", JArray.FromObject(Plats));
                var client = new HttpClient();
                var Content = new StringContent(oJsonObject.ToString());

                var response = await client.PostAsync(Constantes.BaseApiAddress + "api/PostCommande", Content);
                var content = await response.Content.ReadAsStringAsync();
                if (content.Contains("pasok"))
                {

                    return false;
                }
                else { return true; }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}
