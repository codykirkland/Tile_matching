namespace tile_match
{
    partial class end_game
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
            this.end_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.main_menu_button = new System.Windows.Forms.Button();
            this.restart_button = new System.Windows.Forms.Button();
            this.high_score_button = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // end_label
            // 
            this.end_label.AutoSize = true;
            this.end_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_label.Location = new System.Drawing.Point(62, 9);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(143, 24);
            this.end_label.TabIndex = 0;
            this.end_label.Text = "the game has ended";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label.Location = new System.Drawing.Point(15, 40);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(42, 19);
            this.score_label.TabIndex = 1;
            this.score_label.Text = "Score:";
            // 
            // main_menu_button
            // 
            this.main_menu_button.FlatAppearance.BorderSize = 0;
            this.main_menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_menu_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menu_button.Location = new System.Drawing.Point(11, 74);
            this.main_menu_button.Name = "main_menu_button";
            this.main_menu_button.Size = new System.Drawing.Size(80, 38);
            this.main_menu_button.TabIndex = 2;
            this.main_menu_button.Text = "Main Menu";
            this.main_menu_button.UseVisualStyleBackColor = true;
            this.main_menu_button.Click += new System.EventHandler(this.main_menu_button_Click);
            // 
            // restart_button
            // 
            this.restart_button.FlatAppearance.BorderSize = 0;
            this.restart_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart_button.Location = new System.Drawing.Point(102, 74);
            this.restart_button.Name = "restart_button";
            this.restart_button.Size = new System.Drawing.Size(80, 38);
            this.restart_button.TabIndex = 3;
            this.restart_button.Text = "Restart";
            this.restart_button.UseVisualStyleBackColor = true;
            this.restart_button.Click += new System.EventHandler(this.restart_button_Click);
            // 
            // high_score_button
            // 
            this.high_score_button.FlatAppearance.BorderSize = 0;
            this.high_score_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.high_score_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high_score_button.Location = new System.Drawing.Point(193, 74);
            this.high_score_button.Name = "high_score_button";
            this.high_score_button.Size = new System.Drawing.Size(80, 38);
            this.high_score_button.TabIndex = 4;
            this.high_score_button.Text = "High Scores";
            this.high_score_button.UseVisualStyleBackColor = true;
            this.high_score_button.Click += new System.EventHandler(this.high_score_button_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(11, 129);
            this.name_label.Name = "name_label";
            this.name_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name_label.Size = new System.Drawing.Size(110, 19);
            this.name_label.TabIndex = 5;
            this.name_label.Text = "Enter a name here:";
            this.name_label.Visible = false;
            // 
            // name_textBox
            // 
            this.name_textBox.BackColor = System.Drawing.Color.White;
            this.name_textBox.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.Location = new System.Drawing.Point(125, 128);
            this.name_textBox.MaxLength = 4;
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(37, 24);
            this.name_textBox.TabIndex = 6;
            this.name_textBox.Text = "aaaa";
            this.name_textBox.Visible = false;
            // 
            // end_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 187);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.high_score_button);
            this.Controls.Add(this.restart_button);
            this.Controls.Add(this.main_menu_button);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.end_label);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "end_game";
            this.Text = "end_game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label end_label;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Button main_menu_button;
        private System.Windows.Forms.Button restart_button;
        private System.Windows.Forms.Button high_score_button;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_textBox;
    }
}