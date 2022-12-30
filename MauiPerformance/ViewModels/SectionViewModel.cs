using System;
using System.Collections.ObjectModel;

namespace MauiPerformance.ViewModels
{
	public class SectionViewModel : List<RowViewModel>
	{
        public string Header { get; set; }
        public int Row { get; }
        public RowDefinitionCollection RowDefs { get; }


        //public List<RowViewModel> Rows { get; }
        public SectionViewModel(string header, int row)
		{
            Row = row;
            RowDefs = new RowDefinitionCollection();
            //Rows = new List<RowViewModel>();
            Header = header;

            Random random = new Random();
            int count = random.Next(6, 15);

            for (int i = 0; i < count; i++)
            {
                this.Add(new RowViewModel(i));
                RowDefs.Add(new RowDefinition(new GridLength(50)));
            }
        }
	}
}

