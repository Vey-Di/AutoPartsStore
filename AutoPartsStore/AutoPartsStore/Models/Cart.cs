using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPartsStore.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public void AddItem(Part part, int quantity)
        {
            CartLine line = lineCollection
                .Where(x => x.Part.PartId == part.PartId)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Part = part,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(x => x.Part.Price * x.Quantity);
        }

        public void RemoveLine(Part part)
        {
            lineCollection.RemoveAll(x => x.Part.PartId == part.PartId);
        }

        public void Clear()
        {
            lineCollection.Clear();
        }
        public IEnumerable<CartLine> Lines => lineCollection;
    }
    public class CartLine
    {
        public Part Part { get; set; }
        public int Quantity { get; set; }
    }
}

