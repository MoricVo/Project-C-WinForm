﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_GiaoDien
{
    public partial class FormFlash : Form
    {
        public FormFlash()
        {
            InitializeComponent();
            this.Opacity = 0.0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity = this.Opacity + 0.05;
            progressBar1.Value = progressBar1.Value + 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity - 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void FormFlash_Load(object sender, EventArgs e)
        {

        }
    }
}
