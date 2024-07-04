using System;
using AvaloniaUIExamples.Routing.ViewModels;
using AvaloniaUIExamples.Routing.Views;
using ReactiveUI;

namespace AvaloniaUIExamples.Routing;

public class AppViewLocator : ReactiveUI.IViewLocator
{
    public IViewFor ResolveView<T>(T viewModel, string contract = null) => viewModel switch
    {
        FirstViewModel context => new FirstView { DataContext = context },
        OtherViewModel context => new OtherView { DataContext = context },
        _ => throw new ArgumentOutOfRangeException(nameof(viewModel))
    };
}