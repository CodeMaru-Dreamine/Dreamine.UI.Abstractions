using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Dreamine.UI.Abstractions.Popup;
using Dreamine.UI.Abstractions.VirtualKeyboard;
using Xunit;
using ActionResult = Dreamine.UI.Abstractions.VirtualKeyboard.ActionResult;

namespace Dreamine.UI.Abstractions.Tests;

public sealed class UiAbstractionsContractTests
{
    [Fact]
    public void BlinkPopupOptionsExposeStableDefaults()
    {
        var options = new BlinkPopupOptions();

        Assert.Null(options.Title);
        Assert.Null(options.Message);
        Assert.Null(options.Content);
        Assert.Null(options.OkText);
        Assert.Null(options.CancelText);
        Assert.True(options.IsModal);
        Assert.True(options.TopMost);
        Assert.False(options.Fullscreen);
        Assert.Null(options.FixedSize);
        Assert.True(options.UseBlink);
        Assert.True(options.UseContentCard);
        Assert.Equal(Colors.Red, options.Color1);
        Assert.Equal(Colors.DarkRed, options.Color2);
        Assert.Equal(Colors.Yellow, options.ForegroundColor);
        Assert.Equal(1.0, options.Opacity1);
        Assert.Equal(0.25, options.Opacity2);
        Assert.Equal(600, options.BlinkIntervalMs);
        Assert.Equal(0, options.BlinkRepeatCount);
        Assert.Equal(40, options.TitleFontSize);
        Assert.Equal(22, options.MessageFontSize);
        Assert.True(options.BlockAltF4);
        Assert.False(options.RequireAuthOnOk);
        Assert.False(options.RequireAuthOnCancel);
        Assert.Null(options.AuthViewModel);
    }

    [Fact]
    public void BlinkPopupOptionsCanBeCustomized()
    {
        var content = new object();
        var authViewModel = new object();
        var fixedSize = new Size(640, 480);

        var options = new BlinkPopupOptions
        {
            Title = "Alarm",
            Message = "Check status",
            Content = content,
            OkText = "OK",
            CancelText = "Cancel",
            IsModal = false,
            TopMost = false,
            Fullscreen = true,
            FixedSize = fixedSize,
            UseBlink = false,
            UseContentCard = false,
            Color1 = Colors.Blue,
            Color2 = Colors.Green,
            ForegroundColor = Colors.White,
            Opacity1 = 0.9,
            Opacity2 = 0.4,
            BlinkIntervalMs = 250,
            BlinkRepeatCount = 3,
            TitleFontSize = 32,
            MessageFontSize = 18,
            BlockAltF4 = false,
            RequireAuthOnOk = true,
            RequireAuthOnCancel = true,
            AuthViewModel = authViewModel
        };

        Assert.Equal("Alarm", options.Title);
        Assert.Equal("Check status", options.Message);
        Assert.Same(content, options.Content);
        Assert.Equal("OK", options.OkText);
        Assert.Equal("Cancel", options.CancelText);
        Assert.False(options.IsModal);
        Assert.False(options.TopMost);
        Assert.True(options.Fullscreen);
        Assert.Equal(fixedSize, options.FixedSize);
        Assert.False(options.UseBlink);
        Assert.False(options.UseContentCard);
        Assert.Equal(Colors.Blue, options.Color1);
        Assert.Equal(Colors.Green, options.Color2);
        Assert.Equal(Colors.White, options.ForegroundColor);
        Assert.Equal(0.9, options.Opacity1);
        Assert.Equal(0.4, options.Opacity2);
        Assert.Equal(250, options.BlinkIntervalMs);
        Assert.Equal(3, options.BlinkRepeatCount);
        Assert.Equal(32, options.TitleFontSize);
        Assert.Equal(18, options.MessageFontSize);
        Assert.False(options.BlockAltF4);
        Assert.True(options.RequireAuthOnOk);
        Assert.True(options.RequireAuthOnCancel);
        Assert.Same(authViewModel, options.AuthViewModel);
    }

