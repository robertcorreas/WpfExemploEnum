using System.Collections.Generic;
using System.ComponentModel;
using GalaSoft.MvvmLight;

namespace TesteEnum.ViewModel
{
    public enum TipoDeEspessura
    {
        [Description("A")] EspessuraNivel1,
        [Description("B")] EspessuraNivel2,
        [Description("C")] EspessuraNivel3,
        [Description("D")] EspessuraNivel4,
        [Description("E")] EspessuraNivel5,
        [Description("F")] EspessuraNivel6
    }

    public class MainWindowViewModel : ViewModelBase
    {
        private TipoDeEspessura _tipoDeEspesssuraSelecionada;

        public IList<TipoDeEspessura> TiposDeEspessura { get; private set; }
        public TipoDeEspessura TipoDeEspesssuraSelecionada
        {
            get { return _tipoDeEspesssuraSelecionada; }
            set
            {
                _tipoDeEspesssuraSelecionada = value;
                RaisePropertyChanged(()=>TipoDeEspesssuraSelecionada);
            }
        }

        public MainWindowViewModel()
        {
            TiposDeEspessura = new List<TipoDeEspessura>
            {
                TipoDeEspessura.EspessuraNivel1,
                TipoDeEspessura.EspessuraNivel2,
                TipoDeEspessura.EspessuraNivel3,
                TipoDeEspessura.EspessuraNivel4,
                TipoDeEspessura.EspessuraNivel5,
                TipoDeEspessura.EspessuraNivel6,
            };
        }
    }
}