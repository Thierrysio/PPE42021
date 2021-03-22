using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PPE42021.VuesModeles
{
    class VueModeleTestEntry : BaseVueModele
    {
        #region Attributs
        private string _texteSaisi;
        private string _texteRecu;




        #endregion
        #region Constructeurs
        public VueModeleTestEntry()
        {
            /// 
            // 2 eme etape instancier l'objet commande
            ///


            TransfertCommand = new Command(ActionTransfertCommand);

        }
        #endregion
        #region Getters Setters
        /// <summary>
        /// Premiere etape de la gestion des commandes
        /// </summary>
        public ICommand TransfertCommand { get; }

        public string TexteSaisi
        {
            get { return _texteSaisi; }
            set { 
                SetProperty(ref _texteSaisi, value);
                //TexteRecu = _texteSaisi;
            }
        }
        public string TexteRecu
        {
            get { return _texteRecu; }
            set { 
                SetProperty(ref _texteRecu, value); 
            }
        }
        #endregion
        #region Methodes
        public void ActionTransfertCommand()
        {
            TexteRecu = "ca marche";
        }
        #endregion


    }
}
