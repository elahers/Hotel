using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel2.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Addres { get; set; }
        public long JoziateGheymat { get; set; }
        public DateTime ZamanShoro { get; set; }
        public DateTime ZamanPayan { get; set; }
        public bool Faal { get; set; }
        public string Tozihat { get; set; }
        public virtual ICollection<JoziateHotel> JoziateHotels { get; set; }
        public virtual ICollection<PardakhtHotel> PardakhtHotels { get; set; }
        public virtual ICollection<Nazarat> Nazarats { get; set; }
        public virtual ICollection<TasvireHotel> TasvireHotels { get; set; }
        public virtual ICollection<EmkanatHotel> EmkanatHotels { get; set; }
        public virtual ICollection<ReserveHotel> ReserveHotels { get; set; }

    }
}
