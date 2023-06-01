namespace FringeSportsStore.Models.ViewModels
{
    public class ProductLsistViewModel
    {
        public IEnumerable<Product> Products { get; set; }
           = Enumerable.Empty<Product>();
        public PagingInfo PagingInfo { get; set; } = new();
    }
}
