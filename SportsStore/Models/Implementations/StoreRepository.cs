using SportsStore.Models.Repositories;

namespace SportsStore.Models.Implementations
{
    public class StoreRepository : IStoreRepository
    {
        private StoreDbContext _ctx;

        public StoreRepository(StoreDbContext ctx)
        {
            this._ctx = ctx;
        }

        public IQueryable<Product> Products => _ctx.Products;

        public void CreateProduct(Product p)
        {
            _ctx.Add(p);
            _ctx.SaveChanges();
        }

        public void DeleteProduct(Product p)
        {
            _ctx.Remove(p);
            _ctx.SaveChanges();
        }

        public void SaveProduct(Product p)
        {
            _ctx.SaveChanges();
        }
    }
}
