using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using TestDesignerProject;
using Xml2CSharp;

namespace TestDesignerProject
{
    public partial class TestForm : Form
    {

        Tests tests = new Tests();

        Test test = null;

        XmlSerializer formatter = new XmlSerializer(typeof(Tests));// Форматтер для десериализации


        public TestForm()
        {
            InitializeComponent();

            textBoxQ2.Enabled = false;
            textBoxQ3.Enabled = false;

            tests.TestsList = new List<Test>();// Выделение памяти


            using (FileStream fs = new FileStream(@"Tests.xml", FileMode.OpenOrCreate))// Запись елементов из файла в программу через десериализацию
            {
                tests = (Tests)formatter.Deserialize(fs);// Десериализация

                foreach (Test t in tests.TestsList)
                {
                    listBoxTests.Items.Add(t);// Вывод данных в лист бокс
                }
            }

        }

        public void ReWriteTests()
        {

            listBoxTests.Items.Clear();
            listBoxQuestions.Items.Clear();

            foreach (var item in tests.TestsList)
            {
                listBoxTests.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxSolutions1.SelectedItem.ToString() == "1")
            {
                textBoxQ1.Enabled = true;
                textBoxQ2.Enabled = false;
                textBoxQ3.Enabled = false;
            }

            if (comboBoxSolutions1.SelectedItem.ToString() == "2")
            {
                textBoxQ2.Enabled = true;
                textBoxQ3.Enabled = false;
            }

            if (comboBoxSolutions1.SelectedItem.ToString() == "3")
            {
                textBoxQ2.Enabled = true;
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

                test.QuestionBlocks = new List<QuestionBlock>();

                tests.TestsList.Add(test);// Добавляем этот тест в список всех тестов.

                ReWriteTests();
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

                if (textBoxQ2.Enabled)
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
            listBoxQuestions.Items.Clear();

            var t = listBoxTests.SelectedItem as Test; // Преобразуем елемент в класс

            test = t; // инициализируем класс test

            textBoxTestTitle.Text = test.TestName; // В текстовом поле всегда будет отображаться название текущего теста

            foreach (var item in test.QuestionBlocks)
            {
                listBoxQuestions.Items.Add(item);
            }
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTests.SelectedItem != null)
            {
                var quest = listBoxQuestions.SelectedItem as QuestionBlock;

                textBoxQuestion.Text = quest.Question;
                textBoxTrueAnswer.Text = quest.TrueAnswer;

                comboBoxGrade.Text = quest.DifficultLevel.ToString();

                if (quest.Q2 != null)
                {
                    textBoxQ2.Enabled = true;
                    textBoxQ1.Text = quest.Q1;
                    textBoxQ2.Text = quest.Q2;
                }

                if (quest.Q3 != null)
                {
                    textBoxQ3.Enabled = true;
                    textBoxQ1.Text = quest.Q1;
                    textBoxQ2.Text = quest.Q2;
                    textBoxQ3.Text = quest.Q3;
                }

                if (quest.Q3 == null)
                {
                    textBoxQ3.Enabled = false;
                    textBoxQ3.Text = "";
                }

            }
        }

        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream fs = new FileStream(@"Tests.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, tests);
            }
        }
    }



}
