namespace Hotel_booking_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter the last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter the emial aaddress as ID.")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Please enter the phone number.")]
        public int PhoneNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
