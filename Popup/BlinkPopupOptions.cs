using System.Windows;
using System.Windows.Media;

namespace Dreamine.UI.Abstractions.Popup;

/// <summary>
/// \if KO
/// <para>깜빡임 팝업 창의 표시 방식과 동작을 구성하는 옵션을 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents options that configure the appearance and behavior of a blinking popup window.</para>
/// \endif
/// </summary>
public sealed class BlinkPopupOptions
{
    /// <summary>
    /// \if KO
    /// <para>상단 표시줄과 중앙 카드에 표시할 제목을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the title displayed in the top bar and center card.</para>
    /// \endif
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// \if KO
    /// <para>사용자 지정 콘텐츠가 없을 때 중앙에 표시할 메시지를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the message displayed in the center when no custom content is supplied.</para>
    /// \endif
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// \if KO
    /// <para>팝업에 표시할 사용자 지정 콘텐츠를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets custom content to display in the popup.</para>
    /// \endif
    /// </summary>
    public object? Content { get; set; }

    /// <summary>
    /// \if KO
    /// <para>확인 버튼의 텍스트를 가져오거나 설정합니다. <see langword="null"/> 또는 빈 문자열이면 버튼을 숨깁니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the OK button text. A <see langword="null"/> or empty value hides the button.</para>
    /// \endif
    /// </summary>
    public string? OkText { get; set; }

    /// <summary>
    /// \if KO
    /// <para>취소 버튼의 텍스트를 가져오거나 설정합니다. <see langword="null"/> 또는 빈 문자열이면 버튼을 숨깁니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the Cancel button text. A <see langword="null"/> or empty value hides the button.</para>
    /// \endif
    /// </summary>
    public string? CancelText { get; set; }

    /// <summary>
    /// \if KO
    /// <para>팝업을 모달 창으로 표시할지 여부를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets whether the popup is displayed as a modal window.</para>
    /// \endif
    /// </summary>
    public bool IsModal { get; set; } = true;

    /// <summary>
    /// \if KO
    /// <para>팝업을 항상 위 창으로 유지할지 여부를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets whether the popup remains a topmost window.</para>
    /// \endif
    /// </summary>
    public bool TopMost { get; set; } = true;

    /// <summary>
    /// \if KO
    /// <para>팝업이 모니터 전체 크기를 사용할지 여부를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets whether the popup uses the full monitor size.</para>
    /// \endif
    /// </summary>
    public bool Fullscreen { get; set; } = false;

    /// <summary>
    /// \if KO
    /// <para>팝업에 적용할 선택적 고정 너비와 높이를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the optional fixed width and height applied to the popup.</para>
    /// \endif
    /// </summary>
    public Size? FixedSize { get; set; } = null;

    /// <summary>
    /// \if KO
    /// <para>배경 깜빡임 효과를 사용할지 여부를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets whether the background blinking effect is enabled.</para>
    /// \endif
    /// </summary>
    public bool UseBlink { get; set; } = true;

    /// <summary>
    /// \if KO
    /// <para>제목과 버튼을 담는 중앙 콘텐츠 카드를 표시할지 여부를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets whether the center content card containing the title and buttons is displayed.</para>
    /// \endif
    /// </summary>
    public bool UseContentCard { get; set; } = true;

    /// <summary>
    /// \if KO
    /// <para>깜빡임 애니메이션의 시작 배경색을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the starting background color of the blinking animation.</para>
    /// \endif
    /// </summary>
    public Color Color1 { get; set; } = Colors.Red;

    /// <summary>
    /// \if KO
    /// <para>깜빡임 애니메이션의 종료 배경색을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the ending background color of the blinking animation.</para>
    /// \endif
    /// </summary>
    public Color Color2 { get; set; } = Colors.DarkRed;

    /// <summary>
    /// \if KO
    /// <para>제목, 메시지 및 아이콘에 사용할 전경색을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the foreground color used for titles, messages, and icons.</para>
    /// \endif
    /// </summary>
    public Color ForegroundColor { get; set; } = Colors.Yellow;

    /// <summary>
    /// \if KO
    /// <para>깜빡임 애니메이션의 시작 불투명도를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the starting opacity of the blinking animation.</para>
    /// \endif
    /// </summary>
    public double Opacity1 { get; set; } = 1.0;

    /// <summary>
    /// \if KO
    /// <para>깜빡임 애니메이션의 종료 불투명도를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the ending opacity of the blinking animation.</para>
    /// \endif
    /// </summary>
    public double Opacity2 { get; set; } = 0.25;

    /// <summary>
    /// \if KO
    /// <para>한 방향 깜빡임 전환 간격을 밀리초 단위로 가져오거나 설정합니다. 한 번의 왕복에는 이 값의 두 배가 걸립니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the one-way blink transition interval in milliseconds. A round trip takes twice this value.</para>
    /// \endif
    /// </summary>
    public int BlinkIntervalMs { get; set; } = 600;

    /// <summary>
    /// \if KO
    /// <para>깜빡임 반복 횟수를 가져오거나 설정합니다. 0은 무한 반복을 의미합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the blink repetition count. Zero means repeat indefinitely.</para>
    /// \endif
    /// </summary>
    public int BlinkRepeatCount { get; set; } = 0;

    /// <summary>
    /// \if KO
    /// <para>상단 및 중앙 제목의 글꼴 크기를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the font size of the top and center titles.</para>
    /// \endif
    /// </summary>
    public double TitleFontSize { get; set; } = 40;

    /// <summary>
    /// \if KO
    /// <para>메시지의 글꼴 크기를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the message font size.</para>
    /// \endif
    /// </summary>
    public double MessageFontSize { get; set; } = 22;

    /// <summary>
    /// \if KO
    /// <para>Alt+F4 시스템 닫기 동작을 차단할지 여부를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets whether the Alt+F4 system-close action is blocked.</para>
    /// \endif
    /// </summary>
    public bool BlockAltF4 { get; set; } = true;

    /// <summary>
    /// \if KO
    /// <para>확인 버튼을 클릭할 때 인증을 요구할지 여부를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets whether authentication is required when the OK button is clicked.</para>
    /// \endif
    /// </summary>
    public bool RequireAuthOnOk { get; set; } = false;

    /// <summary>
    /// \if KO
    /// <para>취소 버튼을 클릭할 때 인증을 요구할지 여부를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets whether authentication is required when the Cancel button is clicked.</para>
    /// \endif
    /// </summary>
    public bool RequireAuthOnCancel { get; set; } = false;

    /// <summary>
    /// \if KO
    /// <para>인증 창에 연결할 선택적 뷰 모델을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the optional view model to associate with the authentication window.</para>
    /// \endif
    /// </summary>
    public object? AuthViewModel { get; set; }
}
