using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Acme.BookStore.AppStore
{
    public class Store : AggregateRoot<Guid>
    {
        public LineString? Tow { get; set; }

        public LineString? Three { get; set; }

    protected Store()
    {
    }

    public Store(
        Guid id,
        LineString? tow,
        LineString? three
    ) : base(id)
    {
        Tow = tow;
        Three = three;
    }
    }
}
