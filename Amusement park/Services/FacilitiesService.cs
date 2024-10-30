using Microsoft.AspNetCore.Mvc;

namespace Amusement_park.Services
{
    public class FacilitiesService
    {
        static List<Facilitie> facilities = new List<Facilitie> {
        new Facilitie
        {
            Id = 3,
            Name = "Playground",
            Description = "Kids playground with slides and swings.",
            NumVisitorsForDay = 400,
            MinimalAge = 3,
            NumofWorkers = 3,
            Status = true,
            RoundDuration = 20
        }
        };

        public List<Facilitie> Get()
        {
            return facilities;
        }

        public Facilitie GetById(int id)
        {
            return facilities.FirstOrDefault(x => x.Id == id);
        }


        public ActionResult<bool> Add(Facilitie facilitie)
        {
            facilities.Add(facilitie);
            return true;
        }

        public ActionResult<bool> Update(Facilitie facilitie)
        {
            for (int i = 0; i < facilities.Count; i++)
            {
                if (facilities[i].Id == facilitie.Id)
                {
                    facilities[i] = facilitie;
                    return true;
                }
            }
            return false;

        }

        public ActionResult<bool> Remove(int id)
        {
            return facilities.Remove(facilities.FirstOrDefault(x => x.Id == id));
        }

    }
}
