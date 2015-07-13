using System;
using Xamarin.Forms;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;

namespace DaycareManager
{
	public class KidsViewModel: ViewModelBase, INotifyPropertyChanged
	{
		public KidsViewModel (INavigation navigation) : base(navigation)
		{
		}
		public string kidName;
		public String KidName {
			get{ return kidName; }
			set{ kidName = value;}
		}

		private ObservableCollection<Kid> kidList;

		public ObservableCollection<Kid> Kids {
			get { return kidList; }
			set
			{
				kidList = value;
				NotifyPropertyChanged("Kids");
			}
		}

		public void Load()
		{
			//escape if already loaded
			if (Kids != null)
				return;

			IsLoading = true;
			App.GetDaycareManagerService().GetKids().ContinueWith((ta => {
				if(ta.Exception == null)
				{
					var kidResults = ta.Result;
					Kids = new ObservableCollection<Kid>(kidResults);
					KidName = kidResults.First().FirstName;

				}
				else
				{
					//alert to exception
				}
				IsLoading = false;
			}));

//			App.().GetMyItems().ContinueWith(gmit => {
//				if(gmit.Exception == null)
//				{
//					MyAuctionItems = new ObservableCollection<MyAuctionItem>(gmit.Result);
//				}
//				else
//				{
//					//Notify of error
//				}
//			});error
		}

	}
}

