using System.ComponentModel;

namespace applanches.Models
{
    public class Lanche : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));

        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }

        private const decimal Ovo = 2.00M;
        private const decimal Bacon = 8.00M;
        private const decimal Maionese = 5.00M;
        private const decimal Catupiry = 8.00M;
        private const decimal Cheddar = 7.00M;
        private const decimal Uva = 4.50M;
        private const decimal Maracuja = 4.50M;
        private const decimal Goiaba = 4.50M;
        private const decimal CocaCola = 6.50M;

        public string TextoBacon
        {
            get { return string.Format("Bacon - R$ {0}", Bacon); }
        }

        public string TextoOvo
        {
            get { return string.Format("Ovo - R$ {0}", Ovo); }
        }
        public string TextoMaionese
        {
            get { return string.Format("Maionese - R$ {0}", Maionese); }
        }

        public string TextoCatupiry
        {
            get { return string.Format("Catupiry - R$ {0}", Catupiry); }
        }

        public string TextoCheddar
        {
            get { return string.Format("Cheddar - R$ {0}", Cheddar); }
        }

        public string TextoUva
        {
            get { return string.Format("Uva- R$ {0}", Uva); }
        }
        public string TextoMaracuja
        {
            get { return string.Format("Maracuja- R$ {0}", Maracuja); }
        }
        public string TextoGoiaba
        {
            get { return string.Format("Goiaba- R$ {0}", Goiaba); }
        }
        public string TextoCocaCola
        {
            get { return string.Format("CocaCola- R$ {0}", CocaCola); }
        }

        public string ValorTotal
        {
            get
            {
                return string.Format("Valor Total: R$ {0}", Preco + (TemOvo ? Ovo : 0) + (TemBacon ? Bacon : 0)
                    + (TemMaionese ? Maionese : 0) + (TemCheddar ? Cheddar : 0) + (TemCatupiry ? Catupiry : 0) +
                    (TemUva ? Uva : 0) + (TemMaracuja ? Maracuja : 0) + (TemGoiaba ? Goiaba : 0) + (TemCocaCola ? CocaCola : 0));
            }
        }

        private bool temOvo;
        public bool TemOvo
        {
            get { return temOvo; }
            set
            {
                temOvo = value;
                RaisePropertyChanged(nameof(ValorTotal));
            }
        }
        private bool temBacon;
        public bool TemBacon
        {
            get { return temBacon; }
            set
            {
                temBacon = value;
                RaisePropertyChanged(nameof(ValorTotal));
            }
        }
        private bool temMaionese;
        public bool TemMaionese
        {
            get { return temMaionese; }
            set
            {
                temMaionese = value;
                RaisePropertyChanged(nameof(ValorTotal));
            }
        }

        private bool temCheddar;
        public bool TemCheddar
        {
            get { return temCheddar; }
            set
            {
                temCheddar = value;
                RaisePropertyChanged(nameof(ValorTotal));
            }
        }

        private bool temCatupiry;
        public bool TemCatupiry
        {
            get { return temCatupiry; }
            set
            {
                temCatupiry = value;
                RaisePropertyChanged(nameof(ValorTotal));
            }
        }

        private bool temUva;
        public bool TemUva
        {
            get { return temUva; }
            set
            {
                temUva = value;
                RaisePropertyChanged(nameof(ValorTotal));
            }
        }

        private bool temGoiaba;
        public bool TemGoiaba
        {
            get { return temGoiaba; }
            set
            {
                temGoiaba = value;
                RaisePropertyChanged(nameof(ValorTotal));
            }
        }

        private bool temMaracuja;
        public bool TemMaracuja
        {
            get { return temMaracuja; }
            set
            {
                temMaracuja = value;
                RaisePropertyChanged(nameof(ValorTotal));
            }
        }

        private bool temCocaCola;
        public bool TemCocaCola
        {
            get { return temCocaCola; }
            set
            {
                temCocaCola = value;
                RaisePropertyChanged(nameof(ValorTotal));
            }
        }


    }
}
