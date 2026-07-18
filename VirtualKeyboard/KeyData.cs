namespace Dreamine.UI.Abstractions.VirtualKeyboard;

/// <summary>
/// \if KO
/// <para>하나의 가상 키에 대한 언어별 및 Shift 상태별 표시 값을 저장합니다.</para>
/// \endif
/// \if EN
/// <para>Stores language-specific and Shift-specific display values for a virtual key.</para>
/// \endif
/// </summary>
public class KeyData
{
    /// <summary>
    /// \if KO
    /// <para>기본 키 값을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the default key value.</para>
    /// \endif
    /// </summary>
    public string DefaultKey { get; set; } = string.Empty;
    /// <summary>
    /// \if KO
    /// <para>Shift 상태의 기본 키 값을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the shifted default key value.</para>
    /// \endif
    /// </summary>
    public string ShiftKey   { get; set; } = string.Empty;
    /// <summary>
    /// \if KO
    /// <para>한국어 키 값을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the Korean key value.</para>
    /// \endif
    /// </summary>
    public string KorKey     { get; set; } = string.Empty;
    /// <summary>
    /// \if KO
    /// <para>Shift 상태의 한국어 키 값을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the shifted Korean key value.</para>
    /// \endif
    /// </summary>
    public string KorShiftKey { get; set; } = string.Empty;
    /// <summary>
    /// \if KO
    /// <para>중국어 키 값을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the Chinese key value.</para>
    /// \endif
    /// </summary>
    public string ChnKey     { get; set; } = string.Empty;
    /// <summary>
    /// \if KO
    /// <para>Shift 상태의 중국어 키 값을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the shifted Chinese key value.</para>
    /// \endif
    /// </summary>
    public string ChnShiftKey { get; set; } = string.Empty;

    /// <summary>
    /// \if KO
    /// <para>언어별 및 Shift 상태별 키 값으로 인스턴스를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes an instance with language-specific and Shift-specific key values.</para>
    /// \endif
    /// </summary>
    /// <param name="defaultKey">
    /// \if KO
    /// <para>기본 키 값입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The default key value.</para>
    /// \endif
    /// </param>
    /// <param name="shiftKey">
    /// \if KO
    /// <para>Shift 상태의 기본 키 값입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The shifted default key value.</para>
    /// \endif
    /// </param>
    /// <param name="korKey">
    /// \if KO
    /// <para>한국어 키 값입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The Korean key value.</para>
    /// \endif
    /// </param>
    /// <param name="korShiftKey">
    /// \if KO
    /// <para>Shift 상태의 한국어 키 값입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The shifted Korean key value.</para>
    /// \endif
    /// </param>
    /// <param name="chnKey">
    /// \if KO
    /// <para>중국어 키 값입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The Chinese key value.</para>
    /// \endif
    /// </param>
    /// <param name="chnShiftKey">
    /// \if KO
    /// <para>Shift 상태의 중국어 키 값입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The shifted Chinese key value.</para>
    /// \endif
    /// </param>
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
