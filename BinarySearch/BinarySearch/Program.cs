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
			Console.WriteLine(string.Format("{0}:{1}", nameof(searchItem), searchItem.ToString()));
			Console.WriteLine(string.Format("{0}; location:{1}", nameof(IntArrayBinarySearch), IntArrayBinarySearch(input, searchItem).ToString()));
			Console.Read();
		}

		public static int IntArrayBinarySearch(int[] data, int item)
		{
			int min = 0;
			int max = data.Length - 1;
			int iterationsMade = 0;
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
				if (min > max)
				{
					break;
				}
				iterationsMade++;
				Console.WriteLine(string.Format("{0}: {1}", nameof(iterationsMade), iterationsMade));
			}
			return -1;
		}
	}
}
