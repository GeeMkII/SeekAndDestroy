using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.App.Warehouse.Queries.GetWarHouseBySEO
{
    public class GetWarHouseBySeoQuery : IRequest<WarehouseDto>
    { 
        public string SeoName { get; set; }
            public GetWarHouseBySeoQuery(string seoName)
        {
            SeoName=seoName;
        }
    }
}
