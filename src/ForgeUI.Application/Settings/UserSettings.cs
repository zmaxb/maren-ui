using Nava.Settings;

namespace ForgeUI.Application.Settings;

[SettingsKey("user-settings")]
public class UserSettings
{
    public AppTheme? Theme { get; set; }
}