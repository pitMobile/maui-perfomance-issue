using System;
using System.Collections.ObjectModel;

namespace MauiPerformance.ViewModels
{
	public class MyEntityViewModel : PropertyChangedProvider, IMyView
    {
        public ObservableCollection<SectionViewModel> Sections { get; }

        public MyEntityViewModel()
		{
			Sections = new ObservableCollection<SectionViewModel>();
            Random random = new Random();
            int count = random.Next(2, 4);

            for (int i = 0; i < count; i++)
            {
                Sections.Add(new SectionViewModel("Header " + i));
            }
        }
	}
}

