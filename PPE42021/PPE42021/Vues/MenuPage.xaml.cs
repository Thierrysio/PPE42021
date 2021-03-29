using PPE42021.Modeles;
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
    public partial class MenuPage : ContentPage
    {
        MenuPageVueModele viewModel;
        public MenuPage(Restaurant param)
        {
            InitializeComponent();
            BindingContext = viewModel = new MenuPageVueModele(param);
        }
    }
}