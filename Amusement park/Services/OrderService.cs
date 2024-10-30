using Microsoft.AspNetCore.Mvc;

namespace Amusement_park.Services
{
    public class OrderService
    {
        static List<Order> orders = new List<Order>();

        public List<Order> Get()
        {
            return orders;
        }

        public Order GetById(int id)
        {
            return orders.FirstOrDefault(x => x.Id == id);
        }


        public ActionResult<bool> Add(Order order)
        {
            orders.Add(order);
            return true;
        }

        public ActionResult<bool> Update(Order order)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].Id == order.Id)
                {
                    orders[i] = order;
                    return true;
                }
            }
            return false;

        }

        public ActionResult<bool> Remove(int id)
        {
            return orders.Remove(orders.FirstOrDefault(x => x.Id == id));
        }
    }
}
