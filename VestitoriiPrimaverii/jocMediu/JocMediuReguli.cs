﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VestitoriiPrimaverii.Resources;

namespace VestitoriiPrimaverii
{
    public partial class JocMediuReguli : Form
    {
        public JocMediuReguli()
        {
            InitializeComponent();
        }
        private bool finished = false;
        public JocMediuReguli(bool finished)
        {
            InitializeComponent();
            this.finished = finished;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            JocMediu1 f2 = new JocMediu1(this.finished);
            f2.Show();
        }

        private void JocMediuReguli_Activated(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Constants.pathReguliMediu;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Main_VisibleChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    }
}
