//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FairWorkk.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CatalogInputForm
    {
        public int ID { get; set; }
        public int CompanyId { get; set; }
        public int ProductGroupId { get; set; }
        public int CompanyProfileId { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual CompanyProfile CompanyProfile { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
    }
}
