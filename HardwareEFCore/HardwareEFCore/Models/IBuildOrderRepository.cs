using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareEFCore.Models
{
    public interface IBuildOrderRepository
    {
        IEnumerable<BuildOrder> BuildOrders { get; }
        void SaveBuildOrder(BuildOrder buildOrder);
    }
}
