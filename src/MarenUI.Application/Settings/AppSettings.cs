using Nava.Settings;

namespace MarenUI.Application.Settings;

[SettingsKey("app-settings")]
public sealed class ApplicationSettings
{
    public AppTheme Theme { get; set; }
}