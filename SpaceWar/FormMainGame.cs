﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpaceWar
{
    public partial class FormMainGame : Form
    {
        public FormMainGame()
        {
            InitializeComponent();
        }

        private void timerEnemy_Tick(object sender, EventArgs e)
        {
            pictureBoxEnemyShip.Top += 1;
        }
    }
}
