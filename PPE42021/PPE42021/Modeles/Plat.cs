using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PPE42021.Modeles
{
    class Plat
    {
        #region Attributs
        public static List<Plat> CollClasse = new List<Plat>();
        private int _id;
        private string _libelle;
        private double _prix;
        private string _image;
        private Restaurant _leRestaurant;
        private Categorie _laCategorie;

        #endregion
        #region Constructeurs
        public Plat(int id, string libelle, double prix, string image, object leRestaurant, Categorie laCategorie)
        {
            _id = id;
            _libelle = libelle;
            _prix = prix;
            string xc = leRestaurant.GetType().Name;
            if (xc == "Int64") _leRestaurant = null;
            if (xc == "JObject")
            {
                JObject o = (JObject)JToken.FromObject(leRestaurant);
                int xw = (int)o["id"];
                Restaurant tc3 = Restaurant.CollClasse.Find(x => (x.Id == xw));
                if (tc3 != null)
                { _leRestaurant = tc3; }
                else { _leRestaurant = null; }
            }



            _laCategorie = laCategorie;
            Plat tc = Plat.CollClasse.Find(x => (x.Id == id));
            if (tc == null) Plat.CollClasse.Add(this);
            _image = image;
        }

        #endregion
        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }
        public double Prix { get => _prix; set => _prix = value; }
        public Restaurant LeRestaurant { get => _leRestaurant; set => _leRestaurant = value; }
        public Categorie LaCategorie { get => _laCategorie; set => _laCategorie = value; }
        public string Image { get => _image; set => _image = value; }

        #endregion
        #region Methodes
        #endregion

    }
}
