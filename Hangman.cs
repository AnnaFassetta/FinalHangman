//Filename: FinalHangman
//Author: Anna Fassetta
//Created: 07/01/2022
//Operating System: Windows
//Version: 10
//Description: Hangman game where user inputs letters to guess a word



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; // Required for ArrayList
namespace FinalHangman


{
    // Form Class where user inputs letters
    //Anna Fassetta
    //07/01/2022
    
    public partial class Hangman : Form
    {
        int WrongWordCounter = 0;
    
        int Counter = 0;
        string guesingName = "";
        string DisplayName = "";
        ArrayList StoredValues = new ArrayList();
        ArrayList StoredCorrectValues = new ArrayList();
        ArrayList StoredIncorrectCorrectValues = new ArrayList();
        SortedList<int, string> sortedlist = new SortedList<int, string>();
        List<Label> labels = new List<Label>();
        public Hangman()
        {
            InitializeComponent();
        }

        private void typedAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // When program starts it will run the this function
            //Anna Fassetta
            //07/01/2022

            GenerateNewWord();
        }

        void GenerateNewWord()
        {
            // Method to create a new random word as well as clears the previous values and rest game.
            lblDisplayScore.Visible = false;
            labels = new List<Label>();
            ArrayList al = new ArrayList();
            al.Add("hurry"); //5
            al.Add("door");//4
            al.Add("office");//6
         //   al.Add("bat");//3
            al.Add("instructions");//12
            al.Add("hospital");//8
            al.Add("academy");//7
            al.Add("necessary");//9
            al.Add("strawberry");//10

            var random = new Random();
            int index = random.Next(al.Count);
            guesingName = al[index].ToString();

            char[]chars = guesingName.ToCharArray();
            lblLength.Text = chars.Length.ToString();
            int between = 330 / chars.Length;
            for (int i = 0; i < chars.Length; i++)
            {
                labels.Add(new Label());
                labels[i].Location =  new Point((i * between) + 10,80); //Setting up the display of text
                labels[i].Text = "_";
                labels[i].Parent = groupBox1;
                labels[i].BringToFront();
                labels[i].CreateControl();
            }


            lblChecker.Text = guesingName;
            Counter = 0;
            WrongWordCounter = 0;
            lblAnswer.Visible = true;
            lblChecker.Visible = false;
            lblWord.Visible = true;
            typedAnswer.Text = "";
            lblWord.Text = "";
            DisplayName = "";
        }
        private void typedAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            // This is the key press function 
            //Anna Fassetta
            //07/01/2022
            Counter = Counter + 1;
            char OrignalWord = e.KeyChar;

            if (!CheckForLettersOnly(e.KeyChar.ToString()))
            {
                MessageBox.Show("Only Letters");
                return;
            }

            if (WrongWordCounter > 9)
            {
                //Stop Program after 10 attempts and gets a new word

                StoredIncorrectCorrectValues.Add(guesingName);//Store Incorrect values in a list
                MessageBox.Show("Answer is wrong and you have reached your attempts!");
                lblAnswer.Visible = false;
                lblChecker.Visible = false;
                lblWord.Visible = false;


                

                int GetTotalTries = StoredCorrectValues.Count + StoredIncorrectCorrectValues.Count;
                listBox2.DataSource = null;
                listBox2.Items.Clear();
                listBox2.DataSource = StoredIncorrectCorrectValues;
                label2.Text = "Score " + StoredCorrectValues.Count + " / " + GetTotalTries;
                GenerateNewWord();
            }
            else
            {
           



                if (guesingName.Contains(OrignalWord)) //If the letter contains the word
                {

                 
                    char[] letters = guesingName.ToCharArray();

                    for (int i = 0; i < letters.Length; i++)
                    {
                        if (letters[i] == OrignalWord)
                        {
                            labels[i].Text = OrignalWord.ToString();                        
                        }                    
                    }
              
                    foreach (Label eachword in labels)
                      if (eachword.Text == "_") ;



                    string MainWord = "";
                    foreach (Label eachword in labels)
                    {
                        MainWord += eachword.Text;
                    }

                    if (MainWord == guesingName) // if generated word matches the guessingName label then the user wins and we store the word into an array list. A new word then gets generated.
                    {

                        StoredCorrectValues.Add(guesingName);//Store correct values in a list

                        listBox1.DataSource = null;
                        listBox1.Items.Clear();
                        listBox1.DataSource = StoredCorrectValues;
                        MessageBox.Show("Won");
                        GenerateNewWord();

                        int GetTotal = StoredCorrectValues.Count + StoredIncorrectCorrectValues.Count;
                        label2.Text = "Score " + StoredCorrectValues.Count + " / " + GetTotal;
                        return;
                    }
                    else
                    {
                      
                    }

                    //Word Correct add to sortedList
                    try
                    {
                        sortedlist.Add(Counter, guesingName);
                    }
                    catch (Exception ex)
                    {
                        //
                    }


                    //StoredCorrectValues.Add(guesingName);//Store correct values in a list
                    //MessageBox.Show("Won");
                }
                else
                {
                    //Letter does not match any of the word
                    WrongWordCounter = WrongWordCounter + 1;
                   
       
                    MessageBox.Show("Try again");
                }




                listBox1.DataSource = null;
                listBox1.Items.Clear();
                listBox1.DataSource = StoredCorrectValues;

                listBox2.DataSource = null;
                listBox2.Items.Clear();
                listBox2.DataSource = StoredIncorrectCorrectValues;
                lblWord.Text = DisplayName + WrongWordCounter;
                int GetTotalTries = StoredCorrectValues.Count + StoredIncorrectCorrectValues.Count;
                label2.Text = "Score " + StoredCorrectValues.Count + " / " + GetTotalTries;
            }
        }

        public static bool CheckForLettersOnly(string s) // Method ensures no numbers are inserted
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        private void btnNewWord_Click(object sender, EventArgs e)
        {
            GenerateNewWord();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Thank you!", "Application Closed!", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }


    }
}
