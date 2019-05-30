using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryRepository:RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFacotry): base(dbFacotry)
        {
            
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}
