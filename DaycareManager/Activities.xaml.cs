using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;

namespace DaycareManager
{
	public partial class Activities : ContentPage
	{
		public Activities ()
		{
			InitializeComponent ();
		}

		public async void Button_Clicked(object sender, EventArgs e)
		{
			MobileServiceClient client = new MobileServiceClient ("https://activitymanager.azure-mobile.net/");
			var activities = await client.GetTable<ToDoItem> ().ReadAsync ();
			myLabel.Text = activities.Last ().Text;
		}
	}
}