using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.After
{
	public interface IBasicMath
	{
		public int Max(params int[] nums);

		public int Min(params int[] nums);

		public int Sum(params int[] nums);
	}
}
