using System;
using System.Linq;
using System.Threading.Tasks;
using Acme.BookStore.Permissions;
using Acme.BookStore.AppStore.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.AppStore;


public class StoreAppService : CrudAppService<Store, StoreDto, Guid, StoreGetListInput, CreateStoreDto, UpdateStoreDto>,
    IStoreAppService
{
    protected override string GetPolicyName { get; set; } = BookStorePermissions.Store.Default;
    protected override string GetListPolicyName { get; set; } = BookStorePermissions.Store.Default;
    protected override string CreatePolicyName { get; set; } = BookStorePermissions.Store.Create;
    protected override string UpdatePolicyName { get; set; } = BookStorePermissions.Store.Update;
    protected override string DeletePolicyName { get; set; } = BookStorePermissions.Store.Delete;

    private readonly IStoreRepository _repository;

    public StoreAppService(IStoreRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<Store>> CreateFilteredQueryAsync(StoreGetListInput input)
    {
        // TODO: AbpHelper generated
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(input.Tow != null, x => x.Tow == input.Tow)
            .WhereIf(input.Three != null, x => x.Three == input.Three)
            ;
    }
}
