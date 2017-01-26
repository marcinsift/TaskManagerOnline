using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheckComputer
{
   
    public class Controler
    {
        Thread thread;
        Thread thread1;
        Thread thread2;
        Thread thread3;
        Model model = new Model();
        int z = 0;
        int j = 0;
        int i = 0;
        Form1 view;
        ComputerDetails view1;
        List<ComputerInformation> computers;
        public Controler(Form1 view)
        {
            this.view = view;
        }
        public void AddViewToControler(ComputerDetails view1)
        {
            this.view1 = view1;
        }
        public void OnLoad()
        {

            computers=model.TakeDataAboutComputers();
            foreach(ComputerInformation computer in computers)
            {
                view.AddToCombo(computer.ComputerName);
            }
        }
        public void OnLoadDeatail()
        {
            ShowDeatils();
            view1.AddToRow();
            WatkiStart();


        }
        void WatkiStart()
        {
            thread = new Thread(() => AddToGrid());
            thread.Start();
            thread1 = new Thread(() => AddToChartCPU());
            thread1.Start();
            thread2 = new Thread(() => AddToChartRAM());
            thread2.Start();
            thread3 = new Thread(() => AddToChartHDD());
            thread3.Start();
        }
        void WatkiStop()
        {
            thread.Abort();
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();

        }
        void AddToGrid()
        {
            foreach (string data in model.process)
            {
                string[] tempTab = data.Split(';');
                int g = 0;
                foreach (string rekord in tempTab)
                {
                    view1.AddDatatoGrid(g, rekord);
                    g++;
                }
                Thread.Sleep(1000);
            }
            WatkiStop();
            ShowDeatils();
            WatkiStart();


        }
        void AddToChartHDD()
        {
            foreach (string data in model.hdd)
            {
                int value = 0;
                string datatemp = data.Replace("\"", "");
                datatemp = datatemp.Replace(";", "");
                try
                {
                    value = int.Parse(datatemp);
                }
                catch
                {

                }
                view1.SetHddChartValue(z, value);
                z++;
                Thread.Sleep(1000);
            }
        }
        void AddToChartRAM()
        {
            foreach (string data in model.ram)
            {
                view1.SetRamChartValue(j, int.Parse(data));
                j++;
                Thread.Sleep(1000);
            }
        }
        void AddToChartCPU()
        {
            foreach (string data in model.cpu)
            {
                view1.SetCpuChartValue(i, int.Parse(data));
                i++;
                Thread.Sleep(1000);
            }
               
        }
        public void SetDataFromComputer()
        {
            string value = view.IdCompterCombo;
            ComputerInformation computer = (from rekord in computers where rekord.ComputerName == value select rekord).FirstOrDefault();
            if (computer != null)
            {
                view.SetCpu(computer.CpuAvg);
                view.SetRam(computer.RamAvg);
                view.SetProcess(computer.ProcessAvg);
            }
        }

        public void ShowDeatils()
        {
            string id = (from rekord in computers where rekord.ComputerName == view.IdCompterCombo select rekord.Id).FirstOrDefault();
            if(!String.IsNullOrEmpty(id)) model.TakeAllDataAbotComputer(id);

        }
        public void ShowFormDetails()
        {
            ComputerDetails details = new ComputerDetails(this);
            details.FormClosed += Details_FormClosed;
            view.Enabled = false;
            details.Show();
        }

        private void Details_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            view.Enabled = true;
        }
    }


}
