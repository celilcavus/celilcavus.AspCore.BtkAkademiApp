namespace BtkAkademi.Models
{
    public static class Repository
    {
        private static List<Candidate> applications = new();
        public static IEnumerable<Candidate> Applications => applications;


        
        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }

        public static void Remove(Candidate candidate)
        {
            applications.Remove(candidate);
        }
        
        public static void Update(Candidate candidate)
        {
            
        }
    }
}
