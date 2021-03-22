using PPE42021.VuesModeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PPE42021.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VueTestEntry : ContentPage
    {
        VueModeleTestEntry viewModel;
        public VueTestEntry()
        {
            InitializeComponent();
            BindingContext = viewModel = new VueModeleTestEntry();

        }

        private void EnvoyerTexte(object sender, EventArgs e)
        {
            viewModel.TransfertCommand.Execute(null);

            //TextRecu.Text ="le texte saisi est : " + TextSaisi.Text;
        }
    }
}