using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _171180038_ayse_karatas
{
    public partial class Form_Processes : Form
    {
        Process[] processes;
        public Form_Processes()
        {
            InitializeComponent();
        }

        private void Form_Processes_Load(object sender, EventArgs e)
        {
            RefreshAndAddProcess();
        }

        private void menu_KillProcess_Click(object sender, EventArgs e)
        {
            try
            {
                string pName = "";
                foreach (Process p in processes)
                {
                    if (LstBox_Processes.SelectedItem.Equals(p.ProcessName))
                    {
                        pName = p.ProcessName;
                        p.Kill();
                    }
                }
                LstBox_MesageBox.Items.Add(pName + " Processi Öldürüldü");
                RefreshAndAddProcess();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void RefreshAndAddProcess()
        {
            LstBox_Processes.Items.Clear();
            processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                LstBox_Processes.Items.Add(p.ProcessName);
            }
            LstBox_Processes.ContextMenuStrip = null;
        }

        private void LstBox_Processes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstBox_Processes.ContextMenuStrip = menu_ProcessOperations;
        }

        private void menu_ThreadAmount_Click(object sender, EventArgs e)
        {
            string pName = "";
            int threadAmount = 0;
            foreach (Process p in processes)
            {
                if (LstBox_Processes.SelectedItem.Equals(p.ProcessName))
                {
                    pName = p.ProcessName;
                    threadAmount = p.Threads.Count;
                }
            }
            LstBox_MesageBox.Items.Add(pName + " Processi Thread Sayısı: " + threadAmount);
        }

        private void menu_MemoryAmount_Click(object sender, EventArgs e)
        {
            string pName = "";
            long memoryAmount = 0;
            foreach (Process p in processes)
            {
                if (LstBox_Processes.SelectedItem.Equals(p.ProcessName))
                {
                    pName = p.ProcessName;
                    memoryAmount = p.PagedSystemMemorySize64;
                }
            }
            LstBox_MesageBox.Items.Add(pName + " Processi Bellek Miktarı: " + memoryAmount + " KB");
        }

        PerformanceCounter cpu;
        private void menu_ProcessorPerc_Click(object sender, EventArgs e)
        {
            string pName = "";
            foreach (Process p in processes)
            {
                if (LstBox_Processes.SelectedItem.Equals(p.ProcessName))
                {
                    pName = p.ProcessName;
                    cpu = new PerformanceCounter("Process", "% Processor Time", pName, true);
                }
            }

            cpu.NextValue();
            Thread.Sleep(500);
            LstBox_MesageBox.Items.Add(pName + " Processi İşlemci Yüzdesi: %" + cpu.NextValue() / Environment.ProcessorCount);
        }

        private void LstBox_Processes_MouseDown(object sender, MouseEventArgs e)
        {
            LstBox_Processes.SelectedIndex = LstBox_Processes.IndexFromPoint(e.X, e.Y);
        }
    }
}
