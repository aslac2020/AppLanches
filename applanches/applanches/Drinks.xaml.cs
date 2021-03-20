using applanches.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace applanches
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Drinks : ContentPage
    {
        Lanche _lanche;
        public Drinks(Lanche lanche)
        {
            InitializeComponent();
            _lanche = lanche;
            LoadPage();
        }

        private void LoadPage()
        {
            lblPriceCoca.Text = _lanche.TextoCocaCola;
            lblPriceUva.Text = _lanche.TextoUva;

        }
    }
}