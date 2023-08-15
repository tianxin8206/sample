using System;
using Acme.BookStore.AppStore.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.AppStore;


public interface IStoreAppService :
    ICrudAppService< 
        StoreDto, 
        Guid, 
        StoreGetListInput,
        CreateStoreDto,
        UpdateStoreDto>
{

}