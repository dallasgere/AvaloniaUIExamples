using System;
using ReactiveUI;
using System.Reactive;

namespace Avalonia.App.ViewModels;

public class NewViewModel : ReactiveObject
{
    public ReactiveCommand<Unit, Unit> ShowMessageCommand { get; }

    public NewViewModel()
    {
        ShowMessageCommand = ReactiveCommand.Create(() =>
        {
            // Simulate some action
            Console.WriteLine("New view shown!");
        });
    }
}