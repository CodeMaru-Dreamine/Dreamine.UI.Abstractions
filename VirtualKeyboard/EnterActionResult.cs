using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Dreamine.UI.Abstractions.VirtualKeyboard;

/// <summary>
/// \if KO
/// <para>가상 키보드의 Enter 동작 결과와 사용자 피드백을 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents the result of a virtual-keyboard Enter action and its user feedback.</para>
/// \endif
/// </summary>
public class EnterActionResult
{
    /// <summary>
    /// \if KO
    /// <para>Enter 동작의 처리 상태를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the processing state of the Enter action.</para>
    /// \endif
    /// </summary>
    public ActionResult Result  { get; set; }
    /// <summary>
    /// \if KO
    /// <para>사용자에게 표시할 결과 메시지를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the result message displayed to the user.</para>
    /// \endif
    /// </summary>
    public string        Message { get; set; } = string.Empty;
    /// <summary>
    /// \if KO
    /// <para>결과와 함께 실행할 선택적 후속 동작을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets an optional follow-up action associated with the result.</para>
    /// \endif
    /// </summary>
    public Action?       Action  { get; set; }

    /// <summary>
    /// \if KO
    /// <para>지정한 처리 상태로 결과를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes a result with the specified processing state.</para>
    /// \endif
    /// </summary>
    /// <param name="result">
    /// \if KO
    /// <para>Enter 동작의 처리 상태입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The processing state of the Enter action.</para>
    /// \endif
    /// </param>
    public EnterActionResult(ActionResult result) => Result = result;

    /// <summary>
    /// \if KO
    /// <para>지정한 처리 상태와 메시지로 결과를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes a result with the specified processing state and message.</para>
    /// \endif
    /// </summary>
    /// <param name="result">
    /// \if KO
    /// <para>Enter 동작의 처리 상태입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The processing state of the Enter action.</para>
    /// \endif
    /// </param>
    /// <param name="message">
    /// \if KO
    /// <para>사용자에게 표시할 메시지입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The message to display to the user.</para>
    /// \endif
    /// </param>
    public EnterActionResult(ActionResult result, string message) : this(result)
    {
        Message = message;
    }

    /// <summary>
    /// \if KO
    /// <para>현재 결과가 입력을 계속 진행할 수 있는 상태인지 확인합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Determines whether the current result permits the input flow to continue.</para>
    /// \endif
    /// </summary>
    /// <returns>
    /// \if KO
    /// <para>결과가 성공 또는 무동작이면 <see langword="true"/>, 거부이면 <see langword="false"/>입니다.</para>
    /// \endif
    /// \if EN
    /// <para><see langword="true"/> for a successful or no-op result; <see langword="false"/> for a rejected result.</para>
    /// \endif
    /// </returns>
    public bool IsAccepted() => Result is ActionResult.OK or ActionResult.DoNothing;

    /// <summary>
    /// \if KO
    /// <para>결과 메시지와 상태 색상을 지정한 텍스트 상자에 UI 스레드에서 표시합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Displays the result message and status color in the specified text box on the UI thread.</para>
    /// \endif
    /// </summary>
    /// <param name="textBox">
    /// \if KO
    /// <para>결과를 표시할 텍스트 상자입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The text box in which to display the result.</para>
    /// \endif
    /// </param>
    /// <exception cref="NullReferenceException">
    /// \if KO
    /// <para>현재 WPF 애플리케이션 인스턴스가 없을 때 발생할 수 있습니다.</para>
    /// \endif
    /// \if EN
    /// <para>May occur when no current WPF application instance exists.</para>
    /// \endif
    /// </exception>
    public void Show(TextBox textBox)
    {
#pragma warning disable CS1587 // Doxygen documents local functions; the C# compiler does not attach XML docs to them.
/// \cond LOCAL_FUNCTION_DOCUMENTATION
        /// <summary>
        /// \if KO
        /// <para>현재 결과 메시지와 상태 색상을 대상 텍스트 상자에 적용합니다.</para>
        /// \endif
        /// \if EN
        /// <para>Applies the current result message and status color to the target text box.</para>
        /// \endif
        /// </summary>
/// \endcond
        void Apply()
        {
            textBox.Text       = Message;
            textBox.Foreground = Result == ActionResult.OK ? Brushes.Black : Brushes.Red;
        }
#pragma warning restore CS1587

        var dispatcher = Application.Current.Dispatcher;
        if (dispatcher.CheckAccess())
            Apply();
        else
            dispatcher.BeginInvoke(Apply);
    }
}

/// <summary>
/// \if KO
/// <para>승인된 Enter 동작 결과를 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents an accepted Enter-action result.</para>
/// \endif
/// </summary>
public class OkEnterActionResult : EnterActionResult
{
    /// <summary>
    /// \if KO
    /// <para>선택적 성공 메시지로 승인 결과를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes an accepted result with an optional success message.</para>
    /// \endif
    /// </summary>
    /// <param name="message">
    /// \if KO
    /// <para>사용자에게 표시할 성공 메시지입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The success message to display to the user.</para>
    /// \endif
    /// </param>
    public OkEnterActionResult(string message = "") : base(ActionResult.OK, message) { }
}

/// <summary>
/// \if KO
/// <para>거부된 Enter 동작 결과를 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents a rejected Enter-action result.</para>
/// \endif
/// </summary>
public class NgEnterActionResult : EnterActionResult
{
    /// <summary>
    /// \if KO
    /// <para>선택적 오류 메시지로 거부 결과를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes a rejected result with an optional error message.</para>
    /// \endif
    /// </summary>
    /// <param name="message">
    /// \if KO
    /// <para>사용자에게 표시할 오류 메시지입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The error message to display to the user.</para>
    /// \endif
    /// </param>
    public NgEnterActionResult(string message = "") : base(ActionResult.NG, message) { }
}

/// <summary>
/// \if KO
/// <para>후속 처리가 필요 없는 Enter 동작 결과를 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents an Enter-action result that requires no follow-up processing.</para>
/// \endif
/// </summary>
public class DoNothingEnterActionResult : EnterActionResult
{
    /// <summary>
    /// \if KO
    /// <para>무동작 결과를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes a no-op result.</para>
    /// \endif
    /// </summary>
    public DoNothingEnterActionResult() : base(ActionResult.DoNothing) { }
}
