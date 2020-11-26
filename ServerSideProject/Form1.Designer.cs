
namespace ServerSideProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUserToGroup = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.buttonTestToGroup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxTests = new System.Windows.Forms.ListBox();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUserLogin = new System.Windows.Forms.TextBox();
            this.buttonConfirmNewUser = new System.Windows.Forms.Button();
            this.groupBoxGroup = new System.Windows.Forms.GroupBox();
            this.buttonConfirmNewGroup = new System.Windows.Forms.Button();
            this.listBoxGroupTests = new System.Windows.Forms.ListBox();
            this.listBoxGroupUsers = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxMenu.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.Location = new System.Drawing.Point(43, 40);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(107, 23);
            this.buttonAddUser.TabIndex = 0;
            this.buttonAddUser.Text = "Add user";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGroup.Location = new System.Drawing.Point(43, 69);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(107, 23);
            this.buttonAddGroup.TabIndex = 1;
            this.buttonAddGroup.Text = "Create group";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(818, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Side";
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxMenu.Controls.Add(this.button1);
            this.groupBoxMenu.Controls.Add(this.buttonAddUser);
            this.groupBoxMenu.Controls.Add(this.buttonAddGroup);
            this.groupBoxMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxMenu.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(200, 184);
            this.groupBoxMenu.TabIndex = 3;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(43, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remove user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(994, 12);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(120, 186);
            this.listBoxUsers.TabIndex = 4;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(747, 52);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(120, 186);
            this.listBoxGroups.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(750, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Groups";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1004, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Users";
            // 
            // buttonUserToGroup
            // 
            this.buttonUserToGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserToGroup.Location = new System.Drawing.Point(890, 95);
            this.buttonUserToGroup.Name = "buttonUserToGroup";
            this.buttonUserToGroup.Size = new System.Drawing.Size(81, 23);
            this.buttonUserToGroup.TabIndex = 3;
            this.buttonUserToGroup.Text = "User to group";
            this.buttonUserToGroup.UseVisualStyleBackColor = true;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("MingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(888, 121);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(83, 32);
            this.labelUser.TabIndex = 8;
            this.labelUser.Text = "<---";
            this.labelUser.MouseEnter += new System.EventHandler(this.labelUser_MouseEnter);
            this.labelUser.MouseLeave += new System.EventHandler(this.labelUser_MouseLeave);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Font = new System.Drawing.Font("MingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTest.Location = new System.Drawing.Point(626, 164);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(83, 32);
            this.labelTest.TabIndex = 14;
            this.labelTest.Text = "--->";
            this.labelTest.MouseEnter += new System.EventHandler(this.labelTest_MouseEnter);
            this.labelTest.MouseLeave += new System.EventHandler(this.labelTest_MouseLeave);
            // 
            // buttonTestToGroup
            // 
            this.buttonTestToGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTestToGroup.Location = new System.Drawing.Point(628, 138);
            this.buttonTestToGroup.Name = "buttonTestToGroup";
            this.buttonTestToGroup.Size = new System.Drawing.Size(81, 23);
            this.buttonTestToGroup.TabIndex = 9;
            this.buttonTestToGroup.Text = "Test to group";
            this.buttonTestToGroup.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tests";
            // 
            // listBoxTests
            // 
            this.listBoxTests.FormattingEnabled = true;
            this.listBoxTests.Location = new System.Drawing.Point(485, 95);
            this.listBoxTests.Name = "listBoxTests";
            this.listBoxTests.Size = new System.Drawing.Size(120, 186);
            this.listBoxTests.TabIndex = 11;
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.checkBoxAdmin);
            this.groupBoxUser.Controls.Add(this.label5);
            this.groupBoxUser.Controls.Add(this.textBoxUserPassword);
            this.groupBoxUser.Controls.Add(this.label4);
            this.groupBoxUser.Controls.Add(this.textBoxUserLogin);
            this.groupBoxUser.Controls.Add(this.buttonConfirmNewUser);
            this.groupBoxUser.Enabled = false;
            this.groupBoxUser.Location = new System.Drawing.Point(35, 308);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(210, 207);
            this.groupBoxUser.TabIndex = 15;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(145, 120);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(55, 17);
            this.checkBoxAdmin.TabIndex = 5;
            this.checkBoxAdmin.Text = "Admin";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(75, 81);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(125, 20);
            this.textBoxUserPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Login:";
            // 
            // textBoxUserLogin
            // 
            this.textBoxUserLogin.Location = new System.Drawing.Point(59, 44);
            this.textBoxUserLogin.Name = "textBoxUserLogin";
            this.textBoxUserLogin.Size = new System.Drawing.Size(141, 20);
            this.textBoxUserLogin.TabIndex = 1;
            // 
            // buttonConfirmNewUser
            // 
            this.buttonConfirmNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmNewUser.Location = new System.Drawing.Point(115, 174);
            this.buttonConfirmNewUser.Name = "buttonConfirmNewUser";
            this.buttonConfirmNewUser.Size = new System.Drawing.Size(85, 23);
            this.buttonConfirmNewUser.TabIndex = 0;
            this.buttonConfirmNewUser.Text = "Confirm";
            this.buttonConfirmNewUser.UseVisualStyleBackColor = true;
            this.buttonConfirmNewUser.Click += new System.EventHandler(this.buttonConfirmNewUser_Click);
            // 
            // groupBoxGroup
            // 
            this.groupBoxGroup.Controls.Add(this.buttonConfirmNewGroup);
            this.groupBoxGroup.Controls.Add(this.listBoxGroupTests);
            this.groupBoxGroup.Controls.Add(this.listBoxGroupUsers);
            this.groupBoxGroup.Controls.Add(this.textBox2);
            this.groupBoxGroup.Controls.Add(this.label7);
            this.groupBoxGroup.Enabled = false;
            this.groupBoxGroup.Location = new System.Drawing.Point(358, 308);
            this.groupBoxGroup.Name = "groupBoxGroup";
            this.groupBoxGroup.Size = new System.Drawing.Size(403, 243);
            this.groupBoxGroup.TabIndex = 16;
            this.groupBoxGroup.TabStop = false;
            this.groupBoxGroup.Text = "Group";
            // 
            // buttonConfirmNewGroup
            // 
            this.buttonConfirmNewGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmNewGroup.Location = new System.Drawing.Point(270, 208);
            this.buttonConfirmNewGroup.Name = "buttonConfirmNewGroup";
            this.buttonConfirmNewGroup.Size = new System.Drawing.Size(120, 23);
            this.buttonConfirmNewGroup.TabIndex = 6;
            this.buttonConfirmNewGroup.Text = "Confirm";
            this.buttonConfirmNewGroup.UseVisualStyleBackColor = true;
            // 
            // listBoxGroupTests
            // 
            this.listBoxGroupTests.FormattingEnabled = true;
            this.listBoxGroupTests.Location = new System.Drawing.Point(24, 97);
            this.listBoxGroupTests.Name = "listBoxGroupTests";
            this.listBoxGroupTests.Size = new System.Drawing.Size(120, 134);
            this.listBoxGroupTests.TabIndex = 3;
            // 
            // listBoxGroupUsers
            // 
            this.listBoxGroupUsers.FormattingEnabled = true;
            this.listBoxGroupUsers.Location = new System.Drawing.Point(270, 19);
            this.listBoxGroupUsers.Name = "listBoxGroupUsers";
            this.listBoxGroupUsers.Size = new System.Drawing.Size(120, 173);
            this.listBoxGroupUsers.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Group name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1125, 560);
            this.Controls.Add(this.groupBoxGroup);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.buttonTestToGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxTests);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.buttonUserToGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.groupBoxGroup.ResumeLayout(false);
            this.groupBoxGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUserToGroup;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Button buttonTestToGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxTests;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUserLogin;
        private System.Windows.Forms.Button buttonConfirmNewUser;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.GroupBox groupBoxGroup;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxGroupTests;
        private System.Windows.Forms.ListBox listBoxGroupUsers;
        private System.Windows.Forms.Button buttonConfirmNewGroup;
    }
}

