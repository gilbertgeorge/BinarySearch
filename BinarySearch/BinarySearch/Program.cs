using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
	class SearchProgram
	{
		static void Main(string[] args)
		{
			int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
			int searchItem = 12;
			Console.WriteLine(string.Format("Searching for item: {0}", searchItem.ToString()));
			Console.WriteLine(string.Format("Item found at location: {0}", IntArrayBinarySearch(input, searchItem).ToString()));
			//Console.WriteLine(string.Format("Item found at location: {0}", IntArrayTernarySearch(input, searchItem).ToString()));
			Console.Read();
		}

		public static int IntArrayBinarySearch(int[] data, int item)
		{
			int min = 0;
			int N = data.Length;
			int max = N - 1;
			int interationsMade = 0;
			while (min <= max)
			{
				int mid = (min + max) / 2;
				if (item > data[mid])
				{
					min = mid + 1;
				}
				else
				{
					max = mid - 1;
				}
				if (data[mid] == item)
				{
					return mid;
				}
				interationsMade++;
				Console.WriteLine(string.Format("{0}: {1}", nameof(interationsMade), interationsMade));
			}
			return -1;
		}

		public static int IntArrayTernarySearch(int[] data, int item)
		{
			int min = 0;
			int N = data.Length;
			int max = N - 1;
			int interationsMade = 0;
			while (min <= max)
			{
				int mid = (min + max) / 3;
				if (item > data[mid])
				{
					min = mid + 1;
				}
				else
				{
					max = mid - 1;
				}
				if (data[mid] == item)
				{
					return mid;
				}
				interationsMade++;
				Console.WriteLine(string.Format("{0}: {1}", nameof(interationsMade), interationsMade));
			}
			return -1;
		}
	}
}
