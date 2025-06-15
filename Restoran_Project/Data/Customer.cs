namespace Restoran_Project.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string ImageUrl { get; set; }
        public required string Comment { get; set; }
    }
}
