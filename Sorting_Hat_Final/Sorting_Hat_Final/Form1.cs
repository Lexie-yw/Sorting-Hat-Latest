using System;
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
using System.Resources;

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
        string[] house = new string[11];
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
            //ResourceManager rm = new ResourceManager(typeof(Form1));
            InitializeComponent();
            AskQuestion(questionNum);
            totalQuestions = 11;
            




            /*System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream s = a.GetManifestResourceStream("HarryPotterTheme.wav");*/

            /*SoundPlayer audio = new SoundPlayer(Properties.Resources);
            audio.Play();*/
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
            ResourceManager rm = new System.Resources.ResourceManager(typeof(Form1));
            var senderObject = (System.Windows.Forms.Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == gryffindor)
            {
                house[questionNum - 1] = rm.GetString("houseNameGryffindor");
            }
            else if (buttonTag == ravenclaw)
            {
                house[questionNum - 1] = rm.GetString("houseNameRavenclaw");
            }
            else if (buttonTag == hufflepuff)
            {
                house[questionNum - 1] = rm.GetString("houseNameHufflepuff");
            }
            else { 
                house[questionNum - 1] = rm.GetString("houseNameSlytherin");
            }

            if (questionNum == totalQuestions) {
                //work on the result
                result = mostFrequent(house, house.Length);

                //work on the offer:
                string cTime = DateTime.Now.ToString("D", CultureInfo.CurrentCulture);
                string replay;
                MessageBox.Show(rm.GetString("enrollmentDateIntro") + cTime + Environment.NewLine + rm.GetString("enrollmentCongrats") + result + Environment.NewLine + rm.GetString("enrollmentGreeting") + Environment.NewLine + rm.GetString("signature"));
             
                    

                questionNum = 0;
                AskQuestion(questionNum);
            }

            questionNum++;
            AskQuestion(questionNum);
        }

        private void AskQuestion(int qnum)
        {
            ResourceManager rm = new ResourceManager(typeof(Form1));
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Color;
                    shQuestion.Text = rm.GetString("colorQ");
                    button1.Text = rm.GetString("colorA1");
                    button2.Text = rm.GetString("colorA2");
                    button3.Text = rm.GetString("colorA3");
                    button4.Text = rm.GetString("colorA4");

                    /*shQuestion.Text = rm.GetString("colorQ");
                    button1.Text = rm.GetString("colorA1");
                    button2.Text = rm.GetString("colorA2");
                    button3.Text = rm.GetString("colorA3");
                    button4.Text = rm.GetString("colorA4");*/

                    gryffindor = 1;
                    ravenclaw = 2;
                    hufflepuff = 3;
                    slytherin = 4;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.Hogwarts;
                    shQuestion.Text = rm.GetString("placeQ");
                    button1.Text = rm.GetString("placeA1");
                    button2.Text = rm.GetString("placeA2");
                    button3.Text = rm.GetString("placeA3");
                    button4.Text = rm.GetString("placeA4");

                    gryffindor = 1;
                    ravenclaw = 2;
                    hufflepuff = 3;
                    slytherin = 4;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.Friend;
                    shQuestion.Text = rm.GetString("animalQ");
                    button1.Text = rm.GetString("animalA1");
                    button2.Text = rm.GetString("animalA2");
                    button3.Text = rm.GetString("animalA3");
                    button4.Text = rm.GetString("animalA4");

                    gryffindor = 1;
                    ravenclaw = 2;
                    hufflepuff = 3;
                    slytherin = 4;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.Class;
                    shQuestion.Text = rm.GetString("courseQ");
                    button1.Text = rm.GetString("courseA1");
                    button2.Text = rm.GetString("courseA2");
                    button3.Text = rm.GetString("courseA3");
                    button4.Text = rm.GetString("courseA4");

                    gryffindor = 1;
                    ravenclaw = 2;
                    hufflepuff = 3;
                    slytherin = 4;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.Personality;
                    shQuestion.Text = rm.GetString("qualityQ");
                    button1.Text = rm.GetString("qualityA1");
                    button2.Text = rm.GetString("qualityA2");
                    button3.Text = rm.GetString("qualityA3");
                    button4.Text = rm.GetString("qualityA4");

                    gryffindor = 1;
                    ravenclaw = 2;
                    hufflepuff = 3;
                    slytherin = 4;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.Instrument;

                    //Due to warning message, haven't implement i18n and i10n
                    //Did not externalize texts to .resx yet

                    shQuestion.Text = rm.GetString("insQ");
                    button1.Text = rm.GetString("insA1");
                    button2.Text = rm.GetString("insA2");
                    button3.Text = rm.GetString("insA3");
                    button4.Text = rm.GetString("insA4");
                    /*
                                        shQuestion.Text = "Which instrument would you choose for the soundtrack of your life?";
                                        button1.Text = "Violin";
                                        button2.Text = "Drum";
                                        button3.Text = "Piano";
                                        button4.Text = "Trumpet";*/

                    gryffindor = 1;
                    ravenclaw = 2;
                    hufflepuff = 3;
                    slytherin = 4;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.Tea;

                    //Due to warning message, haven't implement i18n and i10n
                    //Did not externalize texts to .resx yet

                    shQuestion.Text = rm.GetString("teaQ");
                    button1.Text = rm.GetString("teaA1");
                    button2.Text = rm.GetString("teaA2");
                    button3.Text = rm.GetString("teaA3");
                    button4.Text = rm.GetString("teaA4");

/*                    shQuestion.Text = "It’s a sunny afternoon. What will you have with your tea?";
                    button1.Text = "Yorkshire pudding with roast beef";
                    button2.Text = "Salmon finger sandwiches";
                    button3.Text = "Pumpkin pasties";
                    button4.Text = "Rock cakes";*/

                    gryffindor = 1;
                    ravenclaw = 2;
                    hufflepuff = 3;
                    slytherin = 4;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.Patronus;

                    //Due to warning message, haven't implement i18n and i10n
                    //Did not externalize texts to .resx yet

                    shQuestion.Text = rm.GetString("patronusQ");
                    button1.Text = rm.GetString("patronusA1");
                    button2.Text = rm.GetString("patronusA2");
                    button3.Text = rm.GetString("patronusA3");
                    button4.Text = rm.GetString("patronusA4");

                    /*                    shQuestion.Text = "What Patronus are you?";
                                        button1.Text = "A stag";
                                        button2.Text = "A hare";
                                        button3.Text = "A wolf";
                                        button4.Text = "A doe";*/

                    gryffindor = 1;
                    ravenclaw = 2;
                    hufflepuff = 3;
                    slytherin = 4;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.Treasure;

                    //Due to warning message, haven't implement i18n and i10n
                    //Did not externalize texts to .resx yet

                    shQuestion.Text = rm.GetString("treasureQ");
                    button1.Text = rm.GetString("treasureA1");
                    button2.Text = rm.GetString("treasureA2");
                    button3.Text = rm.GetString("treasureA3");
                    button4.Text = rm.GetString("treasureA4");

                    /*                    shQuestion.Text = "What’s your most precious possession?";
                                        button1.Text = "A sword";
                                        button2.Text = "A diadem";
                                        button3.Text = "A golden cup";
                                        button4.Text = "A personal diary";*/

                    gryffindor = 1;
                    ravenclaw = 2;
                    hufflepuff = 3;
                    slytherin = 4;

                    break;


                case 10:
                    pictureBox1.Image = Properties.Resources.Quidditch;

                    //Due to warning message, haven't implement i18n and i10n
                    //Did not externalize texts to .resx yet

                    shQuestion.Text = rm.GetString("qdchQ");
                    button1.Text = rm.GetString("qdchA1");
                    button2.Text = rm.GetString("qdchA2");
                    button3.Text = rm.GetString("qdchA3");
                    button4.Text = rm.GetString("qdchA4");
                    /*
                                        shQuestion.Text = "You’ve followed the Quidditch world cup in the past weeks and now you want to join your house’s team as:";
                                        button1.Text = "Chaser";
                                        button2.Text = "Seeker";
                                        button3.Text = "You’ll be cheering in the crowd, supporting everyone";
                                        button4.Text = "Beater";*/

                    gryffindor = 1;
                    ravenclaw = 2;
                    hufflepuff = 3;
                    slytherin = 4;

                    break;

                case 11:
                    pictureBox1.Image = Properties.Resources.Adventure;

                    //Due to warning message, haven't implement i18n and i10n
                    //Did not externalize texts to .resx yet

                    shQuestion.Text = rm.GetString("advQ");
                    button1.Text = rm.GetString("advA1");
                    button2.Text = rm.GetString("advA2");
                    button3.Text = rm.GetString("advA3");
                    button4.Text = rm.GetString("advA4");

/*                    shQuestion.Text = "Coming from MIIS, Hogwarts is a whole different school: you have free time on Sunday. Where do you go?";
                    button1.Text = "The Forbidden Forest";
                    button2.Text = "The Library";
                    button3.Text = "The Kitchen";
                    button4.Text = "The Room of Requirement";*/

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
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-ES");
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("es-ES");
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

        private void shQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}

