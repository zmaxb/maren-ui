# 🛠️ Forge UI

![.NET](https://img.shields.io/badge/.NET-10.0-blue?logo=dotnet&logoColor=white)
![Blazor](https://img.shields.io/badge/Blazor-Web%20App-purple?logo=blazor)
![MudBlazor](https://img.shields.io/badge/UI-MudBlazor-594AE2)

---

A modern ASP.NET Core application template built with Blazor and MudBlazor.

> [!IMPORTANT]
> Forge UI is currently under active development as a reusable application template.
>
> Some features may be incomplete or subject to change.

<p align="center">
  <a href="docs/images/forge-ui-dark.png">
    <img
      src="docs/images/forge-ui-dark.png"
      alt="Forge UI dark theme"
      width="49%">
  </a>

  <a href="docs/images/forge-ui-light.png">
    <img
      src="docs/images/forge-ui-light.png"
      alt="Forge UI light theme"
      width="49%">
  </a>
</p>

---

## Settings

Forge UI includes built-in management of global application settings and is being extended with support for user-specific settings.

<p align="center">
  <a href="docs/images/application-settings.png">
    <img
      src="docs/images/application-settings.png"
      alt="Forge UI settings management"
      width="100%">
  </a>
</p>

User settings storage is currently under development.

---

## Authentication

The template includes ASP.NET Core Identity with styled authentication and account management pages.

<p align="center">
  <a href="docs/images/forge-ui-login.png">
    <img
      src="docs/images/forge-ui-login.png"
      alt="Forge UI login page"
      width="49%">
  </a>

  <a href="docs/images/forge-ui-account.png">
    <img
      src="docs/images/forge-ui-account.png"
      alt="Forge UI account management page"
      width="49%">
  </a>
</p>

---

## Technology stack

- .NET
- ASP.NET Core
- Blazor
- MudBlazor
- ASP.NET Core Identity
- Entity Framework Core
- SQLite

---

## Getting started

Create a new repository from Forge UI using the **Use this template** button.

Alternatively, clone Forge UI directly:

```bash
git clone https://github.com/zmaxb/forge-ui.git
cd forge-ui
```

Restore dependencies:

```bash
dotnet restore
```

Apply database migrations:

```bash
dotnet ef database update
```

Run the application:

```bash
dotnet run
```

Open the application in your browser and select **Create a new account**.