using System;

namespace Hotel2.Models
{
    public class PardakhtHotel
    {
        public int Id { get; set; }

    
        public int HotelId { get; set; }

       
    
        public DateTime TarikhPardakht { get; set; }

       
     
   
        public string ShomarePeigiri { get; set; }

       
       
        public long Hazine { get; set; }

       
        public bool VaziatePardakht { get; set; }

      
        public string ShomareTarakonesh { get; set; }

       
       
        public string ShomareMarja { get; set; }

       
        public int ReserveId { get; set; }

       
        public virtual Hotel Hotel { get; set; }
       
        public virtual ReserveHotel ReserveHotel { get; set; }
    }
}