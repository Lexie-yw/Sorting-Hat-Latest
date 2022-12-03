﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sorting_Hat_Final
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        //Sort Hat Variables: Hogwarts, Gryffindor, Slytherin, Ravenclaw and Hufflepuff.
        int hufflepuff;
        int gryffindor;
        int slytherin;
        int ravenclaw;

        int questionNum = 1;
        int totalQuestions;
        string[] house = new string[5];
        string result;

        /* 
        int correctAnswer;
        int questionNum;
        int score;
        int percentage;
        int totalQuestions;
         */
        public Form1()
        {
            InitializeComponent();
            AskQuestion(questionNum);
            totalQuestions = 5;

            //player.SoundLocation = "Properties.Resources.HarryPotterTheme.wav";
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream s = a.GetManifestResourceStream("HarryPotterTheme.wav");
            SoundPlayer player = new SoundPlayer(s);
            player.Play();
        }

        public static string mostFrequent(string[] arr, int n)
        {
            int maxcount = 0;
            string element_having_max_freq = "";
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                // This logic could be further optimized
                if (count >= maxcount)
                {
                    maxcount = count;
                    element_having_max_freq = arr[i];
                }
            }

            return element_having_max_freq;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (System.Windows.Forms.Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == gryffindor)
            {
                house[questionNum - 1] = "Gryffindor";
            }
            else if (buttonTag == ravenclaw)
            {
                house[questionNum - 1] = "Ravenclaw";
            }
            else if (buttonTag == hufflepuff)
            {
                house[questionNum - 1] = "Hufflepuff";
            }
            else {
                house[questionNum - 1] = "Slytherin";
            }

            if (questionNum == totalQuestions) {
                //work on the result
                result = mostFrequent(house, house.Length);

                //work on the offer:
                string cTime = DateTime.Now.ToString("T", CultureInfo.CurrentCulture);
                MessageBox.Show(
                    $@"Enrollment Date: {cTime}{Environment.NewLine}
                    Congrats! You're now a {result} student!
                    {Environment.NewLine} Best,{Environment.NewLine}Hogwarts Admission Office
                    {Environment.NewLine}Select OK to Play Again!");

                questionNum = 0;
                AskQuestion(questionNum);
            }

            questionNum++;
            AskQuestion(questionNum);
        }

        private void AskQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Color;
                    shQuestion.Text = "Choose one color from below as your lucky color: ";
                    button1.Text = "Red";
                    button2.Text = "Blue";
                    button3.Text = "Yellow";
                    button4.Text = "Green";

                    gryffindor = 1;
                    ravenclaw = 2;
                    hufflepuff = 3;
                    slytherin = 4;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.Hogwarts;
                    shQuestion.Text = "Choose one place to live from below options: ";
                    button1.Text = "Castle";
                    button2.Text = "Tower";
                    button3.Text = "Basement";
                    button4.Text = "Under Lake";

                    gryffindor = 1;
                    ravenclaw = 2;
                    hufflepuff = 3;
                    slytherin = 4;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.Friend;
                    shQuestion.Text = "Choose one of the animal as your friend: ";
                    button1.Text = "Lion";
                    button2.Text = "Eagle";
                    button3.Text = "Badger";
                    button4.Text = "Snake";

                    gryffindor = 1;
                    ravenclaw = 2;
                    hufflepuff = 3;
                    slytherin = 4;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.Class;
                    shQuestion.Text = "Select one of the courses from below as your first semester's core course: ";
                    button1.Text = "Defence Against the Dark Arts";
                    button2.Text = "Charms";
                    button3.Text = "Care of Magic Creatures";
                    button4.Text = "Dark Arts";

                    gryffindor = 1;
                    ravenclaw = 2;
                    hufflepuff = 3;
                    slytherin = 4;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.Personality;
                    shQuestion.Text = "What's the quality that you value the most: ";
                    button1.Text = "Courage";
                    button2.Text = "Wisdom";
                    button3.Text = "Loyalty";
                    button4.Text = "Ambition";

                    gryffindor = 1;
                    ravenclaw = 2;
                    hufflepuff = 3;
                    slytherin = 4;

                    break;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void langSelecBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (langSelecBox.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("zh-CN");
                    break;

                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
                    break;

                case 2:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
                    break;

                case 3:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("es");
                    break;

                case 4:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR");
                    break;

                case 5:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("it-IT");
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("it-IT");
                    break;

                case 6:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ja-JP");
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ja-JP");
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
        }

    }
}

