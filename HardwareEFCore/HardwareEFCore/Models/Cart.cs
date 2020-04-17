using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareEFCore.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public virtual void AddItem(Drive drive, int quantity)
        {
            CartLine line = lineCollection
                .Where(d => d.Drive.DriveId == drive.DriveId)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Drive = drive,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Drive Drive) =>
            lineCollection.RemoveAll(l => l.Drive.DriveId == Drive.DriveId);

        public virtual void Clear() => lineCollection.Clear();

        public virtual IEnumerable<CartLine> Lines => lineCollection;
    }

    public class CartLine
    {
        public int CartLineId { get; set; }
        public Drive Drive { get; set; }
        public int Quantity { get; set; }
    }
}

