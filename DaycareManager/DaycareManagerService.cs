using System;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DaycareManager
{
	public class DaycareManagerService
	{
		private static MobileServiceClient daycareManagerClient;
		public DaycareManagerService (string serviceBaseUri)
		{
			daycareManagerClient = new MobileServiceClient (serviceBaseUri, "MXNHBNoczVWYQovypHIMlGTgemaiJB89");
		}

		public async Task<IEnumerable<Kid>>GetKids()
		{
			var tableKids = daycareManagerClient.GetTable<Kid>();
			return await tableKids.ReadAsync();
		}
	}
}

