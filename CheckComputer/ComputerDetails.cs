using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckComputer
{
    public partial class ComputerDetails : Form
    {
        Controler controler;
        public ComputerDetails(Controler controler)
        {
            InitializeComponent();
            this.controler = controler;
            controler.AddViewToControler(this);
            
        }
        public void SetCpuChartValue(int x, int y)
        {
            this.Invoke(
                 new Action(() =>
                 {
                     ch_cpu.Series["Punkty"].Points.AddXY(x, y);
                 }));
        }
        public void SetRamChartValue(int x, int y)
        {
            this.Invoke(
                new Action(() =>
                {
                    ch_Ram.Series["Punkty"].Points.AddXY(x, y);
                }));
        }
        public void SetHddChartValue(int x, int y)
        {
            this.Invoke(
               new Action(() =>
               {
                   cb_hdd.Series["Punkty"].Points.AddXY(x, y);
               }));
        }
        private void ch_Ram_Click(object sender, EventArgs e)
        {
           
        }
        public void AddToRow()
        {
            dg_Process.Columns.Add("Procesy","Procesy");
            dg_Process.Rows.Add(350);


        }
        public void AddDatatoGrid(int index,string value)
        {
            dg_Process.Rows[index].Cells[0].Value = value;

        }

        private void ComputerDetails_Load(object sender, EventArgs e)
        {
            controler.OnLoadDeatail();
        }
    }
}
