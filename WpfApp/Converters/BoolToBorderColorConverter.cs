using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace WpfApp.Converters;

public class BoolToBorderColorConverter : MarkupExtension, IValueConverter
{
    private static BoolToBorderColorConverter? _converter;
    
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if ((bool)value)
        {
            return "#636363";
        }

        return "#008d7a";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return _converter ??= new BoolToBorderColorConverter();
    }
}