﻿using System.Reactive;
using ReactiveUI;
using System;
using System.Windows.Input;
using Avalonia.App.Views;

namespace Avalonia.App.ViewModels;

public class MainWindowViewModel : ReactiveObject
{
    private int _count;
    private string _textBoxContent = "";
    private object _currentView;
    private int _calculatedLength;

    public int CalculatedLength
    {
        get => _calculatedLength;
        set => this.RaiseAndSetIfChanged(ref _calculatedLength, value);
    }

    public object CurrentView
    {
        get => _currentView;
        set => this.RaiseAndSetIfChanged(ref _currentView, value);
    }

    public int Count
    {
        get => _count;
        set => this.RaiseAndSetIfChanged(ref _count, value);
    }

    public string TextBoxContent
    {
        get => _textBoxContent;
        set => this.RaiseAndSetIfChanged(ref _textBoxContent, value);
    }

    public ReactiveCommand<Unit, Unit> IncrementCommand { get; }
    public ReactiveCommand<Unit, Unit> DecrementCommand { get; }
    public ReactiveCommand<string, int> CalculateLengthCommand { get; }

    public ICommand NavigateToNewViewCommand { get; }

    public MainWindowViewModel()
    {
        IncrementCommand = ReactiveCommand.Create(() =>
        {
            Count++;
            Console.WriteLine($"Increment pressed. Text box content: {TextBoxContent}");
            ShowLength(TextBoxContent);
        });
        DecrementCommand = ReactiveCommand.Create(() =>
        {
            Count--;
            Console.WriteLine($"Decrement pressed. Text box content: {TextBoxContent}");
            ShowLength(TextBoxContent);
        });

        NavigateToNewViewCommand = ReactiveCommand.Create(NavigateToNewView);
    }

    public void NavigateToNewView()
    {
        var newView = new NewView();
        newView.Show();
    }

    public int GetLength(string word)
    {
        return word.Length;
    }

    public void ShowLength(string word)
    {
        Console.WriteLine($"length: {GetLength(word)}");
    }
}