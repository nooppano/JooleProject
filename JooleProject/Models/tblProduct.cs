//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JooleProject.Models
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
        public string Airflow { get; set; }
        public string MaxPower { get; set; }
        public string SoundVolume { get; set; }
        public string FanDiameter { get; set; }
    
        public virtual tblCategory tblCategory { get; set; }
        public virtual tblManufacture tblManufacture { get; set; }
        public virtual tblSubCategory tblSubCategory { get; set; }
        public virtual tblTechSpecFilter tblTechSpecFilter { get; set; }
        public virtual tblType tblType { get; set; }
    }
}