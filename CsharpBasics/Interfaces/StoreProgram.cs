using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics.Interfaces
{
    public class StoreProgram
    {
        public void ProcessOrder()
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { Dateplaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }
}
