using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * This is the end screen. It has 3 buttons one going to the main menu, another going to the high scores, and the last restarting the game.
 * If the player gets a top ten score a text box will become visible and the player will put their name in it and when they click on a button, 
 * it will add the name to the high scores list.
 */
namespace tile_match
{
    public partial class end_game : Form
    {
        double Score;//this is the final score of the player
        high_scores highscore = new high_scores();

        public end_game(double score)
        {
            Score = score;//this is the score the player has gotten
            InitializeComponent();
            score_label.Text = $"Score: { Score.ToString()}";//this will write the final score to the label
            //if the player has a top ten score it will make the text box visible
            if (highscore.checklowest(Score))
            {
                //this sets a label and text box to visible
                name_label.Visible = true;
                name_textBox.Visible = true;
            }
        }

        /**
         * this method will bring up the main menu when it is clicked
         */
        private void main_menu_button_Click(object sender, EventArgs e)
        {
            Main_menu mmenu = new Main_menu();//opens the main menu
            this.Hide();//this will hide this window
            string nam = name_textBox.Text;//this will get the name of the player
            highscore.addtolist(nam, Score);//this will add the name and the score to the list if it is on the top 10
            mmenu.ShowDialog();//this will show the high scores window
            this.Close();
        }
        /**
         * this method will bring up the high scores when it is clicked
         */
        private void high_score_button_Click(object sender, EventArgs e)
        {
            this.Hide();//this will hide this window
            string nam = name_textBox.Text;//this will get the name of the player
            highscore.addtolist(nam, Score);//this will add the name and the score to the list if it is on the top 10
            highscore.ShowDialog();//this will show the main menu window
            this.Close();
        }
        /**
         * this method will restart the game when it is clicked
         */
        private void restart_button_Click(object sender, EventArgs e)
        {
            game maingame = new game();//this will open the game window
            this.Hide();//this will hide this window
            string nam = name_textBox.Text;//this will get the name of the player
            highscore.addtolist(nam, Score);//this will add the name and the score to the list if it is on the top 10
            maingame.ShowDialog();//this will restart the game
            this.Close();
        }

        /**
         * this will make it so you can not have spaces in the name you put into the textbox
         */
        private void name_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
