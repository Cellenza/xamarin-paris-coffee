using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParisCoffee.Forms
{
	public partial class Landing : ContentPage
	{
		public Landing ()
		{
			InitializeComponent ();

			this.btnEnter.Clicked += (sender, e) => 
			{
			//	https://developer.xamarin.com/guides/xamarin-forms/getting-started/introduction-to-xamarin-forms/#Navigation
			};
		}
	}
}

