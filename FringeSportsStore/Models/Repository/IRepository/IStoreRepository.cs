namespace FringeSportsStore.Models.Repository.IRepository
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
