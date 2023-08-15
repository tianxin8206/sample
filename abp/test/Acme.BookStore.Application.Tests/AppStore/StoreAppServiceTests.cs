using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Acme.BookStore.AppStore;

public class StoreAppServiceTests : BookStoreApplicationTestBase
{
    private readonly IStoreAppService _storeAppService;

    public StoreAppServiceTests()
    {
        _storeAppService = GetRequiredService<IStoreAppService>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        // Arrange

        // Act

        // Assert
    }
    */
}

