using NetTopologySuite.Geometries;
using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Web.Pages.AppStore.Store.ViewModels;

public class EditStoreViewModel
{
    [Display(Name = "StoreTow")]
    public LineString? Tow { get; set; }

    [Display(Name = "StoreThree")]
    public LineString? Three { get; set; }
}
