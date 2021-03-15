using System;
using System.Collections.Generic;
using System.Text;

namespace PPE42021.Modeles
{
    class Restaurant
    {
        #region Attributs
        public static List<Restaurant> CollClasse = new List<Restaurant>();
        private int _id;
        private string _nom;
        private string _adresse;
        private string _codePostal;
        private string _ville;
        private string _telephone;
        private string _mail;
        private string _image;
        private List<TypeCuisine> _lesTypesCuisines;
        private List<Plat> _lesPlats;

        #endregion
        #region Constructeurs
        public Restaurant(int id, string nom, string adresse, string codePostal, string ville, string telephone, string mail, string image, List<TypeCuisine> lesTypesCuisines, List<Plat> lesPlats)
        {
            _id = id;
            _nom = nom;
            _adresse = adresse;
            _codePostal = codePostal;
            _ville = ville;
            _telephone = telephone;
            _mail = mail;

            _lesTypesCuisines = lesTypesCuisines;
            _lesPlats = lesPlats;
            this.SetListeTypeCuisine();
            this.SetListePlat();
            Restaurant tc = Restaurant.CollClasse.Find(x => (x.Id == id));
            if (tc == null) Restaurant.CollClasse.Add(this);
            _image = image;
        }

        #endregion
        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public string CodePostal { get => _codePostal; set => _codePostal = value; }
        public string Ville { get => _ville; set => _ville = value; }
        public string Telephone { get => _telephone; set => _telephone = value; }
        public string Mail { get => _mail; set => _mail = value; }
        public List<TypeCuisine> LesTypesCuisines { get => _lesTypesCuisines; set => _lesTypesCuisines = value; }
        public List<Plat> LesPlats { get => _lesPlats; set => _lesPlats = value; }
        public string Image { get => _image; set => _image = value; }

        #endregion
        #region Methodes
        private void SetListeTypeCuisine()
        {
            foreach( TypeCuisine unTypeCuisine in this.LesTypesCuisines)
            {
                unTypeCuisine.LesRestaurants.Add(this);
            }
        }

        private void SetListePlat()
        {
            foreach (Plat unPlat in this._lesPlats)
            {
                unPlat.LeRestaurant = this;
            }
        }
        #endregion
    }
}
