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
            var _selectedIndex = m_Items.IndexOf(_selectedItem);
            switch (_selectedIndex) {
                case 0:
                    await Navigation.PushAsync(new Pages.UIUXPage(), false);
                    break;

                case 1:
                    await Navigation.PushAsync(new Pages.LayoutPage(), false);
                    break;

                case 2:
                    await Navigation.PushAsync(new Pages.AnimationPage(), false);
                    break;

                case 3:
                    await Navigation.PushAsync(new Pages.UIUXPage(), false);
                    break;

                case 4:
                    await Navigation.PushAsync(new Pages.UIUXPage(), false);
                    break;

                case 5:
                    await Navigation.PushAsync(new Pages.MultiTasking.ListPage(), false);
                    break;

                case 6:
                    await Navigation.PushAsync(new Pages.UIUXPage(), false);
                    break;

                default:
                    break;
            }


        }
    }
}
