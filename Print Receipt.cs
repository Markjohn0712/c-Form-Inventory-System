﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG
{
    public partial class Print_Receipt : Form
    {
        public Print_Receipt()
        {
            InitializeComponent();
        }

        private void Print_Receipt_Load(object sender, EventArgs e)
        {

           

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
