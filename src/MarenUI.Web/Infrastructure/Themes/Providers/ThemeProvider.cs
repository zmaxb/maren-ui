using MarenUI.Application.Settings;
using MarenUI.Web.Infrastructure.Themes.Definitions;

namespace MarenUI.Web.Infrastructure.Themes.Providers;

public class ThemeProvider
{
    public static AppThemeDefinition GetTheme(
        AppTheme theme)
    {
        return theme switch
        {
            AppTheme.Carbon => CarbonTheme.Create(),
            AppTheme.Slate => SlateTheme.Create(),

            _ => CarbonTheme.Create()
        };
    }
}