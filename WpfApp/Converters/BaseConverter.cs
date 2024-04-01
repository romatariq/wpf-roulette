using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace WpfApp.Converters;

public abstract class BaseConverter<T> : MarkupExtension, IValueConverter
    where T : class, new()
{
    private static T? _converter;

    public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
    
    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return _converter ??= new T();
    }
}