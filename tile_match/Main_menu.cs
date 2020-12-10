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
 * this is the main menu of the game
 */
namespace tile_match
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        /**
         * this will start the game
         */
        private void startbutton_Click(object sender, EventArgs e)
        {
            game maingame = new game();//this will launch the game window
            this.Hide();//this will hide the main menu
            maingame.ShowDialog();//this will show the game window
            this.Close();//this will close the main menu
        }

        /**
         * this will show the high scores
         */
        private void highscoresbutton_Click(object sender, EventArgs e)
        {
            high_scores high = new high_scores(); //this will launch the high scores window
            this.Hide();//this will hide the main menu
            high.ShowDialog();//this will show the high scores window
            this.Close();//this will close the main menu
        }

        /**
         * this will close the program
         */
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();//this will close the game
        }
    }
}

