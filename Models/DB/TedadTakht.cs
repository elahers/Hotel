using System.Collections.Generic;

namespace Hotel2.Models
{
    public class TedadTakht
    {
        public int Id { get; set; }
        public string TedadTakhtName { get; set; }
        public virtual ICollection<JoziateHotel> JoziateHotels { get; set; }
    }
}