using System;
using System.Collections.Generic;
using System.Text;

namespace PPE42021.Modeles
{
    class TypeCuisine
    {
        #region Attributs
        public static List<TypeCuisine> CollClasse = new List<TypeCuisine>();

        private int _id;
        private string _libelle;
        private string _image;
        private List<Restaurant> _lesRestaurants;

        #endregion
        #region Constructeurs
        public TypeCuisine(int id, string libelle, string image)
        {

            _id = id;
            _libelle = libelle;
            _lesRestaurants = new List<Restaurant>();
            TypeCuisine tc = TypeCuisine.CollClasse.Find(x => (x.Id == id));
            if (tc == null) TypeCuisine.CollClasse.Add(this);
            _image = image;
        }
        #endregion
        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }
        public List<Restaurant> LesRestaurants { get => _lesRestaurants; set => _lesRestaurants = value; }
        public string Image { get => _image; set => _image = value; }

        #endregion
        #region Methodes
        #endregion
    }
}
