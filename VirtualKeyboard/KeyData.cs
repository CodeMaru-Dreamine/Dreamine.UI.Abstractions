namespace Dreamine.UI.Abstractions.VirtualKeyboard;

public class KeyData
{
    public string DefaultKey { get; set; } = string.Empty;
    public string ShiftKey   { get; set; } = string.Empty;
    public string KorKey     { get; set; } = string.Empty;
    public string KorShiftKey { get; set; } = string.Empty;
    public string ChnKey     { get; set; } = string.Empty;
    public string ChnShiftKey { get; set; } = string.Empty;

    public KeyData(
        string defaultKey = "", string shiftKey = "",
        string korKey = "", string korShiftKey = "",
        string chnKey = "", string chnShiftKey = "")
    {
        DefaultKey  = defaultKey;
        ShiftKey    = shiftKey;
        KorKey      = korKey;
        KorShiftKey = korShiftKey;
        ChnKey      = chnKey;
        ChnShiftKey = chnShiftKey;
    }
}
