using Xamarin.Forms;
using applanches.Models;
using System.Collections.Generic;

namespace applanches
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            listLanches.ItemsSource = new List<Lanche>
            {
                new Lanche { Nome = "Cheese Burger", Descricao = "", Status = "Ativo", Preco = 12.90M,
                    ImagemUrl = "cheeseburger.png" },
                new Lanche { Nome = "Big Mac", Descricao = "", Status = "Ativo", Preco = 14.50M,
                    ImagemUrl = "bigmac.png" },
                new Lanche { Nome = "Big Four", Descricao = "", Status = "Ativo", Preco = 16.50M,
                    ImagemUrl = "BigFour.png" },
                new Lanche { Nome = "Big Tasty", Descricao = "", Status = "Ativo", Preco = 15.50M,
                    ImagemUrl = "bigtasty.png" },
                new Lanche { Nome = "Cheddar", Descricao = "", Status = "Ativo", Preco = 12.50M,
                    ImagemUrl = "cheddar.png" },
                new Lanche { Nome = "Crispy", Descricao = "", Status = "Ativo", Preco = 10.50M,
                    ImagemUrl = "crispy.png" },
                new Lanche { Nome = "Crispy Ligth", Descricao = "", Status = "Ativo", Preco = 10.00M,
                    ImagemUrl = "crispylight.png" },
                new Lanche { Nome = "Quarteirao", Descricao = "", Status = "Ativo", Preco = 10.00M,
                    ImagemUrl = "quarteirao.png" },
                new Lanche { Nome = "Hamburguer", Descricao = "", Status = "Ativo", Preco = 11.00M,
                    ImagemUrl = "hamburguer.png" },
                new Lanche { Nome = "Triplo Cheeseburger", Descricao = "", Status = "Ativo", Preco = 11.00M,
                    ImagemUrl = "triplocheeseburger.png" }

            };
        }

          
        private async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
                var lanche = e.SelectedItem as Lanche;

                if (lanche == null)
                    return;

                await this.Navigation.PushAsync(new LancheDetailsPage(lanche));
            
        }
    }
}
