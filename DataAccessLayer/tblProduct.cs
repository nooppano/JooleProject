//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblProduct
    {
        public int ProductID { get; set; }
        public int ManufactureID { get; set; }
        public int TypeID { get; set; }
        public int CatID { get; set; }
        public int SubCatID { get; set; }
        public int TechSpecFilterID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public Nullable<int> Airflow { get; set; }
        public Nullable<int> MaxPower { get; set; }
        public Nullable<int> SoundVolume { get; set; }
        public Nullable<int> FanDiameter { get; set; }
        public string ProductPhotoLink { get; set; }
        public string ProductSerial { get; set; }
    
        public virtual tblCategory tblCategory { get; set; }
        public virtual tblManufacture tblManufacture { get; set; }
        public virtual tblSubCategory tblSubCategory { get; set; }
        public virtual tblTechSpecFilter tblTechSpecFilter { get; set; }
        public virtual tblType tblType { get; set; }
    }
}
