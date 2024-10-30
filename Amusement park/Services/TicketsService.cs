using Microsoft.AspNetCore.Mvc;

namespace Amusement_park.Services
{
    public class TicketsService
    {

        static List<Ticket> tickets = new List<Ticket>();

        public List<Ticket> Get()
        {
            return tickets;
        }

        public Ticket GetById(int id)
        {
            return tickets.FirstOrDefault(x => x.Id == id);
        }


        public ActionResult<bool> Add(Ticket ticket)
        {
            tickets.Add(ticket);
            return true;
        }

        public ActionResult<bool> Update(Ticket ticket)
        {
            for (int i = 0; i < tickets.Count; i++)
            {
                if (tickets[i].Id == ticket.Id)
                {
                    tickets[i] = ticket;
                    return true;
                }
            }
            return false;

        }

        public ActionResult<bool> Remove(int id)
        {
            return tickets.Remove(tickets.FirstOrDefault(x => x.Id == id));
        }

    }
}
