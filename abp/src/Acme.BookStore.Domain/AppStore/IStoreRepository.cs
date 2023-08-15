using System;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.AppStore;

public interface IStoreRepository : IRepository<Store, Guid>
{
}
