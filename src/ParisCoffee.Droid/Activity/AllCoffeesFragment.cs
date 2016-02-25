
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

namespace ParisCoffee.Droid
{
	public class AllCoffeesFragment : Android.Support.V4.App.Fragment
	{
		RecyclerView _recyclerView;

		protected ListViewModel ViewModel
		{
			get{ return App.ViewModelLocator.ListViewModel;}
		}

		public async override void OnCreate (Bundle savedInstanceState)
		{
			
			base.OnCreate (savedInstanceState);

		
			// Create your fragment here

		}

		public async override void OnViewCreated (View view, Bundle savedInstanceState)
		{
			base.OnViewCreated (view, savedInstanceState);
			await ViewModel.InitVm();
			_recyclerView.SetAdapter (new CoffeeListAdapter (ViewModel.CoffeeShops));


		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			var view = inflater.Inflate(Resource.Layout.AllCoffee, container, false);

			_recyclerView = view.FindViewById<RecyclerView> (Resource.Id.recyler);
			// use a linear layout manager
			var layoutManager = new LinearLayoutManager (this.Activity);
			_recyclerView.SetLayoutManager (layoutManager);


			return view;
			//return base.OnCreateView (inflater, container, savedInstanceState);
		}
	}
}

