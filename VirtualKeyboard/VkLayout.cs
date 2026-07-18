namespace Dreamine.UI.Abstractions.VirtualKeyboard;

/// <summary>
/// \if KO
/// <para>가상 키보드에 사용할 레이아웃 종류를 지정합니다.</para>
/// \endif
/// \if EN
/// <para>Specifies the layout type used by the virtual keyboard.</para>
/// \endif
/// </summary>
public enum VkLayout
{
    /// <summary>
    /// \if KO
    /// <para>일반 텍스트 입력 레이아웃을 사용합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Uses the general text-input layout.</para>
    /// \endif
    /// </summary>
    Text,
    /// <summary>
    /// \if KO
    /// <para>정수 숫자 입력 레이아웃을 사용합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Uses the integer numeric-input layout.</para>
    /// \endif
    /// </summary>
    Numeric,
    /// <summary>
    /// \if KO
    /// <para>소수점 숫자 입력 레이아웃을 사용합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Uses the decimal numeric-input layout.</para>
    /// \endif
    /// </summary>
    Decimal,
    /// <summary>
    /// \if KO
    /// <para>암호 입력을 위한 마스킹 레이아웃을 사용합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Uses a masked layout for password input.</para>
    /// \endif
    /// </summary>
    Password,
}