    [Fact]
    public void KeyDataStoresEveryLanguageVariant()
    {
        var keyData = new KeyData("a", "A", "ㅁ", "ㅃ", "中", "國");

        Assert.Equal("a", keyData.DefaultKey);
        Assert.Equal("A", keyData.ShiftKey);
        Assert.Equal("ㅁ", keyData.KorKey);
        Assert.Equal("ㅃ", keyData.KorShiftKey);
        Assert.Equal("中", keyData.ChnKey);
        Assert.Equal("國", keyData.ChnShiftKey);

        keyData.DefaultKey = "b";
        keyData.ShiftKey = "B";
        keyData.KorKey = "ㅠ";
        keyData.KorShiftKey = "ㅉ";
        keyData.ChnKey = "文";
        keyData.ChnShiftKey = "字";

        Assert.Equal("b", keyData.DefaultKey);
        Assert.Equal("B", keyData.ShiftKey);
        Assert.Equal("ㅠ", keyData.KorKey);
        Assert.Equal("ㅉ", keyData.KorShiftKey);
        Assert.Equal("文", keyData.ChnKey);
        Assert.Equal("字", keyData.ChnShiftKey);
    }

    [Fact]
    public void EnterActionResultTypesExposeExpectedAcceptance()
    {
        var ok = new OkEnterActionResult("saved");
        var ng = new NgEnterActionResult("blocked");
        var none = new DoNothingEnterActionResult();
        var custom = new EnterActionResult(ActionResult.OK) { Action = () => { } };

        Assert.True(ok.IsAccepted());
        Assert.Equal("saved", ok.Message);
        Assert.False(ng.IsAccepted());
        Assert.Equal("blocked", ng.Message);
        Assert.True(none.IsAccepted());
        Assert.Equal(ActionResult.DoNothing, none.Result);
        Assert.True(custom.IsAccepted());
        Assert.NotNull(custom.Action);
    }

    [Fact]
    public void EnumsAndSpecialButtonNamesRemainStable()
    {
        Assert.Equal(0, (int)ActionResult.OK);
        Assert.Equal(1, (int)ActionResult.NG);
        Assert.Equal(2, (int)ActionResult.DoNothing);
        Assert.Equal(0, (int)KeyboardInputMode.Full);
        Assert.Equal(1, (int)KeyboardInputMode.Numeric);
        Assert.Equal(0, (int)LanguageCode.en_US);
        Assert.Equal(1, (int)LanguageCode.ko_KR);
        Assert.Equal(2, (int)LanguageCode.zh_CN);
        Assert.Equal(3, (int)LanguageCode.vi_VN);
        Assert.Equal(0, (int)VkLayout.Text);
        Assert.Equal(1, (int)VkLayout.Numeric);
        Assert.Equal(2, (int)VkLayout.Decimal);
        Assert.Equal(3, (int)VkLayout.Password);
        Assert.Equal("_langBtn", SpecialButtonName.LangBtn);
        Assert.Equal("_inputModeBtn", SpecialButtonName.InputModeBtn);
    }

    [Fact]
    public void EnterActionResultCanRenderToTextBoxOnStaThread()
    {
        Exception? failure = null;
        var thread = new Thread(() =>
        {
            try
            {
                var application = Application.Current ?? new Application();
                var textBox = new TextBox();
                var ok = new OkEnterActionResult("ready");
                var ng = new NgEnterActionResult("stop");

                ok.Show(textBox);
                Assert.Equal("ready", textBox.Text);
                Assert.Equal(Brushes.Black, textBox.Foreground);

                ng.Show(textBox);
                Assert.Equal("stop", textBox.Text);
                Assert.Equal(Brushes.Red, textBox.Foreground);

                application.Shutdown();
            }
            catch (Exception ex)
            {
                failure = ex;
            }
        });

        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        thread.Join();

        Assert.Null(failure);
    }
}
