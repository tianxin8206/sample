using NetTopologySuite.Geometries;
using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.AppStore.Dtos;

[Serializable]
public class StoreDto : EntityDto<Guid>
{
    public LineString? Tow { get; set; }

    public LineString? Three { get; set; }
}