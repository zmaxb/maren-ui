using Nava.Settings;

namespace ForgeUI.Application.Settings;

[SettingsKey("app-settings")]
public sealed class ApplicationSettings
{
    public AppTheme Theme { get; set; }
}