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
 * This is the game. It will draw and generate the board, get the inputs, 
 * add new tiles, move the tiles on the board, 
 * calculate the score and check to see if a new tile can be added.
 */
namespace tile_match
{
    public partial class game : Form
    {

        float tsize;//this is the size of the tiles on the board
        static int Rc = 6;//this is the number of columns and rows
        double[,] tiles = new double[Rc, Rc];//this will create the game board
        public double score = 0;//this is the score of the player

        Random random = new Random();

        //this is used to get the direction the tiles will move
        enum direction { up, down, left, right }
        direction d;

        public game()
        {
            InitializeComponent();
            Start();//this will generate a new board
            scorelabel.Text = $"Score: { score.ToString()}";//this will write the score to the label

        }
        /**
         * this method will create a new board
         */
        public void Start()
        {
            //this builds the board
            for (int y = 0; y < Rc; y++)
            {
                for (int x = 0; x < Rc; x++)
                {
                    //the edges of the board will become walls
                    if (y == 0 || y == Rc - 1 ||
                       x == 0 || x == Rc - 1)
                    {
                        tiles[y, x] = 1;//creates on object as a wall
                    }
                    else
                    {
                        tiles[y, x] = 0;//creates an object as an open space
                    }



                }
            }

            //places 2 tiles on the board to start
            newtile();
            newtile();
        }


        /*
         * this will place a new tile on a random place on the board
         */
        public void newtile()
        {
            bool placed = false;//this will turn true if a tile has been placed

            //this will loop until a tile is placed
            do
            {
                //gets 3 random numbers
                int col = random.Next(1, 5);//random column on the board
                int row = random.Next(1, 5);//random row on the board
                int nextnum = random.Next(1, 3);//determines what number the tile will be.



                //this checks to see if the tile is empty
                if (tiles[col, row] == 0)
                {
                    //this determines what number the numbered tile will be
                    if (nextnum == 1)
                    {
                        tiles[col, row] = 2;
                    }
                    if (nextnum == 2)
                    {
                        tiles[col, row] = 4;
                    }
                    placed = true;
                }

            } while (!placed);
        }

        /**
        * this will get the direction the tiles will move
        */
        private void game_KeyPress(object sender, KeyPressEventArgs e)
        {
            string dir = e.KeyChar.ToString();//this gets the key pressed

            //this will determine what direction the player wants to move
            switch (dir)
            {
                case ("d")://this will move right
                case ("D"):
                    d = direction.right;
                    moveblock();//this will move the blocks
                    break;
                case ("a")://this will move left
                case ("A"):
                    d = direction.left;
                    moveblock();//this will move the blocks
                    break;
                case ("w")://this will move up
                case ("W"):
                    d = direction.up;
                    moveblock();//this will move the blocks
                    break;
                case ("s")://this will move down
                case ("S"):
                    d = direction.down;
                    moveblock();//this will move the blocks
                    break;

            }
        }

        /**
         * this will move the tiles around the board.
         */
        public void moveblock()
        {

            bool move = false;
            //this will move the tiles 4 times
            for (int i = 0; i < 4; i++)
            {
                //this will determine where the tiles will move
                switch (d)
                {
                    case (direction.up)://this will move the tiles up
                        //this will move all the tiles over one space
                        for (int y = 1; y < Rc - 1; y++)
                        {
                            for (int x = 1; x < Rc - 1; x++)
                            {
                                //this checks to see if the tile can move
                                if (tiles[y, x - 1] == 0 && tiles[y, x] != 0)
                                {
                                    //moves the tile
                                    tiles[y, x - 1] = tiles[y, x];
                                    tiles[y, x] = 0;
                                    move = true;//this will tell the game a tile has moved

                                }
                                else if (tiles[y, x - 1] == tiles[y, x] && tiles[y, x] != 0)//this checks to see if 2 tiles can merge
                                {
                                    //this will merge the tiles
                                    tiles[y, x - 1] += tiles[y, x];
                                    tiles[y, x] = 0;
                                    score += tiles[y, x - 1];
                                    move = true;//this will tell the game a tile has moved
                                }
                            }
                        }
                        break;
                    case (direction.down)://this will move the tiles down
                        //this will move all the tiles over one space
                        for (int y = 4; y >= 1; y--)
                        {
                            for (int x = 4; x >= 1; x--)
                            {
                                //this checks to see if the tile can move
                                if (tiles[y, x + 1] == 0 && tiles[y, x] != 0)
                                {
                                    //moves the tile
                                    tiles[y, x + 1] = tiles[y, x];
                                    tiles[y, x] = 0;
                                    move = true;//this will tell the game a tile has moved


                                }
                                else if (tiles[y, x + 1] == tiles[y, x] && tiles[y, x] != 0)//this checks to see if 2 tiles can merge
                                {
                                    //this will merge the tiles
                                    tiles[y, x + 1] += tiles[y, x];
                                    tiles[y, x] = 0;
                                    score += tiles[y, x + 1];
                                    move = true;//this will tell the game a tile has moved

                                }
                            }
                        }
                        break;
                    case (direction.left)://this will move the tiles left
                        //this will move all the tiles over one space
                        for (int y = 1; y < Rc - 1; y++)
                        {
                            for (int x = 1; x < Rc - 1; x++)
                            {
                                //this checks to see if the tile can move
                                if (tiles[y - 1, x] == 0 && tiles[y, x] != 0)
                                {
                                    //moves the tile
                                    tiles[y - 1, x] = tiles[y, x];
                                    tiles[y, x] = 0;
                                    move = true;//this will tell the game a tile has moved


                                }
                                else if (tiles[y - 1, x] == tiles[y, x] && tiles[y, x] != 0)//this checks to see if 2 tiles can merge
                                {
                                    //this will merge the tiles
                                    tiles[y - 1, x] += tiles[y, x];
                                    tiles[y, x] = 0;
                                    score += tiles[y - 1, x];
                                    move = true;//this will tell the game a tile has moved

                                }
                            }
                        }
                        break;
                    case (direction.right)://this will move the tiles right
                        //this will move all the tiles over one space
                        for (int y = 4; y >= 1; y--)
                        {
                            for (int x = 4; x >= 1; x--)
                            {
                                //this checks to see if the tile can move
                                if (tiles[y + 1, x] == 0 && tiles[y, x] != 0)
                                {
                                    //moves the tile
                                    tiles[y + 1, x] = tiles[y, x];
                                    tiles[y, x] = 0;
                                    move = true;//this will tell the game a tile has moved


                                }
                                else if (tiles[y + 1, x] == tiles[y, x] && tiles[y, x] != 0)///this checks to see if 2 tiles can merge
                                {
                                    //this will merge the tiles
                                    tiles[y + 1, x] += tiles[y, x];
                                    tiles[y, x] = 0;
                                    score += tiles[y + 1, x];
                                    move = true;//this will tell the game a tile has moved


                                }
                            }
                        }
                        break;


                }
                scorelabel.Text = $"Score: { score.ToString()}";//this will update the score

                game_board.Invalidate();//this will refresh the screen
            }

            check();//this will check to see if a new tile can be placed

            //if a tile has moved a new tile will be added to the board 
            if (move)
            {
                newtile();//adds a new tile
                check();

            }
        }

