using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ThesisDemo.Pages
{
    public partial class AnimationPage : ContentPage
    {
        public AnimationPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var _button = (Button)sender;
            _button.RotateTo(360, 4000);
            await _button.ScaleTo(2, 2000);
            await _button.ScaleTo(1, 2000);
        }
    }
}
