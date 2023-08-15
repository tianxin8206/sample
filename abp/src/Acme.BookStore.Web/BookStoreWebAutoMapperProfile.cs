using Acme.BookStore.AppStore.Dtos;
using Acme.BookStore.Web.Pages.AppStore.Store.ViewModels;
using AutoMapper;

namespace Acme.BookStore.Web;

public class BookStoreWebAutoMapperProfile : Profile
{
    public BookStoreWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<StoreDto, EditStoreViewModel>();
        CreateMap<CreateStoreViewModel, CreateStoreDto>();
        CreateMap<EditStoreViewModel, UpdateStoreDto>();
    }
}
