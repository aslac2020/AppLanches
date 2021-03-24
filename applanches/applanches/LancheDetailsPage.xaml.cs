using applanches.Models;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace applanches
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LancheDetailsPage : ContentPage
    {
        Lanche _lanche;
        private string _acrescimos;
        public LancheDetailsPage(Lanche lanche)
        {
            InitializeComponent();
            _lanche = lanche;
            this.BindingContext = _lanche;

        }
        async void btnRefri_Clicked(object sender, EventArgs e)
        {
            if (swMaion.On && _lanche.TextoMaionese != null)
                _acrescimos = _lanche.TextoMaionese;
            await this.Navigation.PushAsync(new Drinks(_lanche, _acrescimos));
        }
    }
}