using DocSearch2._1.Repositories;
using DocSearch2._1.ViewModels;
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

        private IPublicRepository repository = null;

        public PublicVMController() {
            this.repository = new PublicRepository();
        }
        // dunno if need this: [AcceptVerbs(HttpVerbs.Get)]
        // GET: PublicVM
        public ActionResult Index(string publicId)
        {
            IEnumerable<PublicVM> publicModel = repository.SelectAll(publicId);
            return View(publicModel);
        }
    }
}