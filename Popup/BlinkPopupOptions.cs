using System.Windows;
using System.Windows.Media;

namespace Dreamine.UI.Abstractions.Popup;

/// <summary>BlinkPopupWindow 표시에 필요한 모든 옵션.</summary>
public sealed class BlinkPopupOptions
{
    /// <summary>제목(상단 바 + 중앙 타이틀).</summary>
    public string? Title { get; set; }

    /// <summary>메시지(컨텐츠가 없을 때 중앙 TextBlock에 표시).</summary>
    public string? Message { get; set; }

    /// <summary>사용자 지정 콘텐츠(UserControl 등).</summary>
    public object? Content { get; set; }

    /// <summary>OK 버튼 텍스트(null 또는 빈 문자열이면 버튼 숨김).</summary>
    public string? OkText { get; set; }

    /// <summary>Cancel 버튼 텍스트(null 또는 빈 문자열이면 버튼 숨김).</summary>
    public string? CancelText { get; set; }

    /// <summary>모달 여부.</summary>
    public bool IsModal { get; set; } = true;

    /// <summary>최상위(TopMost) 창 여부.</summary>
    public bool TopMost { get; set; } = true;

    /// <summary>전체 화면(모니터 크기) 사용 여부.</summary>
    public bool Fullscreen { get; set; } = false;

    /// <summary>(옵션) 고정 크기. 지정 시 Width/Height 적용.</summary>
    public Size? FixedSize { get; set; } = null;

    /// <summary>깜빡임 사용 여부.</summary>
    public bool UseBlink { get; set; } = true;

    /// <summary>중앙 카드(제목/버튼 포함한 검은 박스) 사용 여부.</summary>
    public bool UseContentCard { get; set; } = true;

    /// <summary>배경 1차 색상(깜빡임 From).</summary>
    public Color Color1 { get; set; } = Colors.Red;

    /// <summary>배경 2차 색상(깜빡임 To).</summary>
    public Color Color2 { get; set; } = Colors.DarkRed;

    /// <summary>전경(타이틀/메시지/아이콘 등 글자 색).</summary>
    public Color ForegroundColor { get; set; } = Colors.Yellow;

    /// <summary>불투명도 1(깜빡임 From).</summary>
    public double Opacity1 { get; set; } = 1.0;

    /// <summary>불투명도 2(깜빡임 To).</summary>
    public double Opacity2 { get; set; } = 0.25;

    /// <summary>깜빡임 간격(ms). 왕복 하나에 2배 소요(From→To→From).</summary>
    public int BlinkIntervalMs { get; set; } = 600;

    /// <summary>깜빡임 반복 횟수(0 = 무한 반복).</summary>
    public int BlinkRepeatCount { get; set; } = 0;

    /// <summary>상단/중앙 타이틀 폰트 크기.</summary>
    public double TitleFontSize { get; set; } = 40;

    /// <summary>메시지 폰트 크기.</summary>
    public double MessageFontSize { get; set; } = 22;

    /// <summary>Alt+F4(시스템 닫기)를 차단할지 여부(기본값: true).</summary>
    public bool BlockAltF4 { get; set; } = true;

    /// <summary>OK 클릭 시 인증 요구 여부.</summary>
    public bool RequireAuthOnOk { get; set; } = false;

    /// <summary>Cancel 클릭 시 인증 요구 여부.</summary>
    public bool RequireAuthOnCancel { get; set; } = false;

    /// <summary>인증 창 연계 시 주입할 ViewModel(옵션, INotifyPropertyChanged 구현 객체).</summary>
    public object? AuthViewModel { get; set; }
}
