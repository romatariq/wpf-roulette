using System.Globalization;
using Models.Enums;

namespace WpfApp.Converters;

public class EnumToBackgroundColorConverter : BaseConverter<EnumToBackgroundColorConverter>
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
            EColor.Red => "#bb1216",
            EColor.Black => "#0f1606",
            _ => defaultColor
        };
    }
}