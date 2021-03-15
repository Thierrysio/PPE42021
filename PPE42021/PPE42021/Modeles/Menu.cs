using System;
using System.Collections.Generic;
using System.Text;

namespace PPE42021.Modeles
{
    class Menu
    {
        #region Attributs
        public static List<Menu> CollClasse = new List<Menu>();
        private int _id;
        private string _libelle;
        private string _image;
        private List<Plat> _lesPlats;
        #endregion
        #region Constructeurs
        public Menu(int id, string Libelle, string image, List<Plat> LesPlats)
        {
            _id = id;
            _libelle = Libelle;
            _lesPlats = LesPlats;
            Menu tc = Menu.CollClasse.Find(x => (x.Id == id));
            if (tc == null) Menu.CollClasse.Add(this);
            _image = image;
        }
        #endregion
        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }
        public List<Plat> LesPlats { get => _lesPlats; set => _lesPlats = value; }
        public string Image { get => _image; set => _image = value; }

        #endregion
        #region Methodes
        #endregion
    }
}
