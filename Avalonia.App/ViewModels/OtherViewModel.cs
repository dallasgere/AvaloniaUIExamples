using ReactiveUI;

namespace Avalonia.App.ViewModels;

public class OtherViewModel : ReactiveObject
{
    public string Greeting { get; } = "Welcome to the new view.";
}