using System;
using System.Collections.ObjectModel;

namespace MauiPerformance.ViewModels
{
	public class MyEntityViewModel : PropertyChangedProvider, IMyView
    {
        public List<SectionViewModel> Sections { get; }

        public RowDefinitionCollection SectionRows { get; }
        public string TypeName { get; }

        public MyEntityViewModel(string typeName)
		{
            TypeName = typeName;
			Sections = new List<SectionViewModel>();
            Random random = new Random();
            int count = random.Next(2, 4);

            SectionRows = new RowDefinitionCollection();

            for (int i = 0; i < count; i++)
            {
                Sections.Add(new SectionViewModel("Header " + i, i));
                SectionRows.Add(new RowDefinition(new GridLength(1, GridUnitType.Auto)));
            }
        }
	}
}

