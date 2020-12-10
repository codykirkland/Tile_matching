namespace tile_match
{
    partial class high_scores
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
            this.high_scores_list = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.main_menu_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // high_scores_list
            // 
            this.high_scores_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.high_scores_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.score});
            this.high_scores_list.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high_scores_list.HideSelection = false;
            this.high_scores_list.Location = new System.Drawing.Point(12, 12);
            this.high_scores_list.Name = "high_scores_list";
            this.high_scores_list.Size = new System.Drawing.Size(400, 300);
            this.high_scores_list.TabIndex = 0;
            this.high_scores_list.UseCompatibleStateImageBehavior = false;
            this.high_scores_list.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name:";
            this.name.Width = 200;
            // 
            // score
            // 
            this.score.Text = "Score:";
            this.score.Width = 200;
            // 
            // main_menu_button
            // 
            this.main_menu_button.FlatAppearance.BorderSize = 0;
            this.main_menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_menu_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menu_button.Location = new System.Drawing.Point(336, 318);
            this.main_menu_button.Name = "main_menu_button";
            this.main_menu_button.Size = new System.Drawing.Size(76, 39);
            this.main_menu_button.TabIndex = 1;
            this.main_menu_button.Text = "Main Menu";
            this.main_menu_button.UseVisualStyleBackColor = true;
            this.main_menu_button.Click += new System.EventHandler(this.main_menu_button_Click);
            // 
            // high_scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 364);
            this.Controls.Add(this.main_menu_button);
            this.Controls.Add(this.high_scores_list);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "high_scores";
            this.Text = "high_scores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView high_scores_list;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader score;
        private System.Windows.Forms.Button main_menu_button;
    }
}