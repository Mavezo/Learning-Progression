using System;
namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length >= 2)
			{
				int count = 0;
				using (StreamReader reader = new StreamReader(args[0]))
				{
					string text = reader.ReadToEnd();
					int index = -1;
					while ((index = text.IndexOf(args[1], index+1)) != -1)
					{
						count++;
					}
					Console.WriteLine(count);
				}



			}
		}
	}
}