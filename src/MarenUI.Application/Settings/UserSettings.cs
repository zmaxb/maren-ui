using Nava.Settings;

namespace MarenUI.Application.Settings;

[SettingsKey("user-settings")]
public class UserSettings
{
    public AppTheme? Theme { get; set; }
}