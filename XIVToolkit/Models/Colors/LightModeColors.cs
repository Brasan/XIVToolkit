using Avalonia.Media;

namespace XIVToolkit.Models.Colors;

public class LightModeColors : IColors
{
    public Color Background { get; } = Avalonia.Media.Colors.White;
    public Color Foreground { get; } = new Color(255,255,255,255);
    public Color Accent { get; } = Avalonia.Media.Colors.CornflowerBlue;
}