using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using System.Windows.Input;

namespace PopoverCarouselBug;

public partial class MainPage : ContentPage
{
    public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(MainPage));

    public ICommand Command
    {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create("CommandParameter", typeof(object), typeof(MainPage));

    public object CommandParameter
    {
        get => GetValue(CommandParameterProperty);
        set => SetValue(CommandParameterProperty, value);
    }

    public MainPage()
    {
        InitializeComponent();

        Command = new Command(popupCommand);
    }

    private void popupCommand(object obj)
    {
        this.ShowPopup(new CustomPopup { Anchor = obj as View });
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        this.ShowPopup(new CustomPopup { Anchor = sender as View});
    }

    private void TouchBehavior_OnTouchGestureCompleted(object? sender, TouchGestureCompletedEventArgs e)
    {
        this.ShowPopup(new CustomPopup { Anchor = sender as View });
    }
}