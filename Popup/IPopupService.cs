using System.Windows;

namespace Dreamine.UI.Abstractions.Popup;

/// <summary>깜빡임 팝업 표시 서비스 인터페이스.</summary>
public interface IPopupService
{
    /// <summary>깜빡임 팝업을 표시한다.</summary>
    bool? ShowBlink(Window? owner, BlinkPopupOptions options);

    /// <summary>깜빡임 팝업을 표시하고 생성된 Window 참조를 반환(out)한다.</summary>
    bool? ShowBlink(Window? owner, BlinkPopupOptions options, out Window windowRef);

    /// <summary>열린 모든 BlinkPopup을 닫는다.</summary>
    void CloseAll();

    /// <summary>지정한 팝업 한 개만 닫는다.</summary>
    void Close(Window window);

    /// <summary>특정 Owner가 소유한 팝업들만 닫는다.</summary>
    void CloseOwnedBy(Window owner);

    /// <summary>현재 활성 BlinkPopup을 반환한다. 없으면 null.</summary>
    Window? GetActive();

    /// <summary>특정 팝업(Window)에 실제 적용된 BlinkPopupOptions를 얻는다.</summary>
    bool TryGetOptions(Window window, out BlinkPopupOptions? options);

    /// <summary>자식 팝업(Window)의 Owner(부모) 창에 적용된 BlinkPopupOptions를 얻는다.</summary>
    bool TryGetOwnerOptions(Window window, out BlinkPopupOptions? ownerOptions);

    /// <summary>깜빡임 팝업을 비동기로 표시한다(모달 효과 지원).</summary>
    Task<bool?> ShowBlinkAsync(
        Window? owner,
        BlinkPopupOptions options,
        TimeSpan? autoCloseAfter = null,
        CancellationToken cancellationToken = default);

    /// <summary>외부에서 생성한 팝업 창을 PopupService 관리 대상에 등록한다.</summary>
    void RegisterWindow(Window window, BlinkPopupOptions options);
}
