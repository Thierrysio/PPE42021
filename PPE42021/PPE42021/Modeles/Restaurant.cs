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


        #endregion
        #region Constructeurs
        public Restaurant(int id, string nom, string adresse, string codePostal, string ville, string telephone, string mail)
        {
            _id = id;
            _nom = nom;
            _adresse = adresse;
            _codePostal = codePostal;
            _ville = ville;
            _telephone = telephone;
            _mail = mail;
            Restaurant.CollClasse.Add(this);
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

        #endregion
        #region Methodes
        #endregion
    }
}
