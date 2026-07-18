using System.Windows;

namespace Dreamine.UI.Abstractions.Popup;

/// <summary>
/// \if KO
/// <para>깜빡임 팝업 창의 표시, 조회 및 수명 주기를 관리하는 서비스를 정의합니다.</para>
/// \endif
/// \if EN
/// <para>Defines a service that displays, queries, and manages the lifetime of blinking popup windows.</para>
/// \endif
/// </summary>
public interface IPopupService
{
    /// <summary>
    /// \if KO
    /// <para>지정한 옵션으로 깜빡임 팝업을 표시합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Displays a blinking popup using the specified options.</para>
    /// \endif
    /// </summary>
    /// <param name="owner">
    /// \if KO
    /// <para>팝업을 소유할 창이거나 소유자가 없으면 <see langword="null"/>입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The window that owns the popup, or <see langword="null"/> for no owner.</para>
    /// \endif
    /// </param>
    /// <param name="options">
    /// \if KO
    /// <para>팝업 표시 옵션입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The popup display options.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>확인이면 <see langword="true"/>, 취소이면 <see langword="false"/>, 결과가 없으면 <see langword="null"/>입니다.</para>
    /// \endif
    /// \if EN
    /// <para><see langword="true"/> for OK, <see langword="false"/> for Cancel, or <see langword="null"/> when no result is available.</para>
    /// \endif
    /// </returns>
    bool? ShowBlink(Window? owner, BlinkPopupOptions options);

    /// <summary>
    /// \if KO
    /// <para>깜빡임 팝업을 표시하고 생성된 창 참조를 반환합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Displays a blinking popup and returns the created window reference.</para>
    /// \endif
    /// </summary>
    /// <param name="owner">
    /// \if KO
    /// <para>팝업을 소유할 창이거나 소유자가 없으면 <see langword="null"/>입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The window that owns the popup, or <see langword="null"/> for no owner.</para>
    /// \endif
    /// </param>
    /// <param name="options">
    /// \if KO
    /// <para>팝업 표시 옵션입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The popup display options.</para>
    /// \endif
    /// </param>
    /// <param name="windowRef">
    /// \if KO
    /// <para>생성된 팝업 창을 받습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Receives the created popup window.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>확인이면 <see langword="true"/>, 취소이면 <see langword="false"/>, 결과가 없으면 <see langword="null"/>입니다.</para>
    /// \endif
    /// \if EN
    /// <para><see langword="true"/> for OK, <see langword="false"/> for Cancel, or <see langword="null"/> when no result is available.</para>
    /// \endif
    /// </returns>
    bool? ShowBlink(Window? owner, BlinkPopupOptions options, out Window windowRef);

    /// <summary>
    /// \if KO
    /// <para>서비스가 관리하는 열린 모든 깜빡임 팝업을 닫습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Closes every open blinking popup managed by the service.</para>
    /// \endif
    /// </summary>
    void CloseAll();

    /// <summary>
    /// \if KO
    /// <para>지정한 팝업 창을 닫습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Closes the specified popup window.</para>
    /// \endif
    /// </summary>
    /// <param name="window">
    /// \if KO
    /// <para>닫을 팝업 창입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The popup window to close.</para>
    /// \endif
    /// </param>
    void Close(Window window);

    /// <summary>
    /// \if KO
    /// <para>지정한 창이 소유한 모든 팝업을 닫습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Closes all popups owned by the specified window.</para>
    /// \endif
    /// </summary>
    /// <param name="owner">
    /// \if KO
    /// <para>닫을 팝업들의 소유자 창입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The owner of the popups to close.</para>
    /// \endif
    /// </param>
    void CloseOwnedBy(Window owner);

    /// <summary>
    /// \if KO
    /// <para>현재 활성화된 깜빡임 팝업을 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the currently active blinking popup.</para>
    /// \endif
    /// </summary>
    /// <returns>
    /// \if KO
    /// <para>활성 팝업 창이거나 활성 팝업이 없으면 <see langword="null"/>입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The active popup window, or <see langword="null"/> when none is active.</para>
    /// \endif
    /// </returns>
    Window? GetActive();

