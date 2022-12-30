using System;
using System.Collections.ObjectModel;

namespace MauiPerformance.ViewModels
{
	public class ListItem
	{
		public string Text { get; set; }
        public string SubText { get; set; }
        public string Image => "dotnet_bot.png";
	}

	public class MyListViewModel : PropertyChangedProvider, IMyView
    {
        public ObservableCollection<ListItem> Items { get; }

        public MyListViewModel()
		{
			Items = new ObservableCollection<ListItem>();

            Random random = new Random();
			int count = random.Next(25, 100);

			for (int i = 0; i < count; i++)
			{
				Items.Add(new ListItem { Text = Globals.IDs.UniqueID, SubText = Globals.IDs.UniqueID });
			}
        }
	}
}

