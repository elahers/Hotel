namespace Hotel2.Models
{
    public class TasvireHotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdHotel { get; set; }
        public bool Tasvir { get; set; }
        public virtual Hotel Hotels { get; set; }
    }
}