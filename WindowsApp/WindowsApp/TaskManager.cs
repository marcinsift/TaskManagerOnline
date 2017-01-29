using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsApp
{
    public class TaskManager
    {
        private string id;
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        private List<PerformanceCounter> hddCounters;

        private Timer timer;


        public TaskManager()
        {
            InitializeID();
            InitializeCpuCounter();
            InitializeRamCounter();
            InitializeHddCounters();

            timer = new Timer();
            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        private void InitializeID()
        {
            string[] lines = File.ReadAllLines("settings.txt");
            if (lines.Length == 1)
            {
                id = Guid.NewGuid().ToString();
                File.AppendAllText("settings.txt", Environment.NewLine + id);
            }
            else
            {
                id = lines[1];
            }
        }

        private void InitializeCpuCounter()
        {
            cpuCounter = new PerformanceCounter();

            try
            {
                cpuCounter.CategoryName = "Processor";
                cpuCounter.CounterName = "% Processor Time";
                cpuCounter.InstanceName = "_Total";
                cpuCounter.NextValue();
            }
            catch 
            {
                cpuCounter.CategoryName = "Procesor";
                cpuCounter.CounterName = "Czas procesora (%)";
                cpuCounter.InstanceName = "_Total";
                cpuCounter.NextValue();
            }

        }

        private void InitializeRamCounter()
        {

            ramCounter = new PerformanceCounter();

            try
            {
                ramCounter.CategoryName = "Memory";
                ramCounter.CounterName = "% Committed Bytes In Use";
                ramCounter.NextValue();
            }
            catch 
            {
                ramCounter.CategoryName = "Pamięć";
                ramCounter.CounterName = "Dostępna pamięć (MB)";
                ramCounter.NextValue();
            }

        }

        private void InitializeHddCounters()
        {
            string[] drives = Environment.GetLogicalDrives();
            hddCounters = new List<PerformanceCounter>();
            for (int i = 0; i < drives.Length; i++)
            {
                PerformanceCounter counter = new PerformanceCounter();

                try
                {
                    counter.CategoryName = "LogicalDisk";
                    counter.CounterName = "% Free Space";
                    counter.InstanceName = drives[i].Substring(0, 2);
                    counter.NextValue();
                    hddCounters.Add(counter);
                }
                catch
                {
                    counter.CategoryName = "LogicalDisk";
                    counter.CounterName = "% Free Space";
                    counter.InstanceName = drives[i].Substring(0, 2);
                    counter.CategoryName = "Dysk logiczny";
                    counter.CounterName = "Wolne megabajty";
                }
            }
        }


        public string GetComputerID()
        {
            return id;
        }

        public string GetComputerName()
        {
            return Environment.MachineName;
        }

        public string GetUserName()
        {
            return Environment.UserName;
        }

        public int GetCpuPercent()
        {
            return (int)Math.Round(cpuCounter.NextValue(), 0);
        }

        public int GetRamMB()
        {
            return (int)Math.Round(ramCounter.NextValue(), 0);
        }

        public int[] GetHddsMB()
        {
            int[] tab = new int[hddCounters.Count];
            for (int i = 0; i < hddCounters.Count; i++)
            {
                tab[i] = (int)Math.Round(hddCounters[i].NextValue(), 0);
            }
            return tab;
        }

        public string[] GetProcesses()
        {
            Process[] processes = Process.GetProcesses();
            string[] tab = new string[processes.Length];
            for (int i = 0; i < processes.Length; i++)
            {
                tab[i] = processes[i].ProcessName;
            }
            return tab;
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            this.ConnectToWSDL(sender, e);
        }

        private void ConnectToWSDL(object sender, EventArgs e)
        {
            try
            {
                string Komputer_Id = "" + GetComputerID() + "";
                string Komputer_Nazwa = "" + GetComputerName() + "";
                string Uzytkownik_Nazwa = "" + GetUserName() + "";
                int Procesor_Procent = GetCpuPercent();
                int RAM_MB = GetRamMB();
                string HDD_MB = "";
                foreach (int hdd in GetHddsMB())
                {
                    HDD_MB += hdd + ";";
                }
                HDD_MB += "";
                string Procesy = "";
                foreach (string proces in GetProcesses())
                {
                    Procesy += proces + ";";
                }

                Console.WriteLine("Ropozczynam transmisje");
                ServiceReference1.ComputerPortClient wsdl = new ServiceReference1.ComputerPortClient();
                string sendData = "{\"id\":\"" + Komputer_Id + "\",\"cpu\":\"" + Procesor_Procent.ToString() + "\",\"computer_name\":\"" + Komputer_Nazwa + "\",\"user_name\":\"" + Uzytkownik_Nazwa + "\",\"ram_mb_used\":\"" + RAM_MB.ToString() + "\",\"hdd_mb_free\":\"" + HDD_MB + "\",\"processes\":\"" + Procesy + "\"}";
                string data = wsdl.addInformation(sendData);
                Console.WriteLine("Koniec transmisji");

            }
            catch
            {
                Console.WriteLine("Errors");
            }
        }


        private void ConnectToDatabase(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source = SQL5032.SmarterASP.NET; Initial Catalog = DB_A14E76_baza; User Id = DB_A14E76_baza_admin; Password = Injakopr1;");

                connection.Open();

                // test

                string Komputer_Id = "'" + GetComputerID() + "'";
                string Komputer_Nazwa = "'" + GetComputerName() + "'";
                string Uzytkownik_Nazwa = "'" + GetUserName() + "'";
                int Procesor_Procent = GetCpuPercent();
                int RAM_MB = GetRamMB();
                string HDD_MB = "'";
                foreach (int hdd in GetHddsMB())
                {
                    HDD_MB += hdd + ";";
                }
                HDD_MB += "'";
                string Procesy = "'";
                foreach (string proces in GetProcesses())
                {
                    Procesy += proces + ";";
                }
                Procesy += "'";
                DateTime czas = DateTime.Now;
                string Czas = "'" + czas.Year + "-" + czas.Month + "-" + czas.Day + " " + czas.Hour + ":" + czas.Minute + ":" + czas.Second + "'";

                string commandString = string.Format("INSERT INTO [Dane] ([Komputer_Id],[Komputer_Nazwa],[Uzytkownik_Nazwa],[Procesor_Procent],[RAM_MB],[HDD_MB],[Procesy],[Czas]) "
                                                    + "VALUES ({0},{1},{2},{3},{4},{5},{6},{7})", Komputer_Id, Komputer_Nazwa, Uzytkownik_Nazwa, Procesor_Procent, RAM_MB, HDD_MB, Procesy, Czas);

                SqlCommand command = new SqlCommand(commandString, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch
            {
                
            }
        }

    }
}
