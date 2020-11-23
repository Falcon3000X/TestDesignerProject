using System;
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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            textBoxQ2.Enabled = false;
            textBoxQ3.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString()=="2")
            {
                textBoxQ2.Enabled = true;
            }

            if (comboBox1.SelectedItem.ToString() == "3")
            {
                textBoxQ3.Enabled = true;
            }
        }

        private void buttonNewQuestion_Click(object sender, EventArgs e)
        {
            textBoxQ1.Text = "";
            textBoxQ2.Text = "";
            textBoxQ3.Text = "";

            textBoxQ2.Enabled = false;
            textBoxQ3.Enabled = false;

            textBoxQuestion.Text = "";

            textBoxTrueAnswer.Text = "";
        }

        private void buttonAddTest_Click(object sender, EventArgs e)
        {

        }

        private void buttonBackToTests_Click(object sender, EventArgs e)
        {

        }
    }
}
