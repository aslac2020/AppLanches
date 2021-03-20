using applanches.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace applanches
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LancheDetailsPage : ContentPage
    {
        Lanche _lanche;
        public LancheDetailsPage(Lanche lanche)
        {
            InitializeComponent();
            _lanche = lanche;
            this.BindingContext = _lanche;

        }

        async void btnProximo_Clicked(object sender, EventArgs e)
        {
            if (_lanche == null)
                return;

            await this.Navigation.PushAsync(new LanchePedidoPage(_lanche));
        }

        async void btnRefri_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Drinks(_lanche));
        }
    }
}