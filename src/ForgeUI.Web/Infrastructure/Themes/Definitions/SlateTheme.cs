using MudBlazor;

namespace ForgeUI.Web.Infrastructure.Themes.Definitions;

public static class SlateTheme
{
    public static AppThemeDefinition Create()
    {
        var mudTheme =
            GetMudThemeDefinition();

        var themeDefinition =
            new AppThemeDefinition(
                mudTheme);

        return themeDefinition;
    }

    private static MudThemeDefinition GetMudThemeDefinition()
    {
        return new MudThemeDefinition
        {
            IsDarkMode = false,

            Palette = new PaletteLight
            {
                Black = "#1C232B",

                Primary = "#5D8FCF",
                Secondary = "#687C95",

                Info = "#4E8FC5",
                Success = "#458B67",
                Warning = "#D1B06A",
                Error = "#C65D69",

                Dark = "#2A333D",

                Background = "#E9F0F6",
                BackgroundGray = "#E3EAF1",
                Surface = "#F8FAFC",

                DrawerBackground = "#2F353C",
                AppbarBackground = "#23282E",

                AppbarText = "#F4F7FA",

                TextPrimary = "#3D4855",
                TextSecondary = "#6C7B8D",
                TextDisabled = "#A3ADB8",

                DrawerText = "#F0F3F6",
                DrawerIcon = "#D6E2F0",

                ActionDefault = "#91A0B1",
                ActionDisabled = "#A1A9B2",
                ActionDisabledBackground = "#E2E6EA",

                LinesDefault = "#C9D1D9",
                LinesInputs = "#AAB5C0",

                TableLines = "#CCD4DC",
                TableStriped = "#EBEFF3",

                Divider = "#60708040",
                DividerLight = "#DCE2E8",

                Skeleton = "#DCE2E7",

                OverlayLight = "#15191E4D"
            }
        };
    }
}