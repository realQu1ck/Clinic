//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clinic_Full.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Services
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Services()
        {
            this.Tbl_Doctors = new HashSet<Tbl_Doctors>();
            this.Tbl_VisitTime = new HashSet<Tbl_VisitTime>();
        }
    
        public int ID { get; set; }
        public string title { get; set; }
        public Nullable<int> SecID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Doctors> Tbl_Doctors { get; set; }
        public virtual Tbl_Section Tbl_Section { get; set; }
        public virtual Tbl_Section Tbl_Section1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_VisitTime> Tbl_VisitTime { get; set; }
    }
}
