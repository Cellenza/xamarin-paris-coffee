
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.PM;
using Android.Support.V4.App;
using ParisCoffee.Core;

namespace ParisCoffee.Droid
{
	[Activity (Label = "CoffeeListActivity", ScreenOrientation = ScreenOrientation.Portrait)]			
	public class CoffeeListActivity : FragmentActivity
	{
		protected ListViewModel ViewModel
		{
			get{ return App.ViewModelLocator.ListViewModel;}
		}

		protected async override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);


			SetContentView (Resource.Layout.CoffeeList);

			FragmentTabHost tabhost = FindViewById<FragmentTabHost> (Resource.Id.tabhost);

			tabhost.Setup (this, SupportFragmentManager, Resource.Id.tabcontent);



			tabhost.AddTab (
				tabhost.NewTabSpec ("all-coffee").SetIndicator ("All coffee", null),
				Java.Lang.Class.FromType (typeof(AllCoffeesFragment)), new Bundle());
	
			tabhost.AddTab (
				tabhost.NewTabSpec ("favorites").SetIndicator ("Favorites", null),
				Java.Lang.Class.FromType (typeof(FavoritesFragment)), new Bundle());
			
			await ViewModel.InitVm ();

			// Create your application here
		}
	}
}

