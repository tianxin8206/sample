using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Acme.BookStore.AppStore;
using Acme.BookStore.AppStore.Dtos;
using Acme.BookStore.Web.Pages.AppStore.Store.ViewModels;

namespace Acme.BookStore.Web.Pages.AppStore.Store;

public class CreateModalModel : BookStorePageModel
{
    [BindProperty]
    public CreateStoreViewModel ViewModel { get; set; }

    private readonly IStoreAppService _service;

    public CreateModalModel(IStoreAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateStoreViewModel, CreateStoreDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}