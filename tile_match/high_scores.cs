using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * this will get the top ten scores and their names from a file and display the list.
 * it will also add a new name and check to see if a new name will be added
 */
namespace tile_match
{
    public partial class high_scores : Form
    {
        List<player> players = new List<player>();//this will hold the unsorted list of players
        List<player> sortedplayer;//this will hold the sorted players list 
        string filepath = Path.Combine(Environment.CurrentDirectory, "topscores.txt");//this is the file where the high scores are kept
        public high_scores()
        {
            loadlist();//this will load the list of high scores
            InitializeComponent();
            listviewadd();//this will add the sorted list to the list view   
        }

        /**
         * this will take the player back to the main menu
         */
        private void main_menu_button_Click(object sender, EventArgs e)
        {
            Main_menu mmenu = new Main_menu();//opens the main menu
            this.Hide();//this will hide this window
            mmenu.ShowDialog();//this will show the high scores window
            this.Close();
        }
        /**
         * this will add the sortedplayer list to the list view
         */
        public void listviewadd()
        {
            ListViewItem item1 = new ListViewItem();//creates a new list item
            item1.Text = sortedplayer[0].Name;
            item1.SubItems.Add(sortedplayer[0].Score.ToString());
            high_scores_list.Items.Add(item1);
            ListViewItem item2 = new ListViewItem();//creates a new list item
            item2.Text = sortedplayer[1].Name;
            item2.SubItems.Add(sortedplayer[1].Score.ToString());
            high_scores_list.Items.Add(item2);
            ListViewItem item3 = new ListViewItem();//creates a new list item
            item3.Text = sortedplayer[2].Name;
            item3.SubItems.Add(sortedplayer[2].Score.ToString());
            high_scores_list.Items.Add(item3);
            ListViewItem item4 = new ListViewItem();//creates a new list item
            item4.Text = sortedplayer[3].Name;
            item4.SubItems.Add(sortedplayer[3].Score.ToString());
            high_scores_list.Items.Add(item4);
            ListViewItem item5 = new ListViewItem();//creates a new list item
            item5.Text = sortedplayer[4].Name;
            item5.SubItems.Add(sortedplayer[4].Score.ToString());
            high_scores_list.Items.Add(item5);
            ListViewItem item6 = new ListViewItem();//creates a new list item
            item6.Text = sortedplayer[5].Name;
            item6.SubItems.Add(sortedplayer[5].Score.ToString());
            high_scores_list.Items.Add(item6);
            ListViewItem item7 = new ListViewItem();//creates a new list item
            item7.Text = sortedplayer[6].Name;
            item7.SubItems.Add(sortedplayer[6].Score.ToString());
            high_scores_list.Items.Add(item7);
            ListViewItem item8 = new ListViewItem();//creates a new list item
            item8.Text = sortedplayer[7].Name;
            item8.SubItems.Add(sortedplayer[7].Score.ToString());
            high_scores_list.Items.Add(item8);
            ListViewItem item9 = new ListViewItem();//creates a new list item
            item9.Text = sortedplayer[8].Name;
            item9.SubItems.Add(sortedplayer[8].Score.ToString());
            high_scores_list.Items.Add(item9);
            ListViewItem item10 = new ListViewItem();//creates a new list item
            item10.Text = sortedplayer[9].Name;
            item10.SubItems.Add(sortedplayer[9].Score.ToString());
            high_scores_list.Items.Add(item10);
        }
        /*
         * this will load the list of high scores
         */
        public void loadlist()
        {
            //this will populate the players list with 10 objects
            for (int i = 0; i < 10; i++)
            {
                players.Add(new player("aaaa", 0000));//adds an object to the list
            }
            try
            {
                //this will either open or create a new a file
                FileStream input = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Read);
                TextReader reader = new StreamReader(input);

                string line = "";//this will hold a line of the file

                //this will loop until the end of the file
                while (line != null)
                {
                    line = reader.ReadLine();//this will read the line in the file


                    if (line != null)
                    {
                        string[] word = line.Split(' ');//this will split the line into names and scores
                        if (word.Length >= 2)
                        {
                            players.Insert(0, new player(word[0], Convert.ToDouble(word[1])));//adds a new object to the list at the front of the list
                            players.RemoveAt(10);//this will remove the element at the end of the list
                        }

                    }
                }
                reader.Close();//this closes the file
            }
            catch (IOException) { MessageBox.Show("error reading the file", "file error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            //this will sort the list of high scores by the score
            sortedplayer = (from p in players orderby p.Score descending select p).ToList();

        }

        /**
         * this will add a new name and score to the high scores list
         */
        public void addtolist(string name, double score)
        {
            int index = 0;//this will determine what position the loop is on 

            //this will loop through the list 
            foreach (player play in sortedplayer)
            {
                //if the score is bigger or equal to the current player in the list it will add a new player to the list
                if (play.Score <= score)
                {
                    sortedplayer.Insert(index, new player(name, score));//inserts a new object at the space of the index
                    break;
                }
                index++;

            }
            index = 0;

            try
            {
                //this will either open or create a new a file
                FileStream input = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
                TextWriter twrite = new StreamWriter(input);

                //this will loop through all of the objects in the list
                foreach (player play in sortedplayer)
                {
                    if (index < 10)
                    {
                        twrite.WriteLine($"{play.Name} {play.Score.ToString()}");//this will write the name and the high score to the file
                        index++;
                    }
                }
                twrite.Close();//this will close the file

            }
            catch (IOException) { MessageBox.Show("error reading the file", "file error", MessageBoxButtons.OK, MessageBoxIcon.Error); }



            high_scores_list.Items.Clear();//this will clear the list view
            listviewadd();//this will add the sorted list to the list view
        }
        /**
         * this will determine if the player score is in the top 10 scores
         */
        public bool checklowest(double score)
        {
            return score > sortedplayer[9].Score;
        }
    }
}
