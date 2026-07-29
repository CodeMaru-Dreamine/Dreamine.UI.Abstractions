# Dreamine.UI.Abstractions

![CI](https://github.com/CodeMaru-Dreamine/Dreamine.UI.Abstractions/actions/workflows/ci.yml/badge.svg?branch=main)
![Quality Gate](https://sonarcloud.io/api/project_badges/measure?project=CodeMaru-Dreamine_Dreamine.UI.Abstractions&metric=alert_status)
![security](https://sonarcloud.io/api/project_badges/measure?project=CodeMaru-Dreamine_Dreamine.UI.Abstractions&metric=security_rating)
![coverage](https://sonarcloud.io/api/project_badges/measure?project=CodeMaru-Dreamine_Dreamine.UI.Abstractions&metric=coverage)

![license](https://img.shields.io/badge/license-MIT-blue)
![.NET](https://img.shields.io/badge/.NET-8-blueviolet)
![WPF](https://img.shields.io/badge/WPF-contracts-blue)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2022%20%7C%202026-purple)

![nuget](https://img.shields.io/nuget/v/Dreamine.UI.Abstractions?label=nuget)
![downloads](https://img.shields.io/nuget/dt/Dreamine.UI.Abstractions?label=downloads)
[![Docs](https://img.shields.io/badge/%F0%9F%93%98%20Docs-dreamine.kr-blue)](https://dreamine.kr/libraries?lang=en)
[![Guide](https://img.shields.io/badge/%F0%9F%93%98%20Guide-dreamine.kr-blue)](https://dreamine.kr/guide?lang=en)
[![Playground](https://img.shields.io/badge/%F0%9F%A7%AA%20Playground-dreamine.kr-blueviolet)](https://dreamine.kr/playground?lang=en)
[![Book](https://img.shields.io/badge/%F0%9F%93%96%20Book-Practical%20MVVM%20Architecture-black)](https://bookk.co.kr/bookStore/69c0f1b41461ec1ae849a0f6)

`Dreamine.UI.Abstractions` defines the shared WPF-facing UI contracts used by Dreamine popup and virtual keyboard packages.

[한국어 문서](./README_KO.md)

## Package Role

This package keeps UI implementation packages decoupled from application code. Applications can depend on a stable contract assembly, while concrete WPF packages provide the actual windows, controls, resources, and behavior.

```text
Application Code
       ↓
Dreamine.UI.Abstractions
       ↓
Dreamine.UI.Wpf.* implementations
```

## Key Features

- Popup service contract for blink popup windows.
- Popup option model with WPF owner, size, color, and content boundary types.
- Virtual keyboard layout, input mode, language, and Enter-key result contracts.
- Small contract surface designed for implementation packages and app-level dependency inversion.

## Requirements

- Target Framework: `net8.0-windows`
- WPF enabled (`UseWPF=true`)
- No external NuGet package dependencies

## Installation

```bash
dotnet add package Dreamine.UI.Abstractions
```

```xml
<PackageReference Include="Dreamine.UI.Abstractions" Version="1.0.1" />
```

## Project Structure

```text
Dreamine.UI.Abstractions
├── Popup/
│   ├── BlinkPopupOptions.cs
│   └── IPopupService.cs
└── VirtualKeyboard/
    ├── ActionResult.cs
    ├── EnterActionResult.cs
    ├── IEnterActionProvider.cs
    ├── KeyboardInputMode.cs
    ├── KeyData.cs
    ├── LanguageCode.cs
    ├── SpecialButtonName.cs
    └── VkLayout.cs
```

## Usage

### Popup service

```csharp
IPopupService popupService = DMContainer.Resolve<IPopupService>();

await popupService.ShowBlinkAsync(owner, new BlinkPopupOptions
{
    Title = "Warning",
    Message = "Check equipment status",
    OkText = "OK",
    UseBlink = true,
    BlinkIntervalMs = 400,
    Color1 = Colors.Red,
    Color2 = Colors.DarkRed
});
```

### Virtual keyboard result

```csharp
IEnterActionProvider provider = ...;
EnterActionResult result = provider.Execute(input);

if (result.IsAccepted())
{
    result.Show(targetTextBox);
}
```

## Design Notes

This package intentionally contains WPF boundary types such as `Window`, `Size`, `Color`, `TextBox`, and `Brushes` because the contracts describe WPF UI behavior. It does not contain concrete windows, XAML resources, visual templates, or runtime UI implementations.

## License

MIT License
