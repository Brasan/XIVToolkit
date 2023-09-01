using Avalonia.Media;

namespace XIVToolkit.Models.Colors;

public interface IColors
{
    public Color Background { get; }
    public Color Foreground { get; }
    public Color Accent { get; }
}