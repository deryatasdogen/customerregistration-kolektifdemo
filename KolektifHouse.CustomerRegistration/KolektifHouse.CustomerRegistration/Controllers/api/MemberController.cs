using KolektifHouse.DAL.Base;
using KolektifHouse.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KolektifHouse.CustomerRegistration.Controllers.api
{
    public class MemberController : ApiController
    {
        private KolektifContext KolektifContext = new KolektifContext();
        public Member Post(Member Member)
        {
            if (Member.Id == 0)
            {
                KolektifContext.Members.Add(Member);
                KolektifContext.SaveChanges();
            }
            else
            {
                Member member = KolektifContext.Members.FirstOrDefault(x => x.Id == Member.Id);
                member.Email = Member.Email;
                member.EnrollmentDate = Member.EnrollmentDate;
                member.FirstMidName = Member.FirstMidName;
                member.LastName = Member.LastName;
                member.Telephone = Member.Telephone;
                KolektifContext.SaveChanges();
            }
            return Member;
        }
        public Member Get(int Id)
        {
            return KolektifContext.Members.FirstOrDefault(x => x.Id == Id);
        }
        public bool Delete(int Id)
        {
            Member memberToBeDeleted = KolektifContext.Members.FirstOrDefault(x => x.Id == Id);
            KolektifContext.Members.Remove(memberToBeDeleted);
            KolektifContext.SaveChanges();
            return true;
        }
    }
}
