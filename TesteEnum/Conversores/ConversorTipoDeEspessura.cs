using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using TesteEnum.ViewModel;

namespace TesteEnum.Conversores
{
    public class ConversorTipoDeEspessura : IValueConverter
    {
        /// <summary>
        /// Converte TipoEspessura para sua respective descrição
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is TipoDeEspessura)
            {
                return Util.Util.GetDescricaoDoEnum((TipoDeEspessura) value);
            }
            return value.ToString();
        }

        /// <summary>
        /// Converte descrição em respectivo TipoEspessura
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value as string == null) return null;
            var descricao = value as string;

            IEnumerable<TipoDeEspessura> todosOsTiposDeEspessura = Enum.GetValues(typeof (TipoDeEspessura)).Cast<TipoDeEspessura>();

            var descricaoPorTipoDeEspessura = todosOsTiposDeEspessura.ToDictionary(tipoEspessura => Util.Util.GetDescricaoDoEnum(tipoEspessura));

            if (descricaoPorTipoDeEspessura.ContainsKey(descricao))
            {
                return descricaoPorTipoDeEspessura[descricao];
            }
            return null;
        }
    }
}