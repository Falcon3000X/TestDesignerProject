
namespace TestDesignerProject
{
    partial class TestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTestTitle = new System.Windows.Forms.TextBox();
            this.buttonAddTest = new System.Windows.Forms.Button();
            this.buttonBackToTests = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSolutions1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTrueAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonNewQuestion = new System.Windows.Forms.Button();
            this.textBoxQ1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxQ2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxQ3 = new System.Windows.Forms.TextBox();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test title:";
            // 
            // textBoxTestTitle
            // 
            this.textBoxTestTitle.Location = new System.Drawing.Point(67, 31);
            this.textBoxTestTitle.Name = "textBoxTestTitle";
            this.textBoxTestTitle.Size = new System.Drawing.Size(138, 20);
            this.textBoxTestTitle.TabIndex = 1;
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTest.Location = new System.Drawing.Point(529, 320);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(97, 23);
            this.buttonAddTest.TabIndex = 2;
            this.buttonAddTest.Text = "Add question";
            this.buttonAddTest.UseVisualStyleBackColor = true;
            this.buttonAddTest.Click += new System.EventHandler(this.buttonAddTest_Click);
            // 
            // buttonBackToTests
            // 
            this.buttonBackToTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToTests.Location = new System.Drawing.Point(12, 320);
            this.buttonBackToTests.Name = "buttonBackToTests";
            this.buttonBackToTests.Size = new System.Drawing.Size(97, 23);
            this.buttonBackToTests.TabIndex = 3;
            this.buttonBackToTests.Text = "Back to tests";
            this.buttonBackToTests.UseVisualStyleBackColor = true;
            this.buttonBackToTests.Click += new System.EventHandler(this.buttonBackToTests_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxGrade);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxQ3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxQ2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxQ1);
            this.groupBox1.Controls.Add(this.comboBoxSolutions1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxTrueAnswer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxQuestion);
            this.groupBox1.Location = new System.Drawing.Point(242, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 302);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Q";
            // 
            // comboBoxSolutions1
            // 
            this.comboBoxSolutions1.FormattingEnabled = true;
            this.comboBoxSolutions1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxSolutions1.Location = new System.Drawing.Point(75, 109);
            this.comboBoxSolutions1.Name = "comboBoxSolutions1";
            this.comboBoxSolutions1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSolutions1.TabIndex = 9;
            this.comboBoxSolutions1.Text = "1";
            this.comboBoxSolutions1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Solutions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Answer:";
            // 
            // textBoxTrueAnswer
            // 
            this.textBoxTrueAnswer.Location = new System.Drawing.Point(75, 66);
            this.textBoxTrueAnswer.Name = "textBoxTrueAnswer";
            this.textBoxTrueAnswer.Size = new System.Drawing.Size(188, 20);
            this.textBoxTrueAnswer.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Question:";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(75, 23);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(188, 37);
            this.textBoxQuestion.TabIndex = 0;
            // 
            // buttonNewQuestion
            // 
            this.buttonNewQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewQuestion.Location = new System.Drawing.Point(67, 93);
            this.buttonNewQuestion.Name = "buttonNewQuestion";
            this.buttonNewQuestion.Size = new System.Drawing.Size(97, 23);
            this.buttonNewQuestion.TabIndex = 5;
            this.buttonNewQuestion.Text = "New question";
            this.buttonNewQuestion.UseVisualStyleBackColor = true;
            this.buttonNewQuestion.Click += new System.EventHandler(this.buttonNewQuestion_Click);
            // 
            // textBoxQ1
            // 
            this.textBoxQ1.Location = new System.Drawing.Point(75, 175);
            this.textBoxQ1.Multiline = true;
            this.textBoxQ1.Name = "textBoxQ1";
            this.textBoxQ1.Size = new System.Drawing.Size(188, 36);
            this.textBoxQ1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Q1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Q2:";
            // 
            // textBoxQ2
            // 
            this.textBoxQ2.Location = new System.Drawing.Point(75, 217);
            this.textBoxQ2.Multiline = true;
            this.textBoxQ2.Name = "textBoxQ2";
            this.textBoxQ2.Size = new System.Drawing.Size(188, 36);
            this.textBoxQ2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Q3:";
            // 
            // textBoxQ3
            // 
            this.textBoxQ3.Location = new System.Drawing.Point(75, 259);
            this.textBoxQ3.Multiline = true;
            this.textBoxQ3.Name = "textBoxQ3";
            this.textBoxQ3.Size = new System.Drawing.Size(188, 36);
            this.textBoxQ3.TabIndex = 14;
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxGrade.Location = new System.Drawing.Point(75, 139);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGrade.TabIndex = 17;
            this.comboBoxGrade.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Grade:";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 355);
            this.Controls.Add(this.buttonNewQuestion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBackToTests);
            this.Controls.Add(this.buttonAddTest);
            this.Controls.Add(this.textBoxTestTitle);
            this.Controls.Add(this.label1);
            this.Name = "TestForm";
            this.Text = "Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTestTitle;
        private System.Windows.Forms.Button buttonAddTest;
        private System.Windows.Forms.Button buttonBackToTests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTrueAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSolutions1;
        private System.Windows.Forms.Button buttonNewQuestion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxQ3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxQ2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQ1;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.Label label8;
    }
}