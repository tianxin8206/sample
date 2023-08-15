using NetTopologySuite.Geometries;
using System;

namespace Acme.BookStore.AppStore.Dtos;

[Serializable]
public class UpdateStoreDto
{
    public LineString? Tow { get; set; }

    public LineString? Three { get; set; }
}