using Acme.BookStore.AppStore;
using Acme.BookStore.AppStore.Dtos;
using AutoMapper;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Store, StoreDto>();
        CreateMap<CreateStoreDto, Store>(MemberList.Source);
        CreateMap<UpdateStoreDto, Store>(MemberList.Source);
    }
}
