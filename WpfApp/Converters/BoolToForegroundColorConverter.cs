using System.Globalization;

namespace WpfApp.Converters;

public class BoolToForegroundColorConverter : BaseConverter<BoolToForegroundColorConverter>
{
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if ((bool)value)
        {
            return "#060002";
        }

        return "#fcfeff";
    }
}