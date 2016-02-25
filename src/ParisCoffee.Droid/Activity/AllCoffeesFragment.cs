
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using ParisCoffee.Core;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;

namespace ParisCoffee.Droid
{
	public class AllCoffeesFragment : Android.Support.V4.App.Fragment
	{
		ListView _listView;
		ObservableAdapter<CoffeeShop> _adapter;

		protected ListViewModel ViewModel
		{
			get{ return App.ViewModelLocator.ListViewModel;}
		}
			


		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			// Create your fragment here
		}
			
		public async override void OnViewCreated (View view, Bundle savedInstanceState)
		{
			base.OnViewCreated (view, savedInstanceState);
			await ViewModel.InitVm();

			_adapter = ViewModel.CoffeeShops.GetAdapter (GetCoffeeShopView);
			_listView.Adapter = (_adapter);
		}

		public ActivityBase CurrentActivity { get { return null; } }

		void CoffeeShopSelected (object sender, AdapterView.ItemClickEventArgs e)
		{
			var shop = ViewModel.CoffeeShops.ElementAt (e.Position);
			var intent = new Intent (Activity, typeof(DetailActivity));
			intent.PutExtra ("name", shop.Name);
			intent.PutExtra ("address", shop.Address);
			intent.PutExtra ("latitute", shop.Coordinates.Latitude);
			intent.PutExtra ("longitute", shop.Coordinates.Longitude);

			StartActivity (intent);
				
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate(Resource.Layout.AllCoffee, container, false);

			_listView = view.FindViewById<ListView> (Resource.Id.list);
			_listView.ItemClick += CoffeeShopSelected;

	
			return view;
		}

		private View GetCoffeeShopView(int position, CoffeeShop shop, View convertView)
		{
			View view = convertView ?? Activity.LayoutInflater.Inflate(Resource.Layout.RowCoffeeShop, null);

			var name = view.FindViewById<TextView>(Resource.Id.coffee_name);
			var address = view.FindViewById<TextView>(Resource.Id.coffee_address);

			name.Text = shop.Name;
			address.Text = shop.Address;
			return view;
		}
	}
}

