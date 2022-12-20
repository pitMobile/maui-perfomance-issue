using System;
using System.Collections.ObjectModel;

namespace MauiPerformance.ViewModels
{
	public class TileViewModel : PropertyChangedProvider, IMyView
	{
        public ObservableCollection<IMyTile> Tiles { get; }

		public TileViewModel(List<IMyTile> tiles)
		{
			Tiles = new ObservableCollection<IMyTile>();
			foreach (var tile in tiles)
			{
				Tiles.Add(tile);
			}
		}
	}
}

