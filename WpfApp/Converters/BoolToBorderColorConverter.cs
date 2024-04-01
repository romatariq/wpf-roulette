using System.Globalization;

namespace WpfApp.Converters;

public class BoolToBorderColorConverter : BaseConverter<BoolToBorderColorConverter>
{
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if ((bool)value)
        {
            return "#636363";
        }

        return "#008d7a";
    }
}