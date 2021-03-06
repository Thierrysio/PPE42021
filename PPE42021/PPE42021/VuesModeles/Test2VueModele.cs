using PPE42021.Modeles;
using PPE42021.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PPE42021.VuesModeles
{
    class Test2VueModele : BaseVueModele
    {
        private readonly Api _apiServices = new Api();
        #region Attributs
        private string _toto;
        private Utilisateur _unUtilisateur;

        private string _texteSaisi;
        private string _texteRecu;
        #endregion
        #region Constructeurs
        public Test2VueModele()
        {
            EnvoyerUtilisateurCommand = new Command(ActionEnvoyerUtilisateurCommand);
            UnUtilisateur = new Utilisateur(1, "Disney", "Riri", new List<Commande>());

            Toto = "mon premier programme en Xamarin a ete fait par " + UnUtilisateur.Nom;
        }
        #endregion
        #region Getters Setters
        public ICommand EnvoyerUtilisateurCommand { get; }
        public string TexteSaisi
        {
            get { return _texteSaisi; }
            set { SetProperty(ref _texteSaisi, value); }
        }
        public string TexteRecu
        {
            get { return _texteRecu; }
            set { SetProperty(ref _texteRecu, value); }
        }
        public string Toto
        {
            get { return _toto; }
            set { SetProperty(ref _toto, value); }
        }
        public Utilisateur UnUtilisateur
        {
            get { return _unUtilisateur; }
            set { SetProperty(ref _unUtilisateur, value); }
        }
        #endregion
        #region Methodes
        public void ActionEnvoyerUtilisateurCommand()
        {
            Task.Run(async () =>
            {
                bool x = await _apiServices.PostUtilisateur("sss","zzz");
            });
        }
        #endregion
    }
}
