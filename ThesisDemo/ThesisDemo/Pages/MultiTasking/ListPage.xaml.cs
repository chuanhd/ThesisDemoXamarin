using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamvvm;

namespace ThesisDemo.Pages.MultiTasking
{
	public partial class ListPage : ContentPage, IBasePage<ListPageModel>
	{

        ListPageModel _model = new ListPageModel();

		public ListPage()
		{
			InitializeComponent();

            _model.Reload();
            ImagesListView.ItemsSource = _model.Items;

		}
	}
}
