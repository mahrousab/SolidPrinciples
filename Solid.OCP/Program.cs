// before using OCP 
/*
using Solid.OCP.Before;

Profile profile = new();

Tuple<string, int> basic = new Tuple<string, int>("john", 20);

profile.CreateProfile(basic,ProfileType.BASIC);

Tuple<string, int> job = new Tuple<string, int>("ellithy",15);

profile.CreateProfile(job,ProfileType.JOB);

profile.ViewProfile();
*/

// After using OSP 


using Solid.OCP.After;

Profile profile = new Profile(new JobProfile());

Tuple<string, int> basic = new Tuple<string, int>("John", 20);
profile.AddProfile(basic);
profile.ViewProfile();

