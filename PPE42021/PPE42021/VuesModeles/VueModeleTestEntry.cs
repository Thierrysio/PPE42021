using PPE42021.Services;
using PPE42021.Vues;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PPE42021.VuesModeles
{
    class VueModeleTestEntry : BaseVueModele
    {
        #region Attributs
        private readonly Api _apiServices = new Api();

        private string _texteSaisi;
        private string _texteRecu;




        #endregion
        #region Constructeurs
        public VueModeleTestEntry()
        {
            /// 
            // 2 eme etape instancier l'objet commande
            ///

            InterrogerCommand = new Command(ActionInterrogerCommand);
            ChangerPageCommand = new Command(ActionChangerPageCommand);

            TransfertCommand = new Command(ActionTransfertCommand);

        }
        #endregion
        #region Getters Setters
        /// <summary>
        /// Premiere etape de la gestion des commandes
        /// </summary>
        public ICommand TransfertCommand { get; }
        public ICommand InterrogerCommand { get; }
        public ICommand ChangerPageCommand { get; }

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
        public void ActionInterrogerCommand()
        {
            Task.Run(async () =>
            {
                bool x = await _apiServices.GetCategorie(TexteSaisi);
            });
        }
        public void ActionChangerPageCommand()
        {
            Application.Current.MainPage = new NavigationPage(new CategorieVue());

        }

        #endregion


    }
}
