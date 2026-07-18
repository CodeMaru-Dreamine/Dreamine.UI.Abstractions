namespace Dreamine.UI.Abstractions.VirtualKeyboard;

/// <summary>
/// \if KO
/// <para>가상 키보드가 제공하는 입력 키의 범위를 지정합니다.</para>
/// \endif
/// \if EN
/// <para>Specifies the range of input keys provided by the virtual keyboard.</para>
/// \endif
/// </summary>
public enum KeyboardInputMode
{
    /// <summary>
    /// \if KO
    /// <para>전체 문자 및 숫자 키보드를 사용합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Uses the full alphanumeric keyboard.</para>
    /// \endif
    /// </summary>
    Full,
    /// <summary>
    /// \if KO
    /// <para>숫자 전용 키보드를 사용합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Uses a numeric-only keyboard.</para>
    /// \endif
    /// </summary>
    Numeric
}
