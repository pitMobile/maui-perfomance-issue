using System;
using System.Collections.ObjectModel;


namespace MauiPerformance.ViewModels
{
    public class ContentViewModel
    {
        public ObservableCollection<IMyView> Views { get; }

        public ContentViewModel(List<IMyView> views)
        {
            Views = new ObservableCollection<IMyView>();
            foreach (var view in views)
            {
                Views.Add(view);
            }
        }
    }
}

