using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolektifHouse.DAL.Entity
{
    public class BlogPost
    {

        [Key]
        public int Id { get; set; }
        public string Picture { get; set; }
        public string Text { get; set; }
        public string Header { get; set; }
        public int MemberId { get; set; }
        public DateTime UploadDate { get; set; }

    }
}
