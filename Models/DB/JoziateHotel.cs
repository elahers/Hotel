using System.Collections.Generic;

namespace Hotel2.Models
{
    public class JoziateHotel
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int ZarfiatOtagh { get; set; }
        public int TedadTakht { get; set; }
        public string Name { get; set; }
        public int TedadSetare { get; set; }
        public int Tedad { get; set; }
        public int OstanId { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual Otagh Otaghs { get; set; }
        public virtual ICollection<TedadTakht> TedadTakhts { get; set; }

        public virtual ICollection<TedadSetare> TedadSetares { get; set; }




    }
}