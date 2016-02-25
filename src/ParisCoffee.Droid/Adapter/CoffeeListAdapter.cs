using System;
using System.Collections.Generic;
using ParisCoffee.Core;
using System.Linq;
using Android.Widget;

namespace ParisCoffee.Droid
{
	public class CoffeeListAdapter// : RecyclerView.Adapter
	{

		readonly IEnumerable<CoffeeShop> _coffeeshops;

		public CoffeeListAdapter (IEnumerable<CoffeeShop> coffeeshops)
		{
			_coffeeshops = coffeeshops;
		}
		#region implemented abstract members of Adapter

//		public override void OnBindViewHolder (RecyclerView.ViewHolder holder, int position)
//		{
//			var item = _coffeeshops.ElementAt(position);
//
//			// Replace the contents of the view with that element
//			var h = holder as CoffeeShopViewHolder;
//			h.TextView.Text = item.Name;
//		}

//		public override RecyclerView.ViewHolder OnCreateViewHolder (Android.Views.ViewGroup parent, int viewType)
//		{
//			// set the view's size, margins, paddings and layout parameters
//			var tv = new TextView (parent.Context);
//			tv.SetWidth (200);
//
//			var vh = new CoffeeShopViewHolder (tv);
//			return vh;
//		}
//
//		public override int ItemCount {
//			get {
//				return _coffeeshops.Count ();
//			}
//		}

		#endregion



	}
}

