using System;

namespace MyGCCollectClass
{
	class Garbage
	{
		int[] a = new int[100];
		string[] b = new string[100];
	}
	class MoreGarbage:Garbage
	{
		int[] c = new int[10000];
	}
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			MainClass.createGarbage (1000);
			Console.WriteLine ("Memory used before collection:"+GC.GetTotalMemory(false));
			// Collect garbage
			GC.Collect();
			Console.WriteLine ("Memory used after full collection:"+GC.GetTotalMemory(false));

		}

		static void createGarbage(int limit)
		{
			Garbage gb;
			for (int i = 0; i < limit; i++) 
			{
				gb = new Garbage ();
				//gb = new MoreGarbage ();
			}
		}

	}

}
