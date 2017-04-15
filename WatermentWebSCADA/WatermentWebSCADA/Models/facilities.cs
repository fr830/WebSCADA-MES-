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
    
    public partial class facilities
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public facilities()
        {
            this.equipments = new HashSet<equipments>();
            this.maintenance = new HashSet<maintenance>();
            this.users_has_facilities = new HashSet<users_has_facilities>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string IP { get; set; }
        public string Domain { get; set; }
        public Nullable<int> locations_Id { get; set; }
        public Nullable<int> locations_countries_Id { get; set; }
        public Nullable<int> locations_countries_continents_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<equipments> equipments { get; set; }
        public virtual locations locations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<maintenance> maintenance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<users_has_facilities> users_has_facilities { get; set; }
    }
}
