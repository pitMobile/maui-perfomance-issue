using System;
using MauiPerformance.ViewModels;

namespace MauiPerformance
{
    public class ViewTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TileTemplate { get; set; }
        public DataTemplate ListTemplate { get; set; }
        public DataTemplate EntityTemplate { get; set; }

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
            if (item is MyEntityViewModel)
            {
                return EntityTemplate;
            }
            return null;
        }
    }
}

