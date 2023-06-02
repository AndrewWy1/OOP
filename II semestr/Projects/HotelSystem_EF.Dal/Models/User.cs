﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelSystem_EF.Dal.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Username { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;


        //connections
        public ICollection<Review> Reviews { get; set; } = new List<Review>();

        public int BookingId { get; set; }
        public Booking Booking { get; set; } = null!;

        public int RoomId { get; set; }
        public Room RoomRoom { get; set; } = null!;

    }
}