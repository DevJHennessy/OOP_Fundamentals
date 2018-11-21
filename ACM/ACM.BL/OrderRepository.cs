using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order();

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2018, 11, 20, 16, 11, 20, TimeSpan.Zero);
            }
            return order;
        }

        public bool Save()
        {
            //Code that saves the defined customer.
            return true;
        }
    }
}
