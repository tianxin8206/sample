using NetTopologySuite.Geometries;
using System;

namespace Acme.BookStore.AppStore.Dtos;

[Serializable]
public class CreateStoreDto
{
    public LineString? Tow { get; set; }

    public LineString? Three { get; set; }
}