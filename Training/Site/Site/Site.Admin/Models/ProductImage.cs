//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Site.Admin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductImage
    {
        public int ID { get; set; }
        public string ImgDescription { get; set; }
        public string ImgURL { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<int> ProductId { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
