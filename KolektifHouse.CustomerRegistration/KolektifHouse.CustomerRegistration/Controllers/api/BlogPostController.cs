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
    public class BlogPostController : ApiController
    {
        private KolektifContext KolektifContext = new KolektifContext();
        public BlogPost Post(BlogPost BlogPost)
        {
            if (BlogPost.Id == 0)
            {
                KolektifContext.BlogPosts.Add(BlogPost);
                KolektifContext.SaveChanges();
            }
            else
            {
                BlogPost blogpost = KolektifContext.BlogPosts.FirstOrDefault(x => x.Id == BlogPost.Id);
                blogpost.Id = BlogPost.Id;
                blogpost.UploadDate = BlogPost.UploadDate;
                blogpost.Header = BlogPost.Header;
                blogpost.Text = BlogPost.Text;
                KolektifContext.SaveChanges();
            }
            return BlogPost;
        }
        public BlogPost Get(int Id)
        {
            return KolektifContext.BlogPosts.FirstOrDefault(x => x.Id == Id);
        }
        public bool Delete(int Id)
        {
            BlogPost blogpostToBeDeleted = KolektifContext.BlogPosts.FirstOrDefault(x => x.Id == Id);
            KolektifContext.BlogPosts.Remove(blogpostToBeDeleted);
            KolektifContext.SaveChanges();
            return true;
        }
    }
}
