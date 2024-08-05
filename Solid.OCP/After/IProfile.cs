using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.After
{
	public interface IProfile
	{
		public void AddProfile(object profileInfo);
		public string ViewProfile();
	}
}
