using Restoran_Project.Data;

namespace Restoran_Project.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<Chef> Chefs { get; set; } = [];
        public List<Customer> Customers { get; set; } = [];
    }
}
