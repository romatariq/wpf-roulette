using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace WpfApp.Converters;

public class BoolToBackgroundColorConverter : MarkupExtension, IValueConverter
{
    private static BoolToBackgroundColorConverter? _converter;
    
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if ((bool)value)
        {
            return "#bb1216";
        }

        return "#0f1606";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return _converter ??= new BoolToBackgroundColorConverter();
    }
}