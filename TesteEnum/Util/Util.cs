using System;
using System.ComponentModel;
using System.Reflection;

namespace TesteEnum.Util
{
    public static class Util
    {
        public static string PegarDescricaoDoEnum(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            return value.ToString();
        }
    }
}