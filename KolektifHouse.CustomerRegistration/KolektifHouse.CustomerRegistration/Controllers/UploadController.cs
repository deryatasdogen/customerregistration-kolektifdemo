using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace KolektifHouse.CustomerRegistration.Controllers
{
    public class UploadController : ApiController
    {
        // GET: Upload  
        public ActionResult UploadURL(string file)
        {
            string files = Path.GetFileName(file);
            string myStringWebResource = "";
            WebClient myWebClient = new WebClient();
            myStringWebResource = file;
            string path = Server.MapPath(_fileUploadPath + files);
            myWebClient.DownloadFile(myStringWebResource, path);
            string extFile = Server.MapPath(_fileUploadPath + files);
            return View();
        }
    }
}
