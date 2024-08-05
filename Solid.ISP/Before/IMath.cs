using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.Before
{
	public interface IMath
	{
		public int Sum(params int[] nums);

		public int Max(params int[] nums);
		public int Min(params int[] nums);

		public bool Even(params int[] nums);

		public bool Odd(params int[] nums);
	}
}
