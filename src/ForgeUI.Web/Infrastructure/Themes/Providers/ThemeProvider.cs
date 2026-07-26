using ForgeUI.Application.Settings;
using ForgeUI.Web.Infrastructure.Themes.Definitions;

namespace ForgeUI.Web.Infrastructure.Themes.Providers;

public class ThemeProvider
{
    public static AppThemeDefinition GetTheme(
        AppTheme theme)
    {
        return theme switch
        {
            AppTheme.Asphalt => AsphaltTheme.Create(),
            AppTheme.Slate => SlateTheme.Create(),

            _ => AsphaltTheme.Create()
        };
    }
}