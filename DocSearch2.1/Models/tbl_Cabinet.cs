//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DocSearch2._1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Cabinet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Cabinet()
        {
            this.tbl_DocumentType = new HashSet<tbl_DocumentType>();
            this.tbl_Folder = new HashSet<tbl_Folder>();
            this.tbl_Repository = new HashSet<tbl_Repository>();
            this.tbl_Security = new HashSet<tbl_Security>();
        }
    
        public int Cabinet_ID { get; set; }
        public string Name { get; set; }
        public string FolderType { get; set; }
        public int Security { get; set; }
        public int LastUser_ID { get; set; }
        public System.DateTime LastUser_DT { get; set; }
    
        public virtual tbl_User tbl_User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DocumentType> tbl_DocumentType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Folder> tbl_Folder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Repository> tbl_Repository { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Security> tbl_Security { get; set; }
    }
}