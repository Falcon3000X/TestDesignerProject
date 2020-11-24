
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
            this.labelCourse = new System.Windows.Forms.Label();
            this.groupBoxMenu.SuspendLayout();
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 285);
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
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(562, 12);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(120, 186);
            this.listBoxUsers.TabIndex = 4;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(315, 52);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(120, 186);
            this.listBoxGroups.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Groups";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(572, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Users";
            // 
            // buttonUserToGroup
            // 
            this.buttonUserToGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserToGroup.Location = new System.Drawing.Point(458, 95);
            this.buttonUserToGroup.Name = "buttonUserToGroup";
            this.buttonUserToGroup.Size = new System.Drawing.Size(81, 23);
            this.buttonUserToGroup.TabIndex = 3;
            this.buttonUserToGroup.Text = "User to group";
            this.buttonUserToGroup.UseVisualStyleBackColor = true;
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("MingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourse.Location = new System.Drawing.Point(456, 121);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(83, 32);
            this.labelCourse.TabIndex = 8;
            this.labelCourse.Text = "<---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(694, 342);
            this.Controls.Add(this.labelCourse);
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
        private System.Windows.Forms.Label labelCourse;
    }
}

