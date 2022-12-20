using System;
namespace MauiPerformance.ViewModels
{
	public class RowViewModel : PropertyChangedProvider
	{
		public string Label { get; set; }

		private string _value;
        public string Value { get => _value; set => SetProperty(ref _value, value); }

        public RowViewModel()
		{
			Label = Globals.IDs.UniqueID;
			_value = "EntryValue " + Globals.IDs.UniqueID;
        }
	}
}

