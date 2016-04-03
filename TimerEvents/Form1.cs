﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerEvents
{
    public partial class Form1 : Form
    {
        Timer t;
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer_Shown(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);

            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 10;

            if (progressBar.Value >= 100) t.Stop();
        }
    }
}