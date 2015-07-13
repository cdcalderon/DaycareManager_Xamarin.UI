using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace DaycareManager
{
	public class ViewModelBase : INotifyPropertyChanged 
	{
		private INavigation nav;
		public ViewModelBase (INavigation navigation)
		{
			nav = navigation;
		}

		private bool loading;

		public bool IsLoading
		{
			get {  return loading;}
			set
			{
				loading = value;
				NotifyPropertyChanged ("IsLoading");
			}
		}

		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null) 
			{
				PropertyChanged (this, new PropertyChangedEventArgs(propertyName));
			}
		}
		#endregion

		public INavigation Navigation { get { return nav; }}

	}
}

