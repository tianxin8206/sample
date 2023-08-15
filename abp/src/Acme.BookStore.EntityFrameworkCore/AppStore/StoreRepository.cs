using System;
using System.Linq;
using System.Threading.Tasks;
using Acme.BookStore.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.BookStore.AppStore;

public class StoreRepository : EfCoreRepository<BookStoreDbContext, Store, Guid>, IStoreRepository
{
    public StoreRepository(IDbContextProvider<BookStoreDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Store>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}