//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WatermentWebSCADA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class equipments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public equipments()
        {
            this.alarms = new HashSet<alarms>();
            this.measurements = new HashSet<measurements>();
        }
    
        public int Id { get; set; }
        public string Tag { get; set; }
        public string SIUnits { get; set; }
        public string Description { get; set; }
        public string TypeSpecification { get; set; }
        public Nullable<System.DateTime> LastCalibrated { get; set; }
        public Nullable<System.DateTime> InstallDate { get; set; }
        public string Manufacturer { get; set; }
        public int facilities_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alarms> alarms { get; set; }
        public virtual facilities facilities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<measurements> measurements { get; set; }
    }
}
