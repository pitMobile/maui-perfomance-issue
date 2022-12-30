using System;
using MauiPerformance.ViewModels;

namespace MauiPerformance
{
    public class ViewTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TileTemplate { get; set; }
        public DataTemplate ListTemplate { get; set; }
        public DataTemplate EntityTemplateStack { get; set; }
        public DataTemplate EntityTemplateGrid { get; set; }
        public DataTemplate EntityTemplateList { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is TileViewModel)
            {
                return TileTemplate;
            }
            if (item is MyListViewModel)
            {
                return ListTemplate;
            }
            if (item is MyEntityViewModel myEntityViewModel)
            {
                switch (myEntityViewModel.TypeName)
                {
                    case "entityGrid":
                        return EntityTemplateGrid;
                    case "entityStack":
                        return EntityTemplateStack;
                    case "entityList":
                        return EntityTemplateList;
                }
            }
            return null;
        }
    }
}

