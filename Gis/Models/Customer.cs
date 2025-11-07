namespace Gis.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // <= дефолт
        public string City { get; set; } = string.Empty; // <= дефолт
    }
}
