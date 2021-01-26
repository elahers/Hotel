using System.Collections.Generic;

namespace Hotel2.Models
{
    public class TedadSetare
    {
        public int Id { get; set; }
        public string TedadSetareName { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }

    }
}