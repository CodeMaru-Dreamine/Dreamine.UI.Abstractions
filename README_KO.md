# Dreamine.UI.Abstractions

![CI](https://github.com/CodeMaru-Dreamine/Dreamine.UI.Abstractions/actions/workflows/ci.yml/badge.svg?branch=main)
![품질 게이트](https://sonarcloud.io/api/project_badges/measure?project=CodeMaru-Dreamine_Dreamine.UI.Abstractions&metric=alert_status)
![보안](https://sonarcloud.io/api/project_badges/measure?project=CodeMaru-Dreamine_Dreamine.UI.Abstractions&metric=security_rating)
![커버리지](https://sonarcloud.io/api/project_badges/measure?project=CodeMaru-Dreamine_Dreamine.UI.Abstractions&metric=coverage)

![라이선스](https://img.shields.io/badge/license-MIT-blue)
![.NET](https://img.shields.io/badge/.NET-8-blueviolet)
![WPF](https://img.shields.io/badge/WPF-contracts-blue)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2022%20%7C%202026-purple)

![NuGet](https://img.shields.io/nuget/v/Dreamine.UI.Abstractions?label=nuget)
![다운로드](https://img.shields.io/nuget/dt/Dreamine.UI.Abstractions?label=downloads)
[![문서](https://img.shields.io/badge/%F0%9F%93%98%20%EB%AC%B8%EC%84%9C-dreamine.kr-blue)](https://dreamine.kr/libraries?lang=ko)
[![가이드](https://img.shields.io/badge/%F0%9F%93%98%20%EA%B0%80%EC%9D%B4%EB%93%9C-dreamine.kr-blue)](https://dreamine.kr/guide?lang=ko)
[![놀이터](https://img.shields.io/badge/%F0%9F%A7%AA%20%EB%86%80%EC%9D%B4%ED%84%B0-dreamine.kr-blueviolet)](https://dreamine.kr/playground?lang=ko)
[![책](https://img.shields.io/badge/%F0%9F%93%96%20%EC%B1%85-Practical%20MVVM%20Architecture-black)](https://bookk.co.kr/bookStore/69c0f1b41461ec1ae849a0f6)

`Dreamine.UI.Abstractions`는 Dreamine 팝업과 가상 키보드 패키지가 공유하는 WPF 기반 UI 계약을 정의합니다.

[English documentation](./README.md)

## 패키지 역할

이 패키지는 애플리케이션 코드와 실제 WPF UI 구현 패키지를 느슨하게 연결하기 위한 계약 계층입니다. 애플리케이션은 안정적인 인터페이스와 옵션 모델만 참조하고, 실제 창·컨트롤·리소스·동작은 WPF 구현 패키지가 담당합니다.

```text
애플리케이션 코드
       ↓
Dreamine.UI.Abstractions
       ↓
Dreamine.UI.Wpf.* 구현 패키지
```

## 주요 기능

- 깜빡임 팝업 창을 표시하기 위한 팝업 서비스 계약.
- WPF 소유 창, 크기, 색상, 콘텐츠 경계 타입을 포함한 팝업 옵션 모델.
- 가상 키보드 레이아웃, 입력 모드, 언어, Enter 키 처리 결과 계약.
- 구현 패키지와 애플리케이션 의존성 분리를 위한 작은 계약 표면.

## 요구 사항

- 대상 프레임워크: `net8.0-windows`
- WPF 활성화 (`UseWPF=true`)
- 외부 NuGet 패키지 의존성 없음

## 설치

```bash
dotnet add package Dreamine.UI.Abstractions
```

```xml
<PackageReference Include="Dreamine.UI.Abstractions" Version="1.0.1" />
```

## 프로젝트 구조

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

## 사용 예시

### 팝업 서비스

```csharp
IPopupService popupService = DMContainer.Resolve<IPopupService>();

await popupService.ShowBlinkAsync(owner, new BlinkPopupOptions
{
    Title = "경고",
    Message = "설비 상태를 확인하세요",
    OkText = "확인",
    UseBlink = true,
    BlinkIntervalMs = 400,
    Color1 = Colors.Red,
    Color2 = Colors.DarkRed
});
```

### 가상 키보드 결과

```csharp
IEnterActionProvider provider = ...;
EnterActionResult result = provider.Execute(input);

if (result.IsAccepted())
{
    result.Show(targetTextBox);
}
```

## 설계 노트

이 패키지에는 `Window`, `Size`, `Color`, `TextBox`, `Brushes` 같은 WPF 경계 타입이 포함됩니다. 계약 자체가 WPF UI 동작을 설명하기 때문입니다. 대신 실제 창, XAML 리소스, 시각 템플릿, 런타임 UI 구현은 포함하지 않습니다.

## 라이선스

MIT License
