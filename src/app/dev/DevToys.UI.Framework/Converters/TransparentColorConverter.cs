using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;
using Windows.UI;

namespace DevToys.UI.Framework.Converters;

/// <summary>
/// Convert a <see cref="Color"/> to a <see cref="Color"/> with full transparency.
/// </summary>
public sealed class TransparentColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        var color = value as Color?;
        if (color == null)
        {
            return DependencyProperty.UnsetValue;
        }

        return Color.FromArgb(0, color.Value.R, color.Value.G, color.Value.B);
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
