using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.After
{
	public class AdvancedMath : IMath,IBasicMath
	{
		public bool IsEven(params int[] nums)
		{
			bool isEven = nums.Sum() % 2 == 0;
			return isEven;
		}

		public bool IsOdd(params int[] nums)
		{
			bool isOdd = nums.Sum() % 2 != 0;
			return isOdd;
		}

		public int Max(params int[] nums)
		{
			return nums.Max();
		}

		public int Min(params int[] nums)
		{
			return nums.Min();
		}

		public int Sum(params int[] nums)
		{
			return nums.Sum();
		}
	}
}
