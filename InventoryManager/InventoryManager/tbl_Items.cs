//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Items
    {
        public System.Guid Guid { get; set; }
        public System.Guid StoreGuid { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        public bool Legendary { get; set; }
        public bool BetterWithAge { get; set; }
        public byte[] Image { get; set; }
        public string ImageName { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateTrashed { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> DateSold { get; set; }
    
        public virtual tbl_Stores tbl_Stores { get; set; }
    }
}