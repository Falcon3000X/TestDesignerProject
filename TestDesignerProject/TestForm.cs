using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDesignerProject;
using Xml2CSharp;

namespace TestDesignerProject
{
    public partial class TestForm : Form
    {

        Tests tests = new Tests();
        Test test = null;
        public TestForm()
        {
            InitializeComponent();
            textBoxQ2.Enabled = false;
            textBoxQ3.Enabled = false;

            Serializer serializer = new Serializer();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSolutions1.SelectedItem.ToString() == "2")
            {
                textBoxQ2.Enabled = true;
            }

            if (comboBoxSolutions1.SelectedItem.ToString() == "3")
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


        private void buttonNewTest_Click(object sender, EventArgs e)
        {
            if (textBoxTestTitle.Text != "")
            {
                test = new Test();

                test.TestName = textBoxTestTitle.Text;// Присваиваем тесту имя из textBox

                tests.TestsList.Add(test);// Добавляем этот тест в список всех тестов.

                listBoxTests.Items.Add(test.TestName);// Добавляем название теста в список тестов в listBox
            }
            else // Если же textBox пуст, то показываем ошибку ввода
            {
                MessageBox.Show("TextBox is empty!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            if (test != null && textBoxQuestion.Text != "" && textBoxTrueAnswer.Text != "" && textBoxQ1.Text != "")
            {
                QuestionBlock questionBlock = new QuestionBlock();

                questionBlock.Question = textBoxQuestion.Text;
                questionBlock.TrueAnswer = textBoxTrueAnswer.Text;
                questionBlock.DifficultLevel = int.Parse(comboBoxGrade.Text);
                questionBlock.Q1 = textBoxQ1.Text;

                if(textBoxQ2.Enabled)
                    questionBlock.Q2 = textBoxQ2.Text;

                if (textBoxQ3.Enabled)
                    questionBlock.Q3 = textBoxQ3.Text;

                test.QuestionBlocks.Add(questionBlock);
            }
            else
            {
                MessageBox.Show("Test class is null!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            var t = listBoxTests.SelectedItem as Test; // Преобразуем елемент в класс

            test = t; // инициализируем класс test

            textBoxTestTitle.Text = test.TestName; // В текстовом поле всегда будет отображаться название текущего теста
        }
    }
}
