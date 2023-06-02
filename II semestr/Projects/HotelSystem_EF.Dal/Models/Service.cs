﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelSystem_EF.Dal.Models
{
    public class Service
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServiceId { get; set; }

        [Required]
        public string ServiceName { get; set; } = null!;

        public string? Description { get; set; }

        [Required]
        public double Price { get; set; }


        //connection
        public ICollection<BookingService> BookingServices { get; set; } = new List<BookingService>();
    }
}
