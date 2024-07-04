using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaUIExamples.Routing.ViewModels;
using ReactiveUI;
using Avalonia.ReactiveUI;

namespace AvaloniaUIExamples.Routing.Views;

public partial class FirstView : ReactiveUserControl<FirstViewModel>
{
    public FirstView()
    {
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
    }
}