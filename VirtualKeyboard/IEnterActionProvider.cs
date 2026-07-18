using System.Windows;

namespace Dreamine.UI.Abstractions.VirtualKeyboard;

/// <summary>
/// \if KO
/// <para>가상 키보드의 Enter 입력 처리와 현재 값 읽기 기능을 정의합니다.</para>
/// \endif
/// \if EN
/// <para>Defines Enter-input processing and current-value retrieval for a virtual keyboard.</para>
/// \endif
/// </summary>
public interface IEnterActionProvider
{
    /// <summary>
    /// \if KO
    /// <para>키보드가 배치되는 대상 WPF 객체를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the WPF object relative to which the keyboard is placed.</para>
    /// \endif
    /// </summary>
    DependencyObject? PlacementTarget { get; set; }
    /// <summary>
    /// \if KO
    /// <para>Enter 입력에 연결된 동작을 비동기로 실행합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Asynchronously executes the action associated with Enter input.</para>
    /// \endif
    /// </summary>
    /// <returns>
    /// \if KO
    /// <para>Enter 동작 결과를 생성하는 작업입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A task that produces the Enter-action result.</para>
    /// \endif
    /// </returns>
    Task<EnterActionResult> ExecuteAsync();
    /// <summary>
    /// \if KO
    /// <para>공급자가 보유한 현재 입력 값을 읽습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Reads the current input value held by the provider.</para>
    /// \endif
    /// </summary>
    /// <returns>
    /// \if KO
    /// <para>현재 입력 값입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The current input value.</para>
    /// \endif
    /// </returns>
    object Read();
}
