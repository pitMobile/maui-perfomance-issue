using System;
using System.Collections.ObjectModel;

namespace MauiPerformance.ViewModels
{
	public class SectionViewModel : PropertyChangedProvider
	{
        public string Header { get; set; }

        public ObservableCollection<RowViewModel> Rows { get; }
        public SectionViewModel(string header)
		{
            Rows = new ObservableCollection<RowViewModel>();
            Header = header;

            Random random = new Random();
            int count = random.Next(6, 15);

            for (int i = 0; i < count; i++)
            {
                Rows.Add(new RowViewModel());
            }
        }
	}
}

