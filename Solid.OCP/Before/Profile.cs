using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Solid.OCP.Before
{
    public class Profile
    {

        List<object> lst = new();

        public void CreateProfile(object profileInfo, ProfileType type)
        {
            if (type == ProfileType.BASIC)
            {
                // write code for BASIC type

                lst.Add(new { profileInfo, type = ProfileType.BASIC.ToString() }); ;
            }
            else
            {
                // write code for JOB type 

                lst.Add(new { profileInfo, type = ProfileType.JOB.ToString() });
            }
        }

        public string ViewProfile()
        {
            return JsonSerializer.Serialize(lst);
        }

    }
}
