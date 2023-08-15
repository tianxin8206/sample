using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Acme.BookStore.AppStore;
using Acme.BookStore.AppStore.Dtos;
using Acme.BookStore.Web.Pages.AppStore.Store.ViewModels;

namespace Acme.BookStore.Web.Pages.AppStore.Store;

public class EditModalModel : BookStorePageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public EditStoreViewModel ViewModel { get; set; }

    private readonly IStoreAppService _service;

    public EditModalModel(IStoreAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<StoreDto, EditStoreViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<EditStoreViewModel, UpdateStoreDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}