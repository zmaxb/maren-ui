using MudBlazor;

namespace ForgeUI.Web.Infrastructure.Themes;

public class MudThemeDefinition
{
    public required Palette Palette { get; set; }
    public bool IsDarkMode { get; set; }
}