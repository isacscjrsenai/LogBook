﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBook.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAddStudent().Show();
        }

        private void diárioDeBordoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLogBook().Show();
        }
    }
}
