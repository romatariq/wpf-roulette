using System.Globalization;

namespace WpfApp.Converters;

public class BoolToBackgroundColorConverter : BaseConverter<BoolToBackgroundColorConverter>
{
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if ((bool)value)
        {
            return "#bb1216";
        }

        return "#0f1606";
    }
}