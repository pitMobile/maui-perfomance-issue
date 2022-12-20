using System;
namespace MauiPerformance
{
    public class IDController
    {
        private Random random = new Random();
        private string chars = "0123456789abcdefghijklmnopqurstuvwxyzABCDEFGHIJKLMNOPQURSTUVWXYZ";
        private int range;
        public IDController()
        {
            range = chars.Length - 1;
        }

        public string UniqueID
        {
            get
            {
                var str = "__";
                for (var i = 0; i < 25; i++)
                {
                    str += chars[random.Next(0, range)];
                }

                return str;
            }
        }

    }

    public static class Globals
	{
        public static IDController IDs = new IDController();
	}
}

