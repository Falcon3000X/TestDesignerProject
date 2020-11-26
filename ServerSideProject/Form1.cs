using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xml2CSharp;
using Group = Xml2CSharp.Group;

namespace ServerSideProject
{
    public partial class Form1 : Form
    {
        List<Xml2CSharp.Group> groups = new List<Xml2CSharp.Group>();
        List<User> users = new List<User>();

        public Form1()
        {
            InitializeComponent();

            User user = new User() { Login = "abc", Password = "1234", IsAdmin = true };
            User user1 = new User() { Login = "falcon", Password = "pass", IsAdmin = true };
            User user2 = new User() { Login = "123", Password = "abc", IsAdmin = true };

            Group group = new Group();

            group.Users = new List<User>();
            group.Users.Add(user);
            group.Users.Add(user2);

            Group group1 = new Group();
            group.Users = new List<User>();
            group.Users.Add(user2);

            groups.Add(group);
            groups.Add(group1);

            foreach(var i in groups)
            {
                foreach(var item in i.Users)
                {
                    listBoxUsers.Items.Add(item);
                }
                listBoxGroups.Items.Add(i);
            }

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

        private void buttonConfirmNewUser_Click(object sender, EventArgs e)
        {

            User user = new User();
            user.Login = textBoxUserLogin.Text;
            user.Password = textBoxUserPassword.Text;

            if (checkBoxAdmin.Checked)
                user.IsAdmin = true;
            else
                user.IsAdmin = false;




            groupBoxUser.Enabled = false;
        }
    }
}
