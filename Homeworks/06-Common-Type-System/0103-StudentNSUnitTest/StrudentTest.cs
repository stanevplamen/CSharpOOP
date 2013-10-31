using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentsNS;
using StudentsNS.Enums;
using System.Collections.Generic;

namespace StudentsNSUnitTest
{
    [TestClass]
    public class StrudentTest
    {
        public static Student ivanka1 = new Student("Ivanka", "Ivanova", "Stoichkova", 188034567, "Sofia, 123 Stambolyisky str.",
                "+ 359 8887 342398", Univercity.SofiaUnivercity, Faculty.Medical, Specialty.Doctor);
        public static Student ivanka2 = new Student("Ivanka", "Ivanova", "Hristova", 188034567, "Varna, 12 Bulgaria str.",
            "+ 359 8877 445678", Univercity.TUVarna, Faculty.MachineEngineering, Specialty.MachineEngineer);
        public static Student ivanka3 = new Student("Ivanka", "Ivanova", "Hristova", 185144333, "Sofia, 33 Todor Alexandrov str.",
            "+ 359 8876 445678", Univercity.SofiaUnivercity, Faculty.Medical, Specialty.Doctor);

        [TestMethod]
        public void TestStudents1() /// == test
        {
            bool ivankasAreEqual = ivanka1 == ivanka2;
            Assert.AreEqual(true, ivankasAreEqual);
        }

        [TestMethod]
        public void TestStudents2() /// != test
        {
            bool ivankasAreEqual = ivanka1 == ivanka3;
            Assert.AreEqual(false, ivankasAreEqual);
        }

        [TestMethod]
        public void TestStudents3() /// clone test
        {
            Student ivanka4 = ivanka1.Clone();
            bool ivankasAreEqual = ivanka1 == ivanka4;
            Assert.AreEqual(true, ivankasAreEqual);
        }

        [TestMethod]
        public void TestStudents4() /// compare/sort test
        {
            Student ivanka4 = ivanka1.Clone();
            ivanka4.FirstName = "Ivaanka";
            ivanka4.MiddleName = "aFirst";
            ivanka4.LastName = "aFirst";
            List<Student> someStudents = new List<Student>() { ivanka1, ivanka2, ivanka3, ivanka4 };
            someStudents.Sort();

            Assert.AreEqual("aFirst", someStudents[0].LastName);
        }
    }
}
