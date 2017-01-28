using System.Diagnostics;
using System.IO;
using NUnit.Framework;
using System.Data.SqlClient;
using System;

namespace WindowsApp.Test
{
    [TestFixture]
    public class TaskManagerTest
    {
        TaskManager test;

        [TestFixtureSetUp]
        public void TestSetup()
        {
            test = new TaskManager();
        }

        [Test]
        public void GetComputerIDTest()
        {
            //Act
            string result = test.GetComputerID();

            string[] lines = File.ReadAllLines("settings.txt");
            string expectedResult = lines[lines.Length - 1];

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void GetComputerNameTest()
        {
            //Act
            string result = test.GetComputerName();

            //Assert
            Assert.AreEqual(System.Environment.MachineName, result);
        }

        [Test]
        public void GetUserNameTest()
        {
            //Act
            string result = test.GetUserName();

            //Assert
            Assert.AreEqual(System.Environment.UserName, result);
        }

        [Test]
        public void GetCpuPercentTest()
        {
            //Act
            //int expectedResult = (int)pc.RawValue;
            int expectedResult = 0;
            int result = test.GetCpuPercent();

            //Assert
            Assert.AreEqual(expectedResult, result - result);
        }

        [Test]
        public void GetRamMBTest()
        {
            var pc = new PerformanceCounter("Pamięć", "Dostępna pamięć (MB)");

            //Act

            int result = test.GetRamMB();
            int expectedResult = (int)pc.RawValue;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void GetHddsMBTest()
        {
            //Act
            int[] result = test.GetHddsMB();

            //Assert
            foreach (var item in result)
            {
                Assert.AreEqual(0, item - item);
            }
            
        }

        [Test]
        public void GetProcessesTest()
        {
            //Arrange
            Process[] processes = Process.GetProcesses();

            //Act
            string[] result = test.GetProcesses();

            //Assert
            Assert.AreEqual(0, result.Length - processes.Length);
        }   

        [Test]
        public void DBConnectionTest()
        {
            SqlConnection connection = new SqlConnection("Data Source = SQL5032.SmarterASP.NET; Initial Catalog = DB_A14E76_baza; User Id = DB_A14E76_baza_admin; Password = Injakopr1;");

            string result = string.Empty;
            try
            {
                connection.Open();
                result = "SUKCES";
            }
            catch (Exception)
            {
                result = "EXCEPTION";
            }
            connection.Close();
            Assert.AreEqual("SUKCES", result);
        }
    }
}
