
namespace TestDesignerProject
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
            this.buttonAddTest = new System.Windows.Forms.Button();
            this.buttonEditTest = new System.Windows.Forms.Button();
            this.buttonRemoveTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTest.Location = new System.Drawing.Point(231, 127);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(112, 23);
            this.buttonAddTest.TabIndex = 0;
            this.buttonAddTest.Text = "Add test";
            this.buttonAddTest.UseVisualStyleBackColor = true;
            this.buttonAddTest.Click += new System.EventHandler(this.buttonAddTest_Click);
            // 
            // buttonEditTest
            // 
            this.buttonEditTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditTest.Location = new System.Drawing.Point(231, 156);
            this.buttonEditTest.Name = "buttonEditTest";
            this.buttonEditTest.Size = new System.Drawing.Size(112, 23);
            this.buttonEditTest.TabIndex = 1;
            this.buttonEditTest.Text = "Edit test";
            this.buttonEditTest.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveTest
            // 
            this.buttonRemoveTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveTest.Location = new System.Drawing.Point(231, 185);
            this.buttonRemoveTest.Name = "buttonRemoveTest";
            this.buttonRemoveTest.Size = new System.Drawing.Size(112, 23);
            this.buttonRemoveTest.TabIndex = 2;
            this.buttonRemoveTest.Text = "Remove test";
            this.buttonRemoveTest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 377);
            this.Controls.Add(this.buttonRemoveTest);
            this.Controls.Add(this.buttonEditTest);
            this.Controls.Add(this.buttonAddTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTest;
        private System.Windows.Forms.Button buttonEditTest;
        private System.Windows.Forms.Button buttonRemoveTest;
    }
}