    /// <summary>
    /// \if KO
    /// <para>지정한 팝업에 적용된 옵션을 가져오려고 시도합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Attempts to get the options applied to the specified popup.</para>
    /// \endif
    /// </summary>
    /// <param name="window">
    /// \if KO
    /// <para>옵션을 조회할 팝업 창입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The popup window whose options are requested.</para>
    /// \endif
    /// </param>
    /// <param name="options">
    /// \if KO
    /// <para>조회에 성공하면 적용된 옵션을 받습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Receives the applied options when the lookup succeeds.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>옵션을 찾았으면 <see langword="true"/>, 그렇지 않으면 <see langword="false"/>입니다.</para>
    /// \endif
    /// \if EN
    /// <para><see langword="true"/> if the options were found; otherwise, <see langword="false"/>.</para>
    /// \endif
    /// </returns>
    bool TryGetOptions(Window window, out BlinkPopupOptions? options);

    /// <summary>
    /// \if KO
    /// <para>지정한 자식 팝업의 소유자 창에 적용된 옵션을 가져오려고 시도합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Attempts to get the options applied to the owner of the specified child popup.</para>
    /// \endif
    /// </summary>
    /// <param name="window">
    /// \if KO
    /// <para>소유자 옵션을 조회할 자식 팝업 창입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The child popup whose owner options are requested.</para>
    /// \endif
    /// </param>
    /// <param name="ownerOptions">
    /// \if KO
    /// <para>조회에 성공하면 소유자 창에 적용된 옵션을 받습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Receives the options applied to the owner window when the lookup succeeds.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>소유자 옵션을 찾았으면 <see langword="true"/>, 그렇지 않으면 <see langword="false"/>입니다.</para>
    /// \endif
    /// \if EN
    /// <para><see langword="true"/> if the owner options were found; otherwise, <see langword="false"/>.</para>
    /// \endif
    /// </returns>
    bool TryGetOwnerOptions(Window window, out BlinkPopupOptions? ownerOptions);

    /// <summary>
    /// \if KO
    /// <para>선택적 자동 닫기와 취소를 지원하며 깜빡임 팝업을 비동기로 표시합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Asynchronously displays a blinking popup with optional automatic closing and cancellation.</para>
    /// \endif
    /// </summary>
    /// <param name="owner">
    /// \if KO
    /// <para>팝업을 소유할 창이거나 소유자가 없으면 <see langword="null"/>입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The window that owns the popup, or <see langword="null"/> for no owner.</para>
    /// \endif
    /// </param>
    /// <param name="options">
    /// \if KO
    /// <para>팝업 표시 옵션입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The popup display options.</para>
    /// \endif
    /// </param>
    /// <param name="autoCloseAfter">
    /// \if KO
    /// <para>자동으로 닫을 때까지의 시간이거나 자동 닫기를 사용하지 않으면 <see langword="null"/>입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The duration before automatic closing, or <see langword="null"/> to disable automatic closing.</para>
    /// \endif
    /// </param>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>비동기 대기를 취소하는 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A token used to cancel the asynchronous wait.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>팝업 결과를 생성하는 작업입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A task that produces the popup result.</para>
    /// \endif
    /// </returns>
    Task<bool?> ShowBlinkAsync(
        Window? owner,
        BlinkPopupOptions options,
        TimeSpan? autoCloseAfter = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// \if KO
    /// <para>외부에서 생성한 팝업 창과 해당 옵션을 서비스의 관리 대상으로 등록합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Registers an externally created popup window and its options for management by the service.</para>
    /// \endif
    /// </summary>
    /// <param name="window">
    /// \if KO
    /// <para>등록할 팝업 창입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The popup window to register.</para>
    /// \endif
    /// </param>
    /// <param name="options">
    /// \if KO
    /// <para>창에 적용된 팝업 옵션입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The popup options applied to the window.</para>
    /// \endif
    /// </param>
    void RegisterWindow(Window window, BlinkPopupOptions options);
}
