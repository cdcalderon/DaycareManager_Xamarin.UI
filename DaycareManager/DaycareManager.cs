using System;

using Xamarin.Forms;

namespace DaycareManager
{
	public class App : Application
	{
		private static DaycareManagerService daycareManagerService;
		public App ()
		{
			// The root page of your application
//			MainPage = new ContentPage {
//				Content = new StackLayout {
//					VerticalOptions = LayoutOptions.Center,
//					Children = {
//						new Label {
//							XAlign = TextAlignment.Center,
//							Text = "Welcome to Xamarin Forms!"
//						}
//					}
//				}
//			};

			MainPage = new NavigationPage (new Kids ());
		}

		public static DaycareManagerService GetDaycareManagerService()
		{
			if (daycareManagerService == null)
			{
				daycareManagerService = new DaycareManagerService("http://daycaremanagerapi.azure-mobile.net/");
			}
			return daycareManagerService;
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

