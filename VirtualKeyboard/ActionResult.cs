namespace Dreamine.UI.Abstractions.VirtualKeyboard;

/// <summary>
/// \if KO
/// <para>가상 키보드 입력 동작의 처리 결과를 지정합니다.</para>
/// \endif
/// \if EN
/// <para>Specifies the outcome of a virtual-keyboard input action.</para>
/// \endif
/// </summary>
public enum ActionResult
{
    /// <summary>
    /// \if KO
    /// <para>입력이 성공적으로 승인되었음을 나타냅니다.</para>
    /// \endif
    /// \if EN
    /// <para>Indicates that the input was accepted successfully.</para>
    /// \endif
    /// </summary>
    OK,
    /// <summary>
    /// \if KO
    /// <para>입력이 거부되었거나 유효성 검사에 실패했음을 나타냅니다.</para>
    /// \endif
    /// \if EN
    /// <para>Indicates that the input was rejected or failed validation.</para>
    /// \endif
    /// </summary>
    NG,
    /// <summary>
    /// \if KO
    /// <para>입력에 대해 추가 동작을 수행하지 않음을 나타냅니다.</para>
    /// \endif
    /// \if EN
    /// <para>Indicates that no additional action should be performed for the input.</para>
    /// \endif
    /// </summary>
    DoNothing
}
