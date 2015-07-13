using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DaycareManager
{
	public partial class Kids 
	{
		public Kids ()
		{
			InitializeComponent ();
			this.BindingContext = new KidsViewModel (this.Navigation);
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			((KidsViewModel)BindingContext).Load ();
		}

		protected void Kid_Tapped(object sender, ItemTappedEventArgs e)
		{
//			Kid kid = e.Item as Kid;
//			Navigation.PushAsync(
//				new KidDetail(kid));
		}

//		protected void MyItem_Tapped(object sender, ItemTappedEventArgs e)
//		{
//			MyAuctionItem item = e.Item as MyAuctionItem;
//
//			var targetItem = new AuctionItem
//			{
//				Id = item.Id,
//				Name = item.Name,
//				Description = item.Description,
//				CurrentBid = item.CurrentBid
//			};
//
//			Navigation.PushAsync(new PlaceBid(targetItem));
//		}
	}
}

