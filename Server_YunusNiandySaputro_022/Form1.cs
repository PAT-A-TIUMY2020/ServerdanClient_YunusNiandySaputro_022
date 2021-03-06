﻿using ServiceMtk_P1_20180140022;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_YunusNiandySaputro_022
{
    public partial class Form1 : Form
    {
        ServiceHost hostObj = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                hostObj = new ServiceHost(typeof(Matematika));
                hostObj.Open();
                label2.Text = "Server ON";
                label3.Text = "Klik OFF untuk menonaktifkan server";
                button1.Enabled = false;
                button2.Enabled = true;
            }
            catch (Exception ex)
            {
                button2.Enabled = false;
                button1.Enabled = true;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                hostObj.Abort();
                label2.Text = "Server OFF";
                label3.Text = "Klik ON untuk menghidupkan server";
                button2.Enabled = false;
                button1.Enabled = true;
            }
            catch (Exception ex)
            {
                button1.Enabled = false;
                button2.Enabled = true;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
