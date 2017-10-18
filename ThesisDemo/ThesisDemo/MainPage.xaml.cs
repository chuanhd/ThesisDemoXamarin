using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ThesisDemo
{
    public partial class MainPage : ContentPage
    {

        public static IList<string> m_Items = new List<string> { "UI and UX", "Layout", "Animation", "Web Services", "Third party and services", "Multithreading and background thread", "Testing" };

        public MainPage()
        {
            InitializeComponent();
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            //DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");
            ((ListView)sender).SelectedItem = null;

            var _selectedItem = e.SelectedItem.ToString();
            if (_selectedItem == "Layout") {
                await Navigation.PushAsync(new Pages.LayoutPage());
            }


        }
    }
}
