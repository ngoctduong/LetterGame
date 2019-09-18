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
    public partial class TheMysteryWord : Form
    {
        GameDictionary Game;

        public TheMysteryWord(GameDictionary _Game)
        {
            Game = _Game;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string longest = result.Text;
            Boolean check = true;
            foreach (DictionaryEntry de in Game.PartialMatch(longest,'?'))
            {
                check = false;
                string[] row = { de.Key.ToString() };
                listView1.Items.Add(new ListViewItem(row));
            }
            if (check)
            {
                MessageBox.Show("This word doesn't exist in the dictionary");
            }
            
        }
    }
}
