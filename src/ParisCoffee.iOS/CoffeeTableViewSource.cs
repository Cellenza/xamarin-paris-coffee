using System;
using UIKit;
using System.Collections.Generic;
using ParisCoffee.Core;
using System.Linq;

namespace ParisCoffee.iOS
{
	public class CoffeeTableViewSource : UITableViewSource
	{
		const string cellIdentifier = "coffee-shop-cell";

		private IEnumerable<CoffeeShop> _coffeshops;

		public CoffeeTableViewSource (IEnumerable<CoffeeShop> coffeshops)
		{
			_coffeshops = coffeshops;
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (cellIdentifier);
			var coffeeshop = _coffeshops.ElementAt (indexPath.Row);

			if (cell == null) {

				cell = new UITableViewCell (UITableViewCellStyle.Subtitle, cellIdentifier);
			}

			cell.TextLabel.Text = coffeeshop.Name;
			cell.DetailTextLabel.Text = coffeeshop.Address;

			return cell;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return _coffeshops.Count ();
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}
	}
}

