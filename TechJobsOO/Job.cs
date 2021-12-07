using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency)
        {
            Id = nextId;
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
            nextId++;
        }

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"\nID: {Id}\n" +
                $"Name: {Name}\n" +
                $"Employer: {EmployerName.Id}: {EmployerName}\n" +
                $"Location: {EmployerLocation.Id}: {EmployerLocation}\n" +
                $"Position Type: {JobType.Id}: {JobType}\n" +
                $"Core Competency: {JobCoreCompetency.Id}: {JobCoreCompetency}\n";
        }

        // TODO: Add the two necessary constructors.



        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
