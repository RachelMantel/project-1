namespace Amusement_park
{
    public class Facilitie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NumVisitorsForDay { get; set; }

        public int MinimalAge { get; set; }

        public int NumofWorkers { get; set; }

        public bool Status { get; set;}

        public int RoundDuration { get; set; }
    }
}
