﻿using System;
using System.Windows.Forms;

namespace AlphaverLauncherRecreation
{
    public partial class Popup : Form
    {
        public Popup(string text1, string text2, bool progressBar, bool button)
        {
            InitializeComponent();
            InitializeComponent();
            this.timer.Start();
            label1.Text = text1;
            label2.Text = text2;
            progressBar1.Visible = progressBar;
            button1.Visible = button;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(10);
            if (this.progressBar1.Value == 100)
            {
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
