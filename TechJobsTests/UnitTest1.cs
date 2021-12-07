using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class UnitTest1
    {
        Job job1;
        Job job2;
        [TestInitialize]
        public void InstantiateJobs()
        {
            job1 = new Job("Product tester",
                            new Employer("ACME"),
                            new Location("Desert"),
                            new PositionType("Quality control"),
                            new CoreCompetency("Persistence"));
            job2 = new Job("Web Developer",
                            new Employer("LaunchCode"),
                            new Location("St. Louis"),
                            new PositionType("Front-end developer"),
                            new CoreCompetency("JavaScript"));
        }
        
        [TestMethod]
        public void TestA()
        {
            Assert.AreEqual(1,job1.Id);
            Assert.AreEqual(2,job2.Id); 
        }
        [TestMethod]
        public void TestB()
        {
            Assert.AreEqual(1, job2.Id - job1.Id);
            Assert.AreEqual(3, job1.Id);
            Assert.AreEqual(4, job2.Id);
            Assert.AreEqual(4, job2.Id);
        }
        [TestMethod]
        public void TestCConstructorSetsAllValues()
        {
            Assert.AreEqual(5, job1.Id);
            Assert.AreEqual(6, job2.Id);
            Assert.AreEqual("Product tester", job1.Name);
            Assert.AreEqual("Product tester", job1.Name);
            Assert.AreEqual("ACME", job1.EmployerName.Value);
            Assert.AreEqual("Desert", job1.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job1.JobType.Value);
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.Value);
        }
        [TestMethod]
        public void TestDConstructorSetsAllValues()
        {
            Assert.AreEqual(7, job1.Id);
            Assert.AreEqual(8, job2.Id);
            Assert.AreEqual("Product tester", job1.Name);
            Assert.AreEqual("ACME", job1.EmployerName.Value);
            Assert.AreEqual("Desert", job1.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job1.JobType.Value);
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.Value);
        }
    }
}
