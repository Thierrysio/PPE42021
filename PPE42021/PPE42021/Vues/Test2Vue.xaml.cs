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
    public partial class Test2Vue : ContentPage
    {
        Test2VueModele vueModele;
        public Test2Vue()
        {
            InitializeComponent();
            BindingContext = vueModele = new Test2VueModele();
        }
    }
}