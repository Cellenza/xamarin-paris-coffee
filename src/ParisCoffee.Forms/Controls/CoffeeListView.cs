using System;

using Xamarin.Forms;
using System.Windows.Input;

namespace ParisCoffee.Forms
{
	public class CoffeeListView  : Xamarin.Forms.ListView {

		public static BindableProperty ItemClickCommandProperty = BindableProperty.Create<CoffeeListView, ICommand>(x => x.ItemClickCommand, null);


		public CoffeeListView() {
			this.ItemTapped += this.OnItemTapped;
		}


		public ICommand ItemClickCommand {
			get { return (ICommand)this.GetValue(ItemClickCommandProperty); }
			set { this.SetValue(ItemClickCommandProperty, value); }
		}


		private void OnItemTapped(object sender, ItemTappedEventArgs e) {
			if (e.Item != null && this.ItemClickCommand != null && this.ItemClickCommand.CanExecute(e)) {
				this.ItemClickCommand.Execute(e.Item);
				this.SelectedItem = null;
			}
		}
	}
}


