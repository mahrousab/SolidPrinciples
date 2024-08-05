using Solid.OCP.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.After
{
	public class Profile
	{
		private readonly IProfile _profile;

		public Profile(IProfile profile)
        {
			_profile = profile;
		}

		public void AddProfile(object profileInfo)
		{
			_profile.AddProfile(profileInfo);
		}
		public string ViewProfile()
		{
			return _profile.ViewProfile();
		}
	}
}
