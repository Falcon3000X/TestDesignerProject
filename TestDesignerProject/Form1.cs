﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDesignerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddTest_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();

            if (testForm.ShowDialog() == DialogResult.OK)
                testForm.Close();
           
        }
    }
}