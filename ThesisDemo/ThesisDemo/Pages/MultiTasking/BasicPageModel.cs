using System;
using Xamvvm;

namespace ThesisDemo.Pages.MultiTasking
{
	
	public class BasicPageModel : BasePageModel
	{
		public void Reload()
		{
			ImageUrl = Helpers.GetRandomImageUrl();
		}

		public string ImageUrl { get; set; }
	}
}
