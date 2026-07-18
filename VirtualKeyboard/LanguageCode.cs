namespace Dreamine.UI.Abstractions.VirtualKeyboard;

/// <summary>
/// \if KO
/// <para>가상 키보드에서 지원하는 언어 및 지역 코드를 지정합니다.</para>
/// \endif
/// \if EN
/// <para>Specifies language and locale codes supported by the virtual keyboard.</para>
/// \endif
/// </summary>
public enum LanguageCode
{
    /// <summary>
    /// \if KO
    /// <para>미국 영어를 나타냅니다.</para>
    /// \endif
    /// \if EN
    /// <para>Represents English (United States).</para>
    /// \endif
    /// </summary>
    en_US,
    /// <summary>
    /// \if KO
    /// <para>대한민국 한국어를 나타냅니다.</para>
    /// \endif
    /// \if EN
    /// <para>Represents Korean (Republic of Korea).</para>
    /// \endif
    /// </summary>
    ko_KR,
    /// <summary>
    /// \if KO
    /// <para>중국 간체 중국어를 나타냅니다.</para>
    /// \endif
    /// \if EN
    /// <para>Represents Simplified Chinese (China).</para>
    /// \endif
    /// </summary>
    zh_CN,
    /// <summary>
    /// \if KO
    /// <para>베트남어를 나타냅니다.</para>
    /// \endif
    /// \if EN
    /// <para>Represents Vietnamese (Vietnam).</para>
    /// \endif
    /// </summary>
    vi_VN,
}
