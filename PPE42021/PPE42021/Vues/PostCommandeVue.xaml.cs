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
    public partial class PostCommandeVue : ContentPage
    {
        PostCommandeVueModele viewModel;

        public PostCommandeVue()
        {
            InitializeComponent();
            BindingContext = viewModel = new PostCommandeVueModele();

        }
    }
}