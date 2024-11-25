using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {
        // Quiz variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 8;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++; 
            }

            if(questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine + 
                    "You have answered " + score +  " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click Ok to retake quiz"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }


            questionNumber++;
            askQuestion(questionNumber);


        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.flower_png;

                    lblQuestion.Text = "What is the name of this flower?";

                    button1.Text = "Sunflower";
                    button2.Text = "Hibiscus";
                    button3.Text = "Purple Rose";
                    button4.Text = "Purple Ivy";

                    correctAnswer = 2;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.end_sars;

                    lblQuestion.Text = "What date was the end sars protest in Nigeria?";

                    button1.Text = "20th October 2021";
                    button2.Text = "20th October 2020";
                    button3.Text = "20th October 2022";
                    button4.Text = "20th October 2023";

                    correctAnswer = 1;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.money;

                    lblQuestion.Text = "What is the most used currency in the world?";

                    button1.Text = "Pounds";
                    button2.Text = "Canadian Dollars";
                    button3.Text = "US Dollars";
                    button4.Text = "Yen";

                    correctAnswer = 3;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.physics;

                    lblQuestion.Text = "Who is called the father of modern physics?";

                    button1.Text = "Albert Einstein";
                    button2.Text = "Isaac Newton";
                    button3.Text = "Charles Babbage";
                    button4.Text = "Elon Musk";

                    correctAnswer = 1;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.moon;

                    lblQuestion.Text = "Who first landed on the moon?";

                    button1.Text = "The United States of America";
                    button2.Text = "Russia";
                    button3.Text = "The United Kingdom";
                    button4.Text = "Israel";

                    correctAnswer = 1;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.light;

                    lblQuestion.Text = "Who invented the light bulb?";

                    button1.Text = "Thomas Howard";
                    button2.Text = "Thomas Edison";
                    button3.Text = "Lewis Latimer";
                    button4.Text = "Frank Bower";

                    correctAnswer = 2;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.iphone;

                    lblQuestion.Text = "Who founded the iPhone?";

                    button1.Text = "Bob Marley";
                    button2.Text = "Steve Haries";
                    button3.Text = "Steve Jobs";
                    button4.Text = "Steve Jobe";

                    correctAnswer = 3;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.maths;

                    lblQuestion.Text = "What is used to represent a constant in mathematics?";

                    button1.Text = "c";
                    button2.Text = "kc";
                    button3.Text = "k";
                    button4.Text = "const";

                    correctAnswer = 3;

                    break;
            }
        }
    }
}
