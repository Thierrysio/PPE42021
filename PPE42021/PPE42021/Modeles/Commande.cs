using System;
using System.Collections.Generic;
using System.Text;

namespace PPE42021.Modeles
{
    class Commande
    {
        #region Attributs
        public static List<Commande> CollClasse = new List<Commande>();

        private int _id;
        private DateTime _dateCommande;
        private bool _emporter;
        private List<Plat> _lesPlats;
        private Utilisateur _lutilisateur;

        #endregion
        #region Constructeurs
        public Commande(int id, DateTime dateCommande, bool emporter, List<Plat> lesPlats, int lutilisateur)
        {
            this._id = id;
            this._dateCommande = dateCommande;
            this._emporter = emporter;
            this._lesPlats = lesPlats;
            this._lutilisateur  = null;
            Commande tc = Commande.CollClasse.Find(x => (x.Id == id));
            if (tc == null) Commande.CollClasse.Add(this);
        }

        #endregion
        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public DateTime DateCommande { get => _dateCommande; set => _dateCommande = value; }
        public bool Emporter { get => _emporter; set => _emporter = value; }
        public List<Plat> LesPlats { get => _lesPlats; set => _lesPlats = value; }
        public Utilisateur Lutilisateur { get => _lutilisateur; set => _lutilisateur = value; }

        #endregion
        #region Methodes
        #endregion
    }
}
