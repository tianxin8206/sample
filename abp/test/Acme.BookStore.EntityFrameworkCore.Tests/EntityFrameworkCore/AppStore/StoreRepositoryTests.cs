using System;
using System.Threading.Tasks;
using Acme.BookStore.AppStore;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Acme.BookStore.EntityFrameworkCore.AppStore;

public class StoreRepositoryTests : BookStoreEntityFrameworkCoreTestBase
{
    private readonly IStoreRepository _storeRepository;

    public StoreRepositoryTests()
    {
        _storeRepository = GetRequiredService<IStoreRepository>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        await WithUnitOfWorkAsync(async () =>
        {
            // Arrange

            // Act

            //Assert
        });
    }
    */
}
