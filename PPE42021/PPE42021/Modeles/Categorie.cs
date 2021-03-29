using System;
using System.Collections.Generic;
using System.Text;

namespace PPE42021.Modeles
{
   public class Categorie
    {
        #region Attributs
        public static List<Categorie> CollClasse = new List<Categorie>();
        private int _id;
        private string _libelle;
        private string _image;
        #endregion
        #region Constructeurs
        public Categorie(int id, string libelle, string image)
        {
            // Savoir si id existe deja ?
            if(this.VerificationId(id))
                { 
            _id = id;
            _libelle = libelle;
            Categorie.CollClasse.Add(this);
                _image = image;
            }
        }
        #endregion
        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }
        public string Image { get => _image; set => _image = value; }

        #endregion
        #region Methodes
        private bool VerificationId(int param)
        {
            /* bool result = false;

             foreach(Categorie uneCategorie in Categorie.CollClasse)
             {
                 if (uneCategorie.Id == param) return result = true;

             }

             return result;*/

            return (Categorie.CollClasse.Find(x => (x.Id == param)) == null);
            
        }
        #endregion
    }
}
