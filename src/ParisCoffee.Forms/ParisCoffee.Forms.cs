using System;

using Xamarin.Forms;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight.Ioc;

namespace ParisCoffee.Forms
{
	public class App : Application
	{

		public IViewModelLocator ViewModelLocator {get; private set;}

		public INavigationService NavigationService { get; private set; }

		public App ()
		{
			InitIoc ();

			MainPage = new NavigationPage(new Landing());
		}


		private void InitIoc()
		{
			this.ViewModelLocator = DependencyService.Get<IViewModelLocator>();
			SimpleIoc.Default.Register<INavigationService> (() => this.ViewModelLocator.InitializeNavigationService ());

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

