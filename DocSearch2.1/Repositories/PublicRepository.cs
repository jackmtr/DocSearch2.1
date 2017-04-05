﻿using DocSearch2._1.Models;
using DocSearch2._1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocSearch2._1.Repositories
{
    public class PublicRepository : IPublicRepository
    {
        //might need to decouple this VM repo from the dbcontext by creating more repos this VMrepo will grab from

        private WASEntities _db = null;

        public PublicRepository() {
            this._db = new WASEntities(); //dbcontext class
        }

        //add parameterized constructor

        

        public IEnumerable<PublicVM> SelectAll(string publicNumber) {

            List<PublicVM> PublicVMList = new List<PublicVM>();

            var documentList = (from d in _db.tbl_Document
                               join f in _db.tbl_Folder on d.Folder_ID equals f.Folder_ID
                               where d.Folder_ID == Int32.Parse(publicNumber)
                               join dr in _db.tbl_DocReference on d.Document_ID equals dr.Document_ID
                               join cab in _db.tbl_Cabinet on f.Cabinet_ID equals cab.Cabinet_ID
                               join dt in _db.tbl_DocumentType on cab.Cabinet_ID equals dt.Cabinet_ID
                               join cat in _db.tbl_Category on dt.Category_ID equals cat.Category_ID
                               select new {
                                   f.Folder_ID, d.Document_ID, dt.DocumentType_ID, DtName = dt.Name, d.Issue_DT, d.Description, cat.Category_ID, CatName = cat.Name , dr.Date1_DT
                               }).ToList();

            foreach (var item in documentList) {
                PublicVM objpvm = new PublicVM();

                objpvm.Folder_ID = item.Folder_ID;
                objpvm.Document_ID = item.Document_ID;
                objpvm.DocumentType_ID = item.DocumentType_ID;
                objpvm.DocumentTypeName = item.DtName;
                objpvm.IssueDate = item.Issue_DT;
                objpvm.Description = item.Description;
                objpvm.Category_ID = item.Category_ID;
                objpvm.CategoryName = item.CatName;
                objpvm.EffectiveDate = item.Date1_DT;

                PublicVMList.Add(objpvm);
            }
            return PublicVMList;
        }
    }
}