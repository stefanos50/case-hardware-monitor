using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Management;

using System.Threading;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;
using OpenHardwareMonitor.Hardware;

namespace CaseHardwareMonitor
{
    public partial class main_form : Form
    {
        List<float?> sensors = new List<float?>();
        public main_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                sensors.Clear();
                sensors = GetSystemInfo();

                int cpu_usage_percentage = (int)sensors[0];
                cpu_usage_progress.Value = cpu_usage_percentage;
                cpu_usage_progress.Text = cpu_usage_percentage.ToString();
                if(cpu_usage_percentage <= 50)
                {
                    cpu_usage_progress.ProgressColor = Color.LimeGreen;
                }else if(cpu_usage_percentage <= 75)
                {
                    cpu_usage_progress.ProgressColor = Color.DarkOrange;
                }else if(cpu_usage_percentage > 75)
                {
                    cpu_usage_progress.ProgressColor = Color.Crimson;
                }


                int cpu_temp_percentage = (int)sensors[2];
                cpu_temperature.Value = cpu_temp_percentage;
                cpu_temperature.Text = cpu_temp_percentage.ToString();
                if (cpu_temp_percentage <= 50)
                {
                    cpu_temperature.ProgressColor = Color.LimeGreen;
                }
                else if (cpu_temp_percentage <= 75)
                {
                    cpu_temperature.ProgressColor = Color.DarkOrange;
                }
                else if (cpu_temp_percentage > 75)
                {
                    cpu_temperature.ProgressColor = Color.Crimson;
                }

                int gpu_temp_percentage = (int)sensors[4];
                gpu_temp_progress.Value = gpu_temp_percentage;
                gpu_temp_progress.Text = gpu_temp_percentage.ToString();
                if (gpu_temp_percentage <= 50)
                {
                    gpu_temp_progress.ProgressColor = Color.LimeGreen;
                }
                else if (gpu_temp_percentage <= 75)
                {
                    gpu_temp_progress.ProgressColor = Color.DarkOrange;
                }
                else if (gpu_temp_percentage > 75)
                {
                    gpu_temp_progress.ProgressColor = Color.Crimson;
                }

                int gpu_usage_percentage = (int)sensors[6];
                gpu_usage_progress.Value = gpu_usage_percentage;
                gpu_usage_progress.Text = gpu_usage_percentage.ToString();
                if (gpu_usage_percentage <= 50)
                {
                    gpu_usage_progress.ProgressColor = Color.LimeGreen;
                }
                else if (gpu_usage_percentage <= 75)
                {
                    gpu_usage_progress.ProgressColor = Color.DarkOrange;
                }
                else if (gpu_usage_percentage > 75)
                {
                    gpu_usage_progress.ProgressColor = Color.Crimson;
                }

                int ram_usage_percentage = (int)sensors[9];           
                ram_usage_progress.Value = ram_usage_percentage;
                ram_usage_progress.Text = ram_usage_percentage.ToString();
                if (ram_usage_percentage <= 50)
                {
                    ram_usage_progress.ProgressColor = Color.LimeGreen;
                }
                else if (ram_usage_percentage <= 75)
                {
                    ram_usage_progress.ProgressColor = Color.DarkOrange;
                }
                else if (ram_usage_percentage > 75)
                {
                    ram_usage_progress.ProgressColor = Color.Crimson;
                }

                core_clock_label.Text = ((int)sensors[5]).ToString()+" MHz";
                gpu_power_label.Text = string.Format("{0:F2}", sensors[8]) + " W";

                cpu_core_clock_label.Text = string.Format("{0:F1}", sensors[3]) + " MHz";
                cpu_power_label.Text = string.Format("{0:F1}", sensors[1]) + " W";

