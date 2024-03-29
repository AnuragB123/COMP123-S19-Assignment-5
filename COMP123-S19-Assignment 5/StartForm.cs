﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S19_Assignment_5
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            Program.forms[FormName.SELECT_FORM].Show();
            this.Hide();
        }
    }
}
