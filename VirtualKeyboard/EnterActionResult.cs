using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Dreamine.UI.Abstractions.VirtualKeyboard;

public class EnterActionResult
{
    public ActionResult Result  { get; set; }
    public string        Message { get; set; } = string.Empty;
    public Action?       Action  { get; set; }

    public EnterActionResult(ActionResult result) => Result = result;

    public EnterActionResult(ActionResult result, string message) : this(result)
        => Message = message;

    public bool IsAccepted() => Result is ActionResult.OK or ActionResult.DoNothing;

    public void Show(TextBox textBox)
    {
        Application.Current.Dispatcher.Invoke(() =>
        {
            textBox.Text       = Message;
            textBox.Foreground = Result == ActionResult.OK ? Brushes.Black : Brushes.Red;
        });
    }
}

public class OkEnterActionResult : EnterActionResult
{
    public OkEnterActionResult(string message = "") : base(ActionResult.OK, message) { }
}

public class NgEnterActionResult : EnterActionResult
{
    public NgEnterActionResult(string message = "") : base(ActionResult.NG, message) { }
}

public class DoNothingEnterActionResult : EnterActionResult
{
    public DoNothingEnterActionResult() : base(ActionResult.DoNothing) { }
}
