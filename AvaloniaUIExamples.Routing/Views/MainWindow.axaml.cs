using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using AvaloniaUIExamples.Routing.ViewModels;
using ReactiveUI;

namespace AvaloniaUIExamples.Routing.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
    }
}