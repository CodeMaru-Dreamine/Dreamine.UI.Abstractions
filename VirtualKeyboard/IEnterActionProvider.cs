using System.Windows;

namespace Dreamine.UI.Abstractions.VirtualKeyboard;

public interface IEnterActionProvider
{
    DependencyObject? PlacementTarget { get; set; }
    Task<EnterActionResult> ExecuteAsync();
    object Read();
}
