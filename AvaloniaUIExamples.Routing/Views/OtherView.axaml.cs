using Avalonia.Markup.Xaml;
using AvaloniaUIExamples.Routing.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AvaloniaUIExamples.Routing.Views;

public partial class OtherView : ReactiveUserControl<OtherViewModel>
{
    public OtherView()
    {
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
    }
}