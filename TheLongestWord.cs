using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Game.Dictionary;
namespace InterfaceTestDictonary
{
    public partial class TheLongestWord : Form
    {
        GameDictionary Game;

        public TheLongestWord(GameDictionary _Game)
        {
            Game = _Game;
            InitializeComponent();
        }
        String word;
        String wordFirst;
        int lengMin = 0, lengFrist =0;
        private void TheLongest_Load(object sender, EventArgs e)
        {
            word = Game.RandomKey();
            Random random = new Random();
            int k = random.Next(3, word.Length);
            lengFrist = k;
            wordFirst = word.Substring(0, k);
            genneralWork(wordFirst);
        }
        private void genneralWork(String word)
        {
            _word.Text = word;
            label2.Text = word;
        }

        private String findLongestWord(String word,int length) 
        {
            int maxLength = 35;
            string longest = word;
            for (int i = 0; i < length; i++ )
            {
                longest += "*";
            }
            for (int i = length; i < maxLength; i++)
            {
                longest += "*";
                foreach (DictionaryEntry de in Game.PartialMatch(longest))
                {
                    return de.Key.ToString();
                }
            }
            return "";
        }
        String ktmax = "";
        private void button2_Click(object sender, EventArgs e)
        {
            //ketqua.Text.Length 
            try
            {
                if (rs.Text.Length <= lengMin)
                {
                    MessageBox.Show("You have to enter the word with more letters");
                }
                else
                {
                    GameDictionaryEntry GameDictionaryEntry = Game.Find(_word.Text + rs.Text);
                    String key = GameDictionaryEntry.Key;
                    string wordNew = findLongestWord(_word.Text, rs.TextLength);
                    lengMin = wordNew.Length - lengFrist;

                    if (String.Compare(wordNew, "") != 0)
                    {
                        string[] row = { rs.Text, wordNew };
                        listView1.Items.Add(new ListViewItem(row));
                        MessageBox.Show("We find word " + wordNew);
                        ktmax = wordNew;
                    }
                    else
                    {
                        MessageBox.Show("You win!");
                    }
                }

            }
            catch 
            {
                MessageBox.Show("Word you entered is not in the dictionary!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string wordNew = findLongestWord(_word.Text, lengMin-1);
            if (MessageBox.Show("You lose!") == DialogResult.OK)
                this.Dispose();
        }
    }
}
