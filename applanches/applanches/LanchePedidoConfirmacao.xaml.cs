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
    public partial class LanchePedidoConfirmacao : ContentPage
    {
        public LanchePedidoConfirmacao(Lanche lanche)
        {
            InitializeComponent();
            this.BindingContext = lanche;
        }
    }
}