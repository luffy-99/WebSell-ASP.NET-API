using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class DbFacotry : Disposable, IDbFactory
    {
        private ShopSellDbContext dbContext;
        public ShopSellDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopSellDbContext());
        }
        protected override void DisposeCore()
        {
            if(dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
