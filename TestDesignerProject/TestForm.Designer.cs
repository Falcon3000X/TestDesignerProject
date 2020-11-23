
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
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxQ3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxQ2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQ1 = new System.Windows.Forms.TextBox();
            this.comboBoxSolutions1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTrueAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonNewQuestion = new System.Windows.Forms.Button();
            this.listBoxTests = new System.Windows.Forms.ListBox();
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.buttonNewTest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test title:";
            // 
            // textBoxTestTitle
            // 
            this.textBoxTestTitle.Location = new System.Drawing.Point(69, 19);
            this.textBoxTestTitle.Name = "textBoxTestTitle";
            this.textBoxTestTitle.Size = new System.Drawing.Size(137, 20);
            this.textBoxTestTitle.TabIndex = 1;
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddQuestion.Location = new System.Drawing.Point(529, 320);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(97, 23);
            this.buttonAddQuestion.TabIndex = 2;
            this.buttonAddQuestion.Text = "Add question";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Q1:";
            // 
            // textBoxQ1
            // 
            this.textBoxQ1.Location = new System.Drawing.Point(75, 175);
            this.textBoxQ1.Multiline = true;
            this.textBoxQ1.Name = "textBoxQ1";
            this.textBoxQ1.Size = new System.Drawing.Size(188, 36);
            this.textBoxQ1.TabIndex = 10;
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
            this.buttonNewQuestion.Location = new System.Drawing.Point(121, 291);
            this.buttonNewQuestion.Name = "buttonNewQuestion";
            this.buttonNewQuestion.Size = new System.Drawing.Size(97, 23);
            this.buttonNewQuestion.TabIndex = 5;
            this.buttonNewQuestion.Text = "New question";
            this.buttonNewQuestion.UseVisualStyleBackColor = true;
            this.buttonNewQuestion.Click += new System.EventHandler(this.buttonNewQuestion_Click);
            // 
            // listBoxTests
            // 
            this.listBoxTests.FormattingEnabled = true;
            this.listBoxTests.Location = new System.Drawing.Point(12, 121);
            this.listBoxTests.Name = "listBoxTests";
            this.listBoxTests.Size = new System.Drawing.Size(160, 56);
            this.listBoxTests.TabIndex = 6;
            this.listBoxTests.SelectedIndexChanged += new System.EventHandler(this.listBoxTests_SelectedIndexChanged);
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.Location = new System.Drawing.Point(12, 190);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(160, 56);
            this.listBoxQuestions.TabIndex = 7;
            // 
            // buttonNewTest
            // 
            this.buttonNewTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewTest.Location = new System.Drawing.Point(109, 66);
            this.buttonNewTest.Name = "buttonNewTest";
            this.buttonNewTest.Size = new System.Drawing.Size(97, 23);
            this.buttonNewTest.TabIndex = 8;
            this.buttonNewTest.Text = "New test";
            this.buttonNewTest.UseVisualStyleBackColor = true;
            this.buttonNewTest.Click += new System.EventHandler(this.buttonNewTest_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonNewTest);
            this.groupBox2.Controls.Add(this.textBoxTestTitle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBoxQuestions);
            this.Controls.Add(this.listBoxTests);
            this.Controls.Add(this.buttonNewQuestion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAddQuestion);
            this.Name = "TestForm";
            this.Text = "Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTestTitle;
        private System.Windows.Forms.Button buttonAddQuestion;
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
        private System.Windows.Forms.ListBox listBoxTests;
        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.Button buttonNewTest;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}