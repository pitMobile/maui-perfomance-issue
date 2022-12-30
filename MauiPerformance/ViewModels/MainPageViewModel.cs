using System;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace MauiPerformance.ViewModels
{
    public class MainPageViewModel : PropertyChangedProvider
    {
        public ObservableCollection<ContentViewModel> ContentViews { get; }

        public MainPageViewModel()
        {
            ContentViews = new ObservableCollection<ContentViewModel>();

            ContentViews.Add(GetTiles());
        }

        private ICommand _topBarCommand;
        public ICommand TopBarCommand => _topBarCommand ?? (_topBarCommand = new Command(OnTopBarButtonClicked));

        private void OnTopBarButtonClicked(object parameter)
        {
            var sParameter = parameter as string;

            switch (sParameter)
            {
                case "back":
                    if (ContentViews.Count > 1)
                    {
                        ContentViews.RemoveAt(ContentViews.Count - 1);
                    }
                    break;
                case "tile":
                    ContentViews.Add(GetTiles()); ;
                    break;
                case "entityGrid":
                case "entityStack":
                case "entityList":
                    var views = new List<IMyView>();
                    views.Add(new MyEntityViewModel(sParameter));
                    ContentViews.Add(new ContentViewModel(views));
                    break;
                case "list":
                    var views1 = new List<IMyView>();
                    views1.Add(new MyListViewModel());
                    ContentViews.Add(new ContentViewModel(views1));
                    break;
            }

        }

        private ContentViewModel GetTiles()
        {
            Random random = new Random();
            int count = random.Next(5, 10);
            var views = new List<IMyView>();
            var tiles = new List<IMyTile>();
            for (int i = 0; i < count; i++)
            {
                tiles.Add(new Tile(Globals.IDs.UniqueID));
            }
            views.Add(new TileViewModel(tiles));
            return new ContentViewModel(views);

        }

    }
}

