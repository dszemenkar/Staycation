using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class HotelRoom
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Occupancy { get; set; }
        public double RegularRate { get; set; }
        public string Details { get; set; }
        public string SqMt { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
