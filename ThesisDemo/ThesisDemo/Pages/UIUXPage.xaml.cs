using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ThesisDemo.Pages
{
    public partial class UIUXPage : ContentPage
    {
        public UIUXPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new UIUXSecondPage(), true);
        }
    }
}
