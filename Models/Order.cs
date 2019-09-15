namespace Hotel_booking_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int RoomId { get; set; }

        [Column("Check-inDate", TypeName = "date")]
        public DateTime Check_inDate { get; set; }

        [Column("Check-outDate", TypeName = "date")]
        public DateTime Check_outDate { get; set; }

        public double TotalPrice { get; set; }

        public string Comments { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Room Room { get; set; }
    }
}
