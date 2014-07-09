using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;
using TesteEnum.ViewModel;

namespace TesteEnum.Conversores
{
    public class ConversorDeTiposDeEspessura : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value as IList<TipoDeEspessura> != null)
            {
                var listaConvertida= new List<string>();

                foreach (var tipoEspessura in (IList<TipoDeEspessura>)value)
                {
                    listaConvertida.Add(Util.Util.GetDescricaoDoEnum((tipoEspessura)));
                }

                return listaConvertida;
            }

            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
