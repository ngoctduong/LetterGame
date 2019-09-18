using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Game.Dictionary;
using System.Collections;

namespace InterfaceTestDictonary
{
    public partial class TheHungman : Form
    {
        GameDictionary Game;
        Label[] listLabels;

        public TheHungman(GameDictionary _Game)
        {
            Game = _Game;
            InitializeComponent(); 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        ArrayList list = new ArrayList();
        String word = "";
        String sword = "";
        private void genneralWork(String word)
        {
            listView1.Clear();
            
            if (listLabels is Object)
            {
                for (int i = 0; i < listLabels.Length; i++)
                {
                    listLabels[i].Visible = false;
                }
            }
            listLabels = new Label [word.Length];
            this.word = word;
            turn = 11;
            Random random = new Random();
            char[] cs = word.ToCharArray();
            int numberC = word.Length-1;
            while (numberC >= 0)
            {
                cs[numberC] = '*';
                numberC--;
            }
            for (int i = 0; i < word.Length; i++)
            {
                listLabels[i] = new Label();
                listLabels[i].Text = cs[i].ToString();
                listLabels[i].Size = new Size(16, 16);
                listLabels[i].BorderStyle = BorderStyle.FixedSingle;
                listLabels[i].Location = new Point(107 + i*20, 71);
                this.Controls.Add(listLabels[i]);
            }
            sword = new String(cs);
            //tuCanTim.Text = new String(cs);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genneralWork(Game.RandomKey ());
        }



        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\TestFolder\WriteLines2.txt"))
            {
                foreach (DictionaryEntry de in Game.NearNeighbors("a",1))
                {
                    string[] row = { de.Key.ToString() };
                    listView1.Items.Add(new ListViewItem(row));
                }
            }  
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
        int turn =11;
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (rs.Text.Length > 0)
            {
                if (turn > 0)
                {
                    string wordHanger = rs.Text;
                    bool check = false;
                    char[] scc = word.ToCharArray();
                    char[] wss = sword.ToCharArray();
                    int countw = 0;
                    for (int i = 0; i < scc.Length; i++)
                    {
                        if (wss[i] == '*' && scc[i] == rs.Text.ToCharArray()[0])
                        {
                            listLabels[i].Text = rs.Text.ToLower();
                            wss[i] = rs.Text.ToCharArray()[0];
                            countw++;
                            check = true;
                        }
                    }
                    int count_wild = 0;
                    for (int i = 0; i < wss.Length; i++)
                    {
                        if (wss[i] == '*')
                            count_wild++;
                    }
                    if (check == true)
                    {
                        labstatus.Text = "Your answer is right.!!! You only have  " + (turn).ToString() + " times";
                    }

                    if (check == true && count_wild == 0)
                    {
                        labstatus.Text = "You win!!!";
                        if (MessageBox.Show("Your answer is right. Do you want to continue ?", "You win", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            genneralWork(Game.RandomKey());
                        else
                            this.Dispose();
                    }

                    if (!check)
                    {
                        string[] row = { rs.Text };
                        listView1.Items.Add(new ListViewItem(row));
                        if (turn <= 0)
                        {
                            labstatus.Text = "You lose! The answer is: \"" + word + "\"";
                            if (MessageBox.Show("You lose ! The answer is: \"" + word + "\" \nDo you want to continue?", "You lose", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                genneralWork(Game.RandomKey());
                            //else

                            //this.Disposed();
                        }
                        else
                        {
                            turn--;
                            labstatus.Text = "Your answer is wrong ! You only have  " + (turn).ToString() + " times";
                            labTurn.Text = (11 - turn).ToString() + "/11";
                        }
                    }
                    sword = new String(wss);
                }
                else
                {
                    char[] scc = word.ToCharArray();
                    char[] wss = sword.ToCharArray();
                    for (int i = 0; i < scc.Length; i++)
                    {
                        listLabels[i].Text = scc[i].ToString();
                    }
                    MessageBox.Show("Game Over");

                }

            }
        }

        private void ketqua_TextChanged(object sender, EventArgs e)
        {
            if (rs.Text.Length > 1)
            {
                rs.Text = rs.Text.Substring(0, 1);
            }

        }
    }
}

