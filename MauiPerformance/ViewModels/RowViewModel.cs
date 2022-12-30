using System;
namespace MauiPerformance.ViewModels
{
	public class RowViewModel : PropertyChangedProvider
	{
		public int Row { get; }
		public string Label { get; set; }

		private string _value;
        public string Value { get => _value; set => SetProperty(ref _value, value); }

        public RowViewModel(int row)
		{
			Row = row;
			Label = Globals.IDs.UniqueID;
			_value = "EntryValue " + Globals.IDs.UniqueID;
        }
	}
}

