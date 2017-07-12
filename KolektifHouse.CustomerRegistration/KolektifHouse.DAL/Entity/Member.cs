using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolektifHouse.DAL.Entity
{
    public class Member
    {
        [Key]
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
