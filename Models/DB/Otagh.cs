using System.Collections.Generic;

namespace Hotel2.Models
{
    public class Otagh
    {
        public int Id { get; set; }

        public string Zarfiat { get; set; }
        public virtual ICollection<JoziateHotel> JoziateHotels { get; set; }

    }
}