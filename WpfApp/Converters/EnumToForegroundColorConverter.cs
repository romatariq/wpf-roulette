using System.Globalization;
using Models.Enums;

namespace WpfApp.Converters;

public class EnumToForegroundColorConverter : BaseConverter<EnumToForegroundColorConverter>
{
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var defaultColor = string.Empty;
        if (!Enum.TryParse<EColor>(value?.ToString(), out var color))
        {
            return defaultColor;
        }
        
        return color switch
        {
            EColor.Red => "#060002",
            EColor.Black => "#fcfeff",
            _ => defaultColor
        };
    }
}