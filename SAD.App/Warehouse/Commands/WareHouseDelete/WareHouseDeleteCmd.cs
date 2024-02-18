using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.App.Warehouse.Commands.WareHouseDelete
{
    public class WareHouseDeleteCmd : SAD.Domain.Entities.Warehouse ,IRequest
    {
    }
}
