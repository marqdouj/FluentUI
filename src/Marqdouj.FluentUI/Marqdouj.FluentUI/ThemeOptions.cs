using Microsoft.FluentUI.AspNetCore.Components;
using Icons = Microsoft.FluentUI.AspNetCore.Components.Icons;

namespace Marqdouj.FluentUI
{
    public class ThemeOptions
    {
        public string? AriaLabel { get; set; }
        public OfficeColor? Color { get; set; }
        public Icon ColorIcon { get; set; } = new Icons.Filled.Size20.RectangleLandscape();
        public string? Height { get; set; } = "200px";
        public string? Label { get; set; }
        public DesignThemeModes Mode { get; set; }
        public string StorageName { get; set; } = "theme";
        public string? Width { get; set; } = "200px";
    }
}
