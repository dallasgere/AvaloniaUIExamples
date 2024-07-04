using System;
using ReactiveUI;

namespace AvaloniaUIExamples.Routing.ViewModels;

public class OtherViewModel : ReactiveObject, IRoutableViewModel
{
    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

    public OtherViewModel(IScreen screen) => HostScreen = screen;
}