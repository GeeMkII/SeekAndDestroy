﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.App.Warehouse.Queries.GetAllWareHouses
{
    public class GetAllWareHousesQuery : IRequest<IEnumerable<WarehouseDto>>
    {
    }
}