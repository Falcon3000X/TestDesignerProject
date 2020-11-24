using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xml2CSharp;

namespace ServerSideProject
{
    public partial class Form1 : Form
    {
        List<Group> groups = new List<Group>();
        List<User> users = new List<User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            groupBoxUser.Enabled = true;
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            groupBoxGroup.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        #region SugarCode
        private void labelTest_MouseEnter(object sender, EventArgs e)
        {
            labelTest.ForeColor = Color.LightGreen;
          
        }

        private void labelTest_MouseLeave(object sender, EventArgs e)
        {
            labelTest.ForeColor = Color.Black;
         
        }

        private void labelUser_MouseLeave(object sender, EventArgs e)
        {
            labelUser.ForeColor = Color.Black;
        }

        private void labelUser_MouseEnter(object sender, EventArgs e)
        {
            labelUser.ForeColor = Color.LightGreen;
        }

        #endregion
    }
}
