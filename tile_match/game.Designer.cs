namespace tile_match
{
    partial class game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.game_board = new System.Windows.Forms.PictureBox();
            this.scorelabel = new System.Windows.Forms.Label();
            this.controls = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.game_board)).BeginInit();
            this.SuspendLayout();
            // 
            // game_board
            // 
            this.game_board.Location = new System.Drawing.Point(29, 26);
            this.game_board.Name = "game_board";
            this.game_board.Size = new System.Drawing.Size(500, 500);
            this.game_board.TabIndex = 0;
            this.game_board.TabStop = false;
            this.game_board.Paint += new System.Windows.Forms.PaintEventHandler(this.gamescreen_Paint);
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel.Location = new System.Drawing.Point(549, 88);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(70, 33);
            this.scorelabel.TabIndex = 1;
            this.scorelabel.Text = "Score:";
            // 
            // controls
            // 
            this.controls.AutoSize = true;
            this.controls.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controls.Location = new System.Drawing.Point(551, 144);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(69, 144);
            this.controls.TabIndex = 2;
            this.controls.Text = "Controls\r\n\r\nW = Up\r\nA=Left\r\nS = Down\r\nD = Right\r\n";
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 552);
            this.Controls.Add(this.controls);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.game_board);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "game";
            this.Text = "game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.gamescreen_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.game_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.game_board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox game_board;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Label controls;
    }
}

