using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using NetTopologySuite.Geometries;

namespace Acme.BookStore.Web.Pages.AppStore.Store;

public class IndexModel : BookStorePageModel
{
    public StoreFilterInput StoreFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class StoreFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "StoreTow")]
    public LineString? Tow { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "StoreThree")]
    public LineString? Three { get; set; }
}
