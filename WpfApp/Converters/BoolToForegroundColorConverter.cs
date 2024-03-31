using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace WpfApp.Converters;

public class BoolToForegroundColorConverter : MarkupExtension, IValueConverter
{
    private static BoolToForegroundColorConverter? _converter;
    
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if ((bool)value)
        {
            return "#060002";
        }

        return "#fcfeff";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return _converter ??= new BoolToForegroundColorConverter();
    }
}