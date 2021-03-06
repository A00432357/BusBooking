//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusBooking
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public schedule()
        {
            this.transactions = new HashSet<transaction>();
        }
    
        public int s_id { get; set; }

        [Display(Name = "Source")]
        [Required(ErrorMessage = "required")]
        public string source { get; set; }

        [Display(Name = "Destination")]
        [Required(ErrorMessage = "required")]
        public string destination { get; set; }

        [Display(Name = "Date of Travel")]
        [DataType(DataType.Date)]
        public string date { get; set; }

        [Display(Name = "Time of Travel")]
        public TimeSpan time { get; set; }

        [Display(Name = "Cost")]
        [Required(ErrorMessage = "required")]
        public int cost { get; set; }

        [Display(Name = "Bus Type")]
        public int bus_id { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
    
        public virtual bus bus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transaction> transactions { get; set; }
    }
}
