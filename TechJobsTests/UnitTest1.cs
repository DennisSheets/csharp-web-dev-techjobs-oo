using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class UnitTest1
    {
        Job job1;
        Job job2;
        Job job3;
        Job job4;
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
        public void Test01()
        {
            Assert.AreEqual(1,job1.Id);
            Assert.AreEqual(2,job2.Id); 
        }
        [TestMethod]
        public void Test02()
        {
            Assert.AreEqual(1, job2.Id - job1.Id);
            Assert.AreEqual(3, job1.Id);
            Assert.AreEqual(4, job2.Id);
            Assert.AreEqual(4, job2.Id);
        }
        [TestMethod]
        public void Test03ConstructorSetsAllValues()
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
        public void Test04ChecksForBlankValues()
        {
            Job job3 = new Job("Ice cream tester", 
                new Employer(""), 
                new Location("Home"), 
                new PositionType("UX"), 
                new CoreCompetency("Tasting ability"));
            Assert.AreEqual("Data not available", job3.EmployerName.ToString());
        }

        [TestMethod]
        public void Test05ConstructorSetsAllValues()
        {
            char[] chars = job1.ToString().ToCharArray();
            Assert.IsTrue(chars[0] == '\n');
            Assert.IsTrue(chars[chars.Length - 1] == '\n');
        }

        [TestMethod]
        public void Test06BlankNameEmployerLocationTypeAndCompetency()
        {
            Job job4 = new Job("",
                new Employer(""),
                new Location(""),
                new PositionType(""),
                new CoreCompetency(""));

            Assert.AreEqual("OOPS! This job does not seem to exist.", job4.ToString());
        }
    }
}
