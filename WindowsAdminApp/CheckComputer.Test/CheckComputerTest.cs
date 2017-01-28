using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CheckComputer;
using System.Diagnostics;

namespace CheckComputer.Test
{
    [TestFixture]
    class CheckComputerTest
    {
        Controler test;
        Form1 view;
        ComputerDetails view1;
        Model model = new Model();
        List<ComputerInformation> computers;

        [TestFixtureSetUp]
        public void TestSetup()
        {
            view = new Form1();
            test = new Controler(view);
            view1 = new ComputerDetails(test);
            test.AddViewToControler(view1);
            computers = model.TakeDataAboutComputers();
        }

        [Test]
        public void OnLoadTest()
        {
            test.OnLoad();
            var res = computers;
            if (res != null)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void OnLoadDeatailTest()
        {
            test.OnLoad();
            test.OnLoadDeatail();
            Assert.Pass();
        }

        [Test]
        public void SetDataFromComputerTest()
        {
            test.SetDataFromComputer();
            if (computers.FirstOrDefault().CpuAvg != null &&
                computers.FirstOrDefault().RamAvg != null &&
                computers.FirstOrDefault().ProcessAvg != null)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void ShowDeatilsTest()
        {
            test.OnLoad();

            string id = (from rekord in computers where rekord.ComputerName == "MARCINZWIZE7C74" select rekord.Id).FirstOrDefault();
            //if (!String.IsNullOrEmpty(id)) model.TakeAllDataAbotComputer(id);
            Assert.IsNotNull(id);
        }

        [Test]
        public void ShowFormDetailsTest()
        {
            test.OnLoad();
            test.ShowDeatils();
            test.ShowFormDetails();

            ComputerDetails details = new ComputerDetails(test);
            Assert.IsNotNull(details);
        }

        [Test]
        public void SprNazweKoputera()
        {
            test.OnLoad();
            var p = 0;
            foreach (var item in computers)
            {
                if(item.ComputerName == "MARCINZWIZE7C74")
                {
                    p = 1;
                    break;
                } 
            }

            if (p == 1)
                Assert.Pass();
            else
                Assert.Fail();
        }

    }
}
