using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ThesisDemo.Pages
{
    public partial class LayoutPage : ContentPage
    {
        public LayoutPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Button clicked", "Login button pressed", "Ok");
        }
    }
}
