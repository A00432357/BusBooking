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

    public partial class creditcard_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public creditcard_type()
        {
            this.transactions = new HashSet<transaction>();
        }
    
        public int c_id { get; set; }

        [Display(Name = "Credit Card Name")]
        [Required(ErrorMessage = "required")]
        public string name { get; set; }

        [Display(Name = "Credit Card Number Starts with")]
        public string starts_with { get; set; }

        //[Range(100000000000, 9999999999999999999, ErrorMessage = "must be between 12 and 19 digits")]
        public decimal length { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transaction> transactions { get; set; }
    }
}
