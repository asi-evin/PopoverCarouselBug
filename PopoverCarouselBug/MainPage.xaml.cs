using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;

namespace PopoverCarouselBug
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            this.ShowPopup(new CustomPopup { Anchor = sender as View});
        }

        private void TouchBehavior_OnTouchGestureCompleted(object? sender, TouchGestureCompletedEventArgs e)
        {
            this.ShowPopup(new CustomPopup { Anchor = sender as View });
        }
    }

}
