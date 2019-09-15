namespace Hotel_booking_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Room")]
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the description.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter the room type.")]
        public string RoomType { get; set; }

        [Required(ErrorMessage = "Please enter the price.")]
        public double Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
