namespace Dreamine.UI.Abstractions.VirtualKeyboard;

public class KeyData
{
    public string DefaultKey { get; set; }
    public string ShiftKey   { get; set; }
    public string KorKey     { get; set; }
    public string KorShiftKey { get; set; }
    public string ChnKey     { get; set; }
    public string ChnShiftKey { get; set; }

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
