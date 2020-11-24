using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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

            //QuestionBlock questionBlock = new QuestionBlock() { Question = "2+2 = ?", TrueAnswer = "4", DifficultLevel = 1, Q1 = "4", Q2 = "5", Q3 = "3" };
            //QuestionBlock questionBlock1 = new QuestionBlock() { Question = "2+3 = ?", TrueAnswer = "5", DifficultLevel = 2, Q1 = "4", Q2 = "5", Q3 = "7" };
            //QuestionBlock questionBlock2 = new QuestionBlock() { Question = "5-2 = ?", TrueAnswer = "3", DifficultLevel = 1, Q1 = "18", Q2 = "1", Q3 = "3" };

            //QuestionBlock questionBlock3 = new QuestionBlock() { Question = "5*2 = ?", TrueAnswer = "10", DifficultLevel = 1, Q1 = "10", Q2 = "5", Q3 = "4" };
            //QuestionBlock questionBlock4 = new QuestionBlock() { Question = "52-13 = ?", TrueAnswer = "39", DifficultLevel = 1, Q1 = "39", Q2 = "1" };
            //QuestionBlock questionBlock5 = new QuestionBlock() { Question = "10+10 = ?", TrueAnswer = "20", DifficultLevel = 1, Q1 = "11", Q2 = "20", Q3 = "13" };

            //Test test = new Test() { TestName = "Test1" };

            //Test test1 = new Test() { TestName = "Test2" };

            //test.QuestionBlocks = new List<QuestionBlock>();
            //test.QuestionBlocks.Add(questionBlock);
            //test.QuestionBlocks.Add(questionBlock1);
            //test.QuestionBlocks.Add(questionBlock2);

            //test1.QuestionBlocks = new List<QuestionBlock>();
            //test1.QuestionBlocks.Add(questionBlock3);
            //test1.QuestionBlocks.Add(questionBlock4);
            //test1.QuestionBlocks.Add(questionBlock5);

            //tests.TestsList = new List<Test>();

            //tests.TestsList.Add(test);
            //tests.TestsList.Add(test1);

            //ReWriteTests();
            XDocument xDocument = XDocument.Load(@"Questions.xml");

            var quests = xDocument.Element("Questions").Elements("QuestionBlock").Select(x => new
            {
                Question = x.Element("Question").Value,
                TrueAnwer = x.Element("TrueAnswer").Value,
                DifficultLevel = x.Element("DifficultLevel").Value,
                Q1 = x.Element("Q1").Value,
                Q2 = x.Element("Q2").Value,
                Q3 = x.Element("Q3").Value
            }).ToList();
            Test test = new Test();
            test.QuestionBlocks = new List<QuestionBlock>();

            foreach (var i in quests)
            {
                QuestionBlock questionBlock = new QuestionBlock();
                questionBlock.Question = i.Question;
                questionBlock.TrueAnswer = i.TrueAnwer;
                questionBlock.DifficultLevel = int.Parse(i.DifficultLevel);
                questionBlock.Q1 = i.Q1;
                questionBlock.Q2 = i.Q2;
                questionBlock.Q3 = i.Q3;
                test.QuestionBlocks.Add(questionBlock);
            }

            foreach(var i in test.QuestionBlocks)
            {
                listBoxQuestions.Items.Add(i);
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
    }
}
