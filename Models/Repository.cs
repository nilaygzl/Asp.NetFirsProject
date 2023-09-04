namespace ngMVC1.Models
{
    public static class Repository
    {
        private static List<Candidate> applications = new List<Candidate>(); // ya da =den sonra sadece new(); yazılabilir.
        public static IEnumerable<Candidate> Applications => applications;
        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}
