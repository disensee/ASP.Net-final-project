using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareEFCore.Models
{
    public class EFBuildOrderRepository : IBuildOrderRepository
    {
        public HardwareDbContext context;

        public EFBuildOrderRepository(HardwareDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<BuildOrder> BuildOrders => context.BuildOrders.Include(bo => bo.Lines).ThenInclude(l => l.Drive);

        public void SaveBuildOrder(BuildOrder buildOrder)
        {
            context.AttachRange(buildOrder.Lines.Select(l => l.Drive));
            if(buildOrder.BuildOrderId == 0)
            {
                context.BuildOrders.Add(buildOrder);
            }
            context.SaveChanges();
        }
    }
}
