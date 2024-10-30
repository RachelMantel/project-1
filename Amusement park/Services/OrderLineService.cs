using Microsoft.AspNetCore.Mvc;

namespace Amusement_park.Services
{
    public class OrderLineService
    {
        static List<OrderLine> orderLines = new List<OrderLine>();

        public List<OrderLine> Get()
        {
            return orderLines;
        }

        public OrderLine GetById(int id)
        {
            return orderLines.FirstOrDefault(x => x.Id == id);
        }


        public ActionResult<bool> Add(OrderLine orderLine)
        {
            orderLines.Add(orderLine);
            return true;
        }

        public ActionResult<bool> Update(OrderLine orderLine)
        {
            for (int i = 0; i < orderLines.Count; i++)
            {
                if (orderLines[i].Id == orderLine.Id)
                {
                    orderLines[i] = orderLine;
                    return true;
                }
            }
            return false;

        }

        public ActionResult<bool> Remove(int id)
        {
            return orderLines.Remove(orderLines.FirstOrDefault(x => x.Id == id));
        }
    }
}
