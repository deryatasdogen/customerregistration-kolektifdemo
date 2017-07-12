using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using KolektifHouse.DAL.Entity;

namespace KolektifHouse.DAL.Base
{
    public class KolektifInitializer
    {
        public static void Seed(KolektifContext context)
        {
            var members = new List<Member>
            {
            new Member{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01"),Telephone=("5343420898"),Email=("carson@hotmail.com")},
            new Member{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01"),Telephone=("5343420898"),Email=("carson@hotmail.com")},
            new Member{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01"),Telephone=("5343420898"),Email=("carson@hotmail.com")},
            new Member{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01"),Telephone=("5343420898"),Email=("carson@hotmail.com")},
            new Member{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01"),Telephone=("5343420898"),Email=("carson@hotmail.com")},
            new Member{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01"),Telephone=("5343420898"),Email=("carson@hotmail.com")},
            new Member{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01"),Telephone=("5343420898"),Email=("carson@hotmail.com")},
            new Member{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01"),Telephone=("5343420898"),Email=("carson@hotmail.com")}
            };

            members.ForEach(s => context.Members.Add(s));
            context.SaveChanges();
        }
    }
}
