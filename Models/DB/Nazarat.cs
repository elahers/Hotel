namespace Hotel2.Models
{
    public class Nazarat
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Matn { get; set; }

        public string TarikhSbat { get; set; }

        public int HotelId { get; set; }

        public string Mail { get; set; }

        public int Score { get; set; }

        public virtual Hotel Hotel { get; set; }
    }
}