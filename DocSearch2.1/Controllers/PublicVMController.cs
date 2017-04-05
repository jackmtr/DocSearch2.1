using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DocSearch2._1.Controllers
{
    public class PublicVMController : Controller
    {
        //will be grabbing data from 5 tables in db: Folder, Document, DocumentType, Category, and DocumentReference

        // dunno if need this: [AcceptVerbs(HttpVerbs.Get)]
        // GET: PublicVM
        public ActionResult Index()
        {
            return View();
        }
    }
}