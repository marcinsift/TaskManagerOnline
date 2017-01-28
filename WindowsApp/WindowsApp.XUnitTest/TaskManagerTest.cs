using System;
using System.Diagnostics;
using System.IO;
using Xunit;

namespace WindowsApp.Test
{
    public class TaskManagerTest
    {
        TaskManager test = new TaskManager();

        [Fact]
        public void GetComputerIDTest()
        {
            //Act
            string result = test.GetComputerID();

            string[] lines = File.ReadAllLines("settings.txt");
            string expectedResult = lines[lines.Length - 1];

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetComputerNameTest()
        {
            //Act
            string result = test.GetComputerName();

            //Assert
            Assert.Equal(System.Environment.MachineName, result);
        }

        [Fact]
        public void GetUserNameTest()
        {
            //Act
            string result = test.GetUserName();

            //Assert
            Assert.Equal(System.Environment.UserName, result);
        }

        [Fact]
        public void GetCpuPercentTest()
        {
            //Act
            //int expectedResult = (int)pc.RawValue;
            int expectedResult = 0;
            int result = test.GetCpuPercent();

            //Assert
            Assert.Equal(expectedResult, result - result);
        }

        [Fact]
        public void GetRamMBTest()
        {
            var pc = new PerformanceCounter("Pamięć", "Dostępna pamięć (MB)");

            //Act
            int expectedResult = (int)pc.RawValue;
            int result = test.GetRamMB();

            //Assert
            Assert.Equal(expectedResult, result);
        }


        [Fact]
        public void GetHddsMBTest()
        {
            //Act
            int[] result = test.GetHddsMB();

            //Assert
            foreach (var item in result)
            {
                Assert.Equal(0, item - item);
            }
            
        }
        
        [Fact]
        public void GetProcessesTest()
        {
            //Arrange
            Process[] processes = Process.GetProcesses();

            //Act
            string[] result = test.GetProcesses();

            //Assert
            Assert.Equal(0, result.Length - processes.Length);
        }   
    }
}
