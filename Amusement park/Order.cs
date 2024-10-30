using System.Collections.Generic;

namespace Amusement_park
{
    public class Order
    {

        public int Id { get; set; }

        public int TicketId { get; set; }

        public string CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public int FinallPrice { get; set; }

        public string PaymentMethod { get; set; }

        public int Quantity { get; set; }
    }
}
