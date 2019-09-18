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
using Game.Board;
namespace InterfaceTestDictonary
{
    public partial class TheBoogle : Form
    {
        GameDictionary Game;
        private int validPaths = 0;
        private Board bBoard;
        Label[,] labels;
        GameDictionary rs;
        public TheBoogle(GameDictionary _Game)
        {
            Game = _Game;
            rs = new GameDictionary();
            InitializeComponent();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            bBoard = new Board(genBroad (Int32.Parse (textBox1.Text))); // creating boggle board
            
            labels = new Label[Int32.Parse(textBox1.Text),Int32.Parse(textBox1.Text)];
            //MessageBox.Show(bBoard.toString ());
            String s = "";
            for (int i = 0; i < bBoard.dimensions (); i++)
            {
                for (int j = 0; j < bBoard.dimensions(); j++)
                {
                    Label l = new Label ();
                    l.Location = new Point (590 + i*20, 50 + j*20);
                    l.Text = bBoard.getItem(i,j);
                    l.Size = new Size(15, 15);
                    l.BorderStyle = BorderStyle.FixedSingle;
                    s += l.Text;
                    labels[i, j] = l;
                    this.Controls.Add(l);
                }
            }
            //MessageBox.Show(s);
            genALlWord();

            //richTextBox1.Text = bBoard.toString();

        }

        private void genALlWord()
        {
            for (int i = 0; i < bBoard.dimensions(); i++)
            {
                for (int j = 0; j < bBoard.dimensions(); j++)
                {
                    Word wordSoFar = new Word();
                    BoardLocation curLoc = new BoardLocation(i, j);
                    wordSoFar.addLetter(bBoard.letterAtLocation(curLoc));
                    Word newWord = wordSoFar.makeCopy();
                    Board newBoard = bBoard.makeCopy();
                    newBoard.markAsTaken(curLoc);
                    recurseWords(newWord, newBoard, curLoc);
                }
            }
           

        }

        GameDictionary boogles = new GameDictionary();

        /**
	     *The recursive method takes in three parameters, 
	     **/
        private void recurseWords(Word wordSoFar, Board bBoard, BoardLocation loc){
		    String str = wordSoFar.toString();
		    bBoard.markAsTaken(loc);
		    BoardLocation[] adjLoc = bBoard.getAdjacentUntakens(loc);
		    if(wordSoFar.getLength() > 2 && Game.ContainsKey (str)){
                if (!boogles.ContainsKey (str))
                    boogles.Add(str, null);
			    validPaths++;
		    }
		    if(!this.wordsExistThaGameartWith (str)){
			    return;
		    }else{
			    for(int i =0; i< adjLoc.Length; i++){
				    Word newWord = wordSoFar.makeCopy();
				    newWord.addLetter(bBoard.letterAtLocation(adjLoc[i]));
				    recurseWords(newWord, bBoard.makeCopy(), adjLoc[i]);
			    }
		    }		
	    }

        private bool wordsExistThaGameartWith(String word)
        {
            int maxLength = 35;
            string longest = word;
            for (int i = 0; i < maxLength; i++)
            {
                longest += "*";
                if ( Game.PartialMatch(longest).Count > 0)
                {
                    return true;
                }
            }
            return false;
        }

        private String genBroad(int t)
        {
            Random randon = new Random();
            int n = t*t;
            Byte[] buffer = new Byte[n];
            for (int i = 0; i < n; i++)
            {
                buffer[i] = (Byte)randon.Next(65, 90);
            }
            return Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        int point = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (boogles.ContainsKey(textBox2.Text) == true)
            {
                if (rs.ContainsKey(textBox2.Text) == false)
                {
                    rs.Add(textBox2.Text, null);
                    point++;
                    label2.Text = point.ToString();
                    if (rs.Count == boogles.Count)
                    {
                        MessageBox.Show("You win! Point = " + point);
                        rs.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("You have found this word already!");
                }
            }
            else
            {
                MessageBox.Show("This word doesn't exist");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Points = " + point);
            foreach (DictionaryEntry de in boogles)
            {
                string[] row = { de.Key.ToString() };

                listView1.Items.Add(new ListViewItem(row));
            }
            point = 0;
            rs.Clear();
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(textBox1.Text) < 2 || Int32.Parse(textBox1.Text) >= 10)
                {
                    MessageBox.Show("You have to enter the number from 2-9");
                    textBox1.Text = "4";
                }
                
                genBroad(Int32.Parse(textBox1.Text));
            }
            catch (FormatException)
            {
                textBox1.Clear();
                textBox1.Text = "4";
            }
            button2.Visible = true;
            rs.Clear();
            listView1.Items.Clear();
            for (int i = 0; i < bBoard.dimensions(); i++)
            {
                for (int j = 0; j < bBoard.dimensions(); j++)
                {
                    if (labels is Object)
                    {
                        labels[i,j].Visible = false;
                    }
                }
            }
            bBoard = new Board(genBroad(Int32.Parse(textBox1.Text))); // creating boggle board

            labels = new Label[Int32.Parse(textBox1.Text), Int32.Parse(textBox1.Text)];
            String s = "";
            for (int i = 0; i < bBoard.dimensions(); i++)
            {
                for (int j = 0; j < bBoard.dimensions(); j++)
                {
                    Label l = new Label();
                    l.Location = new Point(590 + i * 20, 50 + j * 20);
                    l.Text = bBoard.getItem(i, j);
                    l.Size = new Size(15, 15);
                    l.BorderStyle = BorderStyle.FixedSingle;
                    s += l.Text;
                    labels[i, j] = l;
                    this.Controls.Add(l);
                }
            }
            boogles.Clear();
            genALlWord();
        }


    }
}