        /**
        * this will check if the game board if full 
        */
        public void check()
        {

            bool end = true;//this will turn false if a space on the board is open or 2 tiles can merge

            //this will check to see if a new tile can be added to the board
            for (int y = 1; y <= 4; y++)
            {
                for (int x = 1; x <= 4; x++)
                {

                    //if a tile on the board is empty or 2 tiles can be combined it will switch end to false
                    if (tiles[y, x] == 0 ||
                        tiles[y, x] == tiles[y, x + 1] ||
                        tiles[y, x] == tiles[y + 1, x] ||
                        tiles[y, x] == tiles[y, x - 1] ||
                        tiles[y, x] == tiles[y - 1, x])
                    {
                        end = false;

                    }


                }
            }

            //if end is true it will open the end screen
            if (end == true)
            {
                end_game lostform = new end_game(score);
                this.Hide();
                lostform.ShowDialog();
                this.Close();
            }
        }
        /**
        * this will paint the board and tiles
        */
        private void gamescreen_Paint(object sender, PaintEventArgs e)
        {
            tsize = 500 / (Rc);//this will get the size of the tiles

            Graphics canvas = e.Graphics;
            Brush boardcolor;
            Pen blackPen = new Pen(Color.Black, 3);
            Font drawFont = new Font("Arial", 16);

            //this will center the tile number in the tile
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            //this draws all of the tiles on the board
            for (int y = 0; y < Rc; y++)
            {
                for (int x = 0; x < Rc; x++)
                {
                    //this will draw the empty spaces on the board
                    if (tiles[y, x] == 0)
                    {
                        canvas.DrawRectangle(blackPen, y * tsize, x * tsize, tsize, tsize);
                    }

                    else if (tiles[y, x] > 1)//this will draw the numbered tiles on the board
                    {
                        if (tiles[y, x] == 2 || tiles[y, x] == 32 || tiles[y, x] == 512)
                        {
                            boardcolor = Brushes.Green;//changes the brush color to green
                            canvas.FillRectangle(boardcolor, y * tsize, x * tsize, tsize, tsize);//this will draw a filled rectangle
                            canvas.DrawRectangle(blackPen, y * tsize, x * tsize, tsize, tsize);
                        }
                        if (tiles[y, x] == 4 || tiles[y, x] == 64 || tiles[y, x] == 1024)
                        {
                            boardcolor = Brushes.Red;//changes the brush color to red
                            canvas.FillRectangle(boardcolor, y * tsize, x * tsize, tsize, tsize);//this will draw a filled rectangle
                            canvas.DrawRectangle(blackPen, y * tsize, x * tsize, tsize, tsize);
                        }
                        if (tiles[y, x] == 8 || tiles[y, x] == 128 || tiles[y, x] == 512)
                        {
                            boardcolor = Brushes.Blue;//changes the brush color to blue
                            canvas.FillRectangle(boardcolor, y * tsize, x * tsize, tsize, tsize);//this will draw a filled rectangle
                            canvas.DrawRectangle(blackPen, y * tsize, x * tsize, tsize, tsize);
                        }
                        if (tiles[y, x] == 16 || tiles[y, x] == 256)
                        {
                            boardcolor = Brushes.Orange;//changes the brush color to orange
                            canvas.FillRectangle(boardcolor, y * tsize, x * tsize, tsize, tsize);//this will draw a filled rectangle
                            canvas.DrawRectangle(blackPen, y * tsize, x * tsize, tsize, tsize);
                        }
                        if (tiles[y, x] >= 2048)
                        {
                            boardcolor = Brushes.Gold;//changes the brush color to gold
                            canvas.FillRectangle(boardcolor, y * tsize, x * tsize, tsize, tsize);//this will draw a filled rectangle
                            canvas.DrawRectangle(blackPen, y * tsize, x * tsize, tsize, tsize);
                        }
                        //this will draw the number on the tiles
                        canvas.DrawString(tiles[y, x].ToString(), drawFont, Brushes.Black, (y + .5f) * tsize, (x + .5f) * tsize, stringFormat);

                    }
                }

            }
        }
    }
}
