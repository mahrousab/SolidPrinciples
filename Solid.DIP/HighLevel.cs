using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP
{
	public class HighLevel
	{
		private readonly ILevel level;

		public HighLevel(ILevel level)
        {
			this.level = level;
		}

		public string DisplayMessage()
		{
			return level.GetMessage();
		}
    }
}
