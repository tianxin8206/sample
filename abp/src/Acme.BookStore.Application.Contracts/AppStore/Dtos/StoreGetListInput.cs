using NetTopologySuite.Geometries;
using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.AppStore.Dtos;

[Serializable]
public class StoreGetListInput : PagedAndSortedResultRequestDto
{
    public LineString? Tow { get; set; }

    public LineString? Three { get; set; }
}