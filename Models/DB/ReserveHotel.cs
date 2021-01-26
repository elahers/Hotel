using System;
using System.Collections.Generic;

namespace Hotel2.Models
{
    public class ReserveHotel
    {
        public int ReserveId { get; set; }

       
        public int HotelId { get; set; }


        public int Gender { get; set; }


       
        public string Name { get; set; }


        public string Family { get; set; }


        public string Code { get; set; }


        public string Mobile { get; set; }

        public string Mail { get; set; }

        public int TedadNafarat { get; set; }

        public int TeadadOtaghh { get; set; }

        public DateTime TarikhVorod { get; set; }

        public DateTime TarikhKhoroj { get; set; }

        public long Hazine { get; set; }


        public bool Vaziat { get; set; }

        public int TedadRoz { get; set; }

        public string Ip { get; set; }

        public virtual Hotel Hotel { get; set; }

        public virtual ICollection<PardakhtHotel> PardakhtHotels { get; set; }

    }
}