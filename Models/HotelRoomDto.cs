using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class HotelRoomDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a hotel room name.")]
        public string Name { get; set; }
        public int Occupancy { get; set; }
        public double RegularRate { get; set; }
        public string Details { get; set; }
        public string SqMt { get; set; }
    }
}
