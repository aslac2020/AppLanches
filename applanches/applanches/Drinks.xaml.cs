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
        private string _acrescimos;
        public Drinks(Lanche lanche, string acrescimo)
        {
            InitializeComponent();
            _lanche = lanche;
            _acrescimos = acrescimo;
            LoadPage();
        }

        private void LoadPage()
        {
            lblPriceCoca.Text = _lanche.TextoCocaCola;
            lblPriceUva.Text = _lanche.TextoUva;
            lblPriceGoiaba.Text = _lanche.TextoGoiaba;
            lblPriceMaracuja.Text = _lanche.TextoMaracuja;

        }

        private async void btnProximo_Clicked(object sender, EventArgs e)
        {
            if (_lanche == null)
                return;

            await this.Navigation.PushAsync(new LanchePedidoPage(_lanche));
        }
    }
}