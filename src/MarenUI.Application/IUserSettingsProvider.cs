using MarenUI.Application.Settings;

namespace MarenUI.Application;

public interface IUserSettingsProvider
{
    event Action<UserSettings>? SettingsChanged;

    Task<UserSettings> GetAsync();

    Task UpdateAsync(UserSettings settings);
}