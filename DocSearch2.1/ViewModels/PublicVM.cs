using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocSearch2._1.ViewModels
{
    public class PublicVM
    {
        //folder_id
        public int Folder_ID { get; set; } //tbl_Folder
        //document_id
        public int Document_ID { get; set; } //tbl_Document

        //documentType_id
        public int DocumentType_ID { get; set; } //tbl_Document or tbl_DocumentType

        public string DocumentTypeName { get; set; } //tbl_DocumentType as Name

        //document.issue_DT
        public System.DateTime IssueDate { get; set; } //tbl_Document

        //document.description
        public string Description { get; set; } //tbl_Document

        //category_id
        public int Category_ID { get; set; } //tbl_DocumentType or tbl_Category

        //category.name
        public string CategoryName { get; set; } //tbl_Category as Name

        //docReference.Date1_DT
        public System.DateTime EffectiveDate { get; set; } //tbl_DocReference as Date1_DT

        //file stuff properties need to be added
    }
}