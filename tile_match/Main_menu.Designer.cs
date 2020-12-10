namespace tile_match
{
    partial class Main_menu
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
            this.tilematching = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.highscoresbutton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tilematching
            // 
            this.tilematching.AutoSize = true;
            this.tilematching.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilematching.Location = new System.Drawing.Point(41, 9);
            this.tilematching.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tilematching.Name = "tilematching";
            this.tilematching.Size = new System.Drawing.Size(145, 33);
            this.tilematching.TabIndex = 0;
            this.tilematching.Text = "Tile Matching";
            // 
            // startbutton
            // 
            this.startbutton.FlatAppearance.BorderSize = 0;
            this.startbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbutton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(59, 52);
            this.startbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(108, 37);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // highscoresbutton
            // 
            this.highscoresbutton.FlatAppearance.BorderSize = 0;
            this.highscoresbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highscoresbutton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoresbutton.Location = new System.Drawing.Point(59, 95);
            this.highscoresbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.highscoresbutton.Name = "highscoresbutton";
            this.highscoresbutton.Size = new System.Drawing.Size(108, 37);
            this.highscoresbutton.TabIndex = 2;
            this.highscoresbutton.Text = "High Scores";
            this.highscoresbutton.UseVisualStyleBackColor = true;
            this.highscoresbutton.Click += new System.EventHandler(this.highscoresbutton_Click);
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(59, 138);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(108, 37);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(226, 226);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.highscoresbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.tilematching);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Main_menu";
            this.Text = "Main_menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tilematching;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button highscoresbutton;
        private System.Windows.Forms.Button exit;
    }
}