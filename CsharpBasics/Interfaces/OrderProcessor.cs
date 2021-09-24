using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics.Interfaces
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator shippingCalculator;
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            this.shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed");
            order.Shipment = new Shipment
            {
                Cost = shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
