using ForgeUI.Application.Settings;

namespace ForgeUI.Application;

public interface IUserSettingsProvider
{
    event Action<UserSettings>? SettingsChanged;

    Task<UserSettings> GetAsync();

    Task UpdateAsync(UserSettings settings);
}