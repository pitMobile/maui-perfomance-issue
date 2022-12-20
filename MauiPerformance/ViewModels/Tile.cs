using System;
namespace MauiPerformance.ViewModels
{
	public class Tile : IMyTile
	{
		public Tile(string text)
		{
			Text = text;
		}

        public string Text { get; }

        public string Image => "dotnet_bot.png";
    }
}

