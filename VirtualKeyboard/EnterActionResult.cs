using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Dreamine.UI.Abstractions.VirtualKeyboard;

public class EnterActionResult
{
    public eActionResult Result  { get; set; }
    public string        Message { get; set; } = string.Empty;
    public Action?       Action  { get; set; }

    public EnterActionResult(eActionResult result) => Result = result;

    public EnterActionResult(eActionResult result, string message) : this(result)
        => Message = message;

    public bool IsAccepted() => Result is eActionResult.OK or eActionResult.DoNothing;

    public void Show(TextBox textBox)
    {
        Application.Current.Dispatcher.Invoke(() =>
        {
            textBox.Text       = Message;
            textBox.Foreground = Result == eActionResult.OK ? Brushes.Black : Brushes.Red;
        });
    }
}

public class OkEnterActionResult : EnterActionResult
{
    public OkEnterActionResult(string message = "") : base(eActionResult.OK, message) { }
}

public class NgEnterActionResult : EnterActionResult
{
    public NgEnterActionResult(string message = "") : base(eActionResult.NG, message) { }
}

public class DoNothingEnterActionResult : EnterActionResult
{
    public DoNothingEnterActionResult() : base(eActionResult.DoNothing) { }
}