                gpu_fans_label.Text = sensors[7].ToString() + " RPM";
            }
            catch(Exception)
            {
                return;
            }
            
        }
        string GetComponent(string class1, string s)
        {
            ManagementObjectSearcher MOS = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + class1);
            foreach (ManagementObject mj in MOS.Get())
            {
                return Convert.ToString(mj[s]);
            }
            return "Uknown";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Activity_Monitor_icon;
            CPU_NAME.Text = GetComponent("Win32_Processor", "Name");
            GPU_NAME.Text = GetComponent("Win32_VideoController", "Name");
            MEMORY_NAME.Text = GetComponent("Win32_PhysicalMemory", "PartNumber");
            ram_gb_label.Text = "Total size: "+ Convert.ToInt32((Int64.Parse(GetComponent("Win32_ComputerSystem", "TotalPhysicalMemory")) / (1024 * 1024 * 1024))+1).ToString()+"GB";
            ram_speed_label.Text = "Ram speed: "+GetComponent("Win32_PhysicalMemory", "Speed")+" MHz";
            ram_manufacturer_label.Text = "Manufacturer: " + GetComponent("Win32_PhysicalMemory", "Manufacturer");
            if(GetComponent("Win32_PhysicalMemory", "MemoryType").Equals("0")){
                ram_type_label.Text = "Memory Type: DDR4 (" + GetComponent("Win32_PhysicalMemory", "MemoryType") +")";
            }
            else
            {
                ram_type_label.Text = "Memory Type: Type (" + GetComponent("Win32_PhysicalMemory", "MemoryType") + ")";
            }
        }

        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }

            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }

            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }

        public static List<float?> GetSystemInfo()
        {
            List<float?> sensors_info = new List<float?>();
            sensors_info.Clear();
            UpdateVisitor updateVisitor = new UpdateVisitor();
            OpenHardwareMonitor.Hardware.Computer computer = new OpenHardwareMonitor.Hardware.Computer();
            computer.Open();
            computer.CPUEnabled = true;
            computer.GPUEnabled = true;
            computer.RAMEnabled = true;
            computer.Accept(updateVisitor);
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature && computer.Hardware[i].Sensors[j].Name.Equals("CPU Package"))
                        {
                            sensors_info.Add(computer.Hardware[i].Sensors[j].Value);
                        }
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Clock && computer.Hardware[i].Sensors[j].Name.Equals("CPU Core #1"))
                        {
                            sensors_info.Add(computer.Hardware[i].Sensors[j].Value);
                        }
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Power && computer.Hardware[i].Sensors[j].Name.Equals("CPU Package"))
                        {
                            sensors_info.Add(computer.Hardware[i].Sensors[j].Value);
                        }
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Load && computer.Hardware[i].Sensors[j].Name.Equals("CPU Total"))
                        {
                            sensors_info.Add(computer.Hardware[i].Sensors[j].Value);
                        }

                    }
                }

                if (computer.Hardware[i].HardwareType == HardwareType.GpuNvidia)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Power)
                        {
                            sensors_info.Add(computer.Hardware[i].Sensors[j].Value);
                        }
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Clock && computer.Hardware[i].Sensors[j].Name.Equals("GPU Core"))
                        {
                            sensors_info.Add(computer.Hardware[i].Sensors[j].Value);
                        }
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            sensors_info.Add(computer.Hardware[i].Sensors[j].Value);
                        }

                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Load && computer.Hardware[i].Sensors[j].Name.Equals("GPU Core"))
                        {
                            sensors_info.Add(computer.Hardware[i].Sensors[j].Value);
                        }

                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Fan)
                        {
                            sensors_info.Add(computer.Hardware[i].Sensors[j].Value);
                        }

                    }
                }
                if (computer.Hardware[i].HardwareType == HardwareType.RAM)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Load)
                        {
                            sensors_info.Add(computer.Hardware[i].Sensors[j].Value);
                        }
                    }
                }

            }
                computer.Close();
                return sensors_info;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CPU_NAME_Click(object sender, EventArgs e)
        {

        }

        private void core_clock_label_Click(object sender, EventArgs e)
        {

        }

        private void night_mode_toggle_Click(object sender, EventArgs e)
        {
            if (night_mode_toggle.Checked)
            {
                night_mode_toggle.Checked = false;
            }
            else
            {
                night_mode_toggle.Checked = true;
            }
            night_mode_toggle.Invalidate();  // request a delayed Repaint by the normal MessageLoop system    
            night_mode_toggle.Update();      // forces Repaint of invalidated area 
            night_mode_toggle.Refresh();
            toggle_nightmode(night_mode_toggle.Checked);
        }

        private void toggle_nightmode(bool toggle)
        {
            if (toggle)
            {
                BackColor = Color.FromArgb(68, 68, 68);
                cpu_usage_progress.BackColor = Color.FromArgb(68, 68, 68);
                cpu_temperature.BackColor = Color.FromArgb(68, 68, 68);
                gpu_usage_progress.BackColor = Color.FromArgb(68, 68, 68);
                gpu_temp_progress.BackColor = Color.FromArgb(68, 68, 68);
                ram_usage_progress.BackColor = Color.FromArgb(68, 68, 68);
                cpu_usage_progress.InnerColor = Color.FromArgb(68, 68, 68);
                cpu_temperature.InnerColor = Color.FromArgb(68, 68, 68);
                gpu_usage_progress.InnerColor = Color.FromArgb(68, 68, 68);
                gpu_temp_progress.InnerColor = Color.FromArgb(68, 68, 68);
                ram_usage_progress.InnerColor = Color.FromArgb(68, 68, 68);
                CPU_NAME.ForeColor = Color.White;
                GPU_NAME.ForeColor = Color.White;
                MEMORY_NAME.ForeColor = Color.White;

                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                label11.ForeColor = Color.White;

                cpu_core_clock_label.ForeColor = Color.White;
                cpu_power_label.ForeColor = Color.White;
                gpu_power_label.ForeColor = Color.White;
                gpu_fans_label.ForeColor = Color.White;
                core_clock_label.ForeColor = Color.White;

                ram_gb_label.ForeColor = Color.White;
                ram_manufacturer_label.ForeColor = Color.White;
                ram_speed_label.ForeColor = Color.White;
                ram_type_label.ForeColor = Color.White;

                cpu_usage_progress.ForeColor = Color.White;
                cpu_temperature.ForeColor = Color.White;
                gpu_usage_progress.ForeColor = Color.White;
                gpu_temp_progress.ForeColor = Color.White;
                ram_usage_progress.ForeColor = Color.White;

                cpu_usage_progress.SubscriptColor = Color.White;
                cpu_temperature.SubscriptColor = Color.White;
                gpu_usage_progress.SubscriptColor = Color.White;
                gpu_temp_progress.SubscriptColor = Color.White;
                ram_usage_progress.SubscriptColor = Color.White;

                cpu_usage_progress.OuterColor = Color.FromArgb(190, 190, 190);
                cpu_temperature.OuterColor = Color.FromArgb(190, 190, 190);
                gpu_usage_progress.OuterColor = Color.FromArgb(190, 190, 190);
                gpu_temp_progress.OuterColor = Color.FromArgb(190, 190, 190);
                ram_usage_progress.OuterColor = Color.FromArgb(190, 190, 190);
            }
            else
            {
                BackColor = Color.White;
                cpu_usage_progress.BackColor = Color.White;
                cpu_temperature.BackColor = Color.White;
                gpu_usage_progress.BackColor = Color.White;
                gpu_temp_progress.BackColor = Color.White;
                ram_usage_progress.BackColor = Color.White;
                cpu_usage_progress.InnerColor = Color.White;
                cpu_temperature.InnerColor = Color.White;
                gpu_usage_progress.InnerColor = Color.White;
                gpu_temp_progress.InnerColor = Color.White;
                ram_usage_progress.InnerColor = Color.White;
                CPU_NAME.ForeColor = Color.Black;
                GPU_NAME.ForeColor = Color.Black;
                MEMORY_NAME.ForeColor = Color.Black;

                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;

                cpu_core_clock_label.ForeColor = Color.Black;
                cpu_power_label.ForeColor = Color.Black;
                gpu_power_label.ForeColor = Color.Black;
                gpu_fans_label.ForeColor = Color.Black;
                core_clock_label.ForeColor = Color.Black;

                ram_gb_label.ForeColor = Color.Black;
                ram_manufacturer_label.ForeColor = Color.Black;
                ram_speed_label.ForeColor = Color.Black;
                ram_type_label.ForeColor = Color.Black;

                cpu_usage_progress.ForeColor = Color.FromArgb(64, 64, 64);
                cpu_temperature.ForeColor = Color.FromArgb(64, 64, 64);
                gpu_usage_progress.ForeColor = Color.FromArgb(64, 64, 64);
                gpu_temp_progress.ForeColor = Color.FromArgb(64, 64, 64);
                ram_usage_progress.ForeColor = Color.FromArgb(64, 64, 64);

                cpu_usage_progress.SubscriptColor = Color.FromArgb(64, 64, 64);
                cpu_temperature.SubscriptColor = Color.FromArgb(64, 64, 64);
                gpu_usage_progress.SubscriptColor = Color.FromArgb(64, 64, 64);
                gpu_temp_progress.SubscriptColor = Color.FromArgb(64, 64, 64);
                ram_usage_progress.SubscriptColor = Color.FromArgb(64, 64, 64);

                cpu_usage_progress.OuterColor = Color.FromArgb(64, 64, 64);
                cpu_temperature.OuterColor = Color.FromArgb(64, 64, 64);
                gpu_usage_progress.OuterColor = Color.FromArgb(64, 64, 64);
                gpu_temp_progress.OuterColor = Color.FromArgb(64, 64, 64);
                ram_usage_progress.OuterColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void night_mode_toggle_Load(object sender, EventArgs e)
        {

        }

        private void toggle1_Load(object sender, EventArgs e)
        {

        }
    }
}
