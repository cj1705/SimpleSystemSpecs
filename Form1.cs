using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SImpleSystemSpecs
{
    public partial class Form1 : Form
    {
        motherboard Motherboard = new motherboard();
        ram Ram = new ram();
        cpu cpu = new cpu();
        gpu Gpu = new gpu();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public void LoadMotherboard()
        {
            mboard_maker.Text = "Board Maunfacturer : "+motherboard.Manufacturer;
            mboard_model.Text = "Board Model : " + motherboard.Model;
            mboard_serial.Text = "Serial Number : " + motherboard.SerialNumber;
        }
        public void LoadRam()
        {
            ram_maker.Text = "Memory Maunfacturer : " + Ram.Manufacturer;
            ram_speed.Text = "Memory Speed  : " + Ram.Speed + "Mhz";
            ram_serial.Text = "Memory Capacity : " + Ram.Capacity;
            
        }
        public void LoadCPU()
        {
            cpu_maker.Text = "CPU Maunfacturer : " + cpu.Manufacturer;
            cpu_model.Text = "CPU Model : " + cpu.Name;
            cpu_maxcore.Text = "Number of CPU Cores : " + cpu.NumberOfCores;
            cpu_logical.Text = "Number of Logical Processors : " + cpu.LogicalProcessors;
            cpu_l2.Text = "L2 Cache Size : " + cpu.L2CacheSize;
            cpu_level3.Text = "L3 Cache Size : " + cpu.L3CacheSize;
            if (cpu.Manufacturer == "GenuineIntel")
            {
                cpuimg.Image = Images.intel;
            }
            if (cpu.Manufacturer == "AuthenticAMD")
            {
                cpuimg.Image = Images.amd;
            }
        }
        public void LoadGPU()
        {
            gpu_name.Text = "GPU Name : " +Gpu.Name;
            gpu_mem.Text = "GPU Memory Size : " + Gpu.MemorySize;
            gpu_driver.Text = "GPU Driver Version : " + Gpu.DriverVersion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMotherboard();
            LoadRam();
            LoadCPU();
            LoadGPU();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void mboard_maker_Click(object sender, EventArgs e)
        {

        }

        private void cpu_maker_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void ram_maker_Click(object sender, EventArgs e)
        {

        }

        private void cpu_l3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void gpu_name_Click(object sender, EventArgs e)
        {

        }
    }
}
