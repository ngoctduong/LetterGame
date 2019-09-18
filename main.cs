using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Game.Dictionary;

namespace InterfaceTestDictonary
{
    public partial class main : Form
    {
        GameDictionary Game;
        String fileDictonary = "";
        public main()
        {
            Game = new GameDictionary();
            //fileDictonary = @"D:\TestFolder\wordsEn.txt";
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            fileDictonary = op.FileName;
            string[] lines = System.IO.File.ReadAllLines(fileDictonary);
            foreach (string line in lines)
            {
                Game.Add(line, null);
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form bai1 = new TheHungman(Game);
            bai1.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form bai2 = new TheLongestWord(Game);
            bai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form bai3 = new TheMysteryWord(Game);
            bai3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form bai2 = new TheBoogle(Game);
            bai2.Show();
        }
    }
}
