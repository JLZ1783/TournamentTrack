namespace TrackerUI_2
{
    partial class TournamentView
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
            this.TournamentLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundComboBox = new System.Windows.Forms.ComboBox();
            this.Team1label = new System.Windows.Forms.Label();
            this.Team2Label = new System.Windows.Forms.Label();
            this.ScoreTeam1Label = new System.Windows.Forms.Label();
            this.ScoreTeam2label = new System.Windows.Forms.Label();
            this.ScoreTeam1Textbox = new System.Windows.Forms.TextBox();
            this.ScoreTeam2TextboxA = new System.Windows.Forms.TextBox();
            this.UnplayedOnly = new System.Windows.Forms.CheckBox();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.MatchUplistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TournamentLabel
            // 
            this.TournamentLabel.AutoSize = true;
            this.TournamentLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TournamentLabel.Location = new System.Drawing.Point(52, 13);
            this.TournamentLabel.Name = "TournamentLabel";
            this.TournamentLabel.Size = new System.Drawing.Size(141, 28);
            this.TournamentLabel.TabIndex = 0;
            this.TournamentLabel.Text = "Tournament:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TournamentName.Location = new System.Drawing.Point(199, 13);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(95, 28);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RoundLabel.Location = new System.Drawing.Point(87, 78);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(75, 25);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            // 
            // RoundComboBox
            // 
            this.RoundComboBox.FormattingEnabled = true;
            this.RoundComboBox.Location = new System.Drawing.Point(168, 81);
            this.RoundComboBox.Name = "RoundComboBox";
            this.RoundComboBox.Size = new System.Drawing.Size(151, 21);
            this.RoundComboBox.TabIndex = 3;
            this.RoundComboBox.SelectedIndexChanged += new System.EventHandler(this.RoundComboBox_SelectedIndexChanged);
            // 
            // Team1label
            // 
            this.Team1label.AutoSize = true;
            this.Team1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Team1label.Location = new System.Drawing.Point(444, 179);
            this.Team1label.Name = "Team1label";
            this.Team1label.Size = new System.Drawing.Size(91, 26);
            this.Team1label.TabIndex = 4;
            this.Team1label.Text = "Team 1 ";
            // 
            // Team2Label
            // 
            this.Team2Label.AutoSize = true;
            this.Team2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2Label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Team2Label.Location = new System.Drawing.Point(444, 308);
            this.Team2Label.Name = "Team2Label";
            this.Team2Label.Size = new System.Drawing.Size(91, 26);
            this.Team2Label.TabIndex = 5;
            this.Team2Label.Text = "Team 2 ";
            // 
            // ScoreTeam1Label
            // 
            this.ScoreTeam1Label.AutoSize = true;
            this.ScoreTeam1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTeam1Label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ScoreTeam1Label.Location = new System.Drawing.Point(444, 205);
            this.ScoreTeam1Label.Name = "ScoreTeam1Label";
            this.ScoreTeam1Label.Size = new System.Drawing.Size(75, 26);
            this.ScoreTeam1Label.TabIndex = 6;
            this.ScoreTeam1Label.Text = "Score ";
            // 
            // ScoreTeam2label
            // 
            this.ScoreTeam2label.AutoSize = true;
            this.ScoreTeam2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTeam2label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ScoreTeam2label.Location = new System.Drawing.Point(444, 334);
            this.ScoreTeam2label.Name = "ScoreTeam2label";
            this.ScoreTeam2label.Size = new System.Drawing.Size(75, 26);
            this.ScoreTeam2label.TabIndex = 7;
            this.ScoreTeam2label.Text = "Score ";
            // 
            // ScoreTeam1Textbox
            // 
            this.ScoreTeam1Textbox.Location = new System.Drawing.Point(534, 211);
            this.ScoreTeam1Textbox.Name = "ScoreTeam1Textbox";
            this.ScoreTeam1Textbox.Size = new System.Drawing.Size(100, 20);
            this.ScoreTeam1Textbox.TabIndex = 8;
            // 
            // ScoreTeam2TextboxA
            // 
            this.ScoreTeam2TextboxA.Location = new System.Drawing.Point(534, 334);
            this.ScoreTeam2TextboxA.Name = "ScoreTeam2TextboxA";
            this.ScoreTeam2TextboxA.Size = new System.Drawing.Size(100, 20);
            this.ScoreTeam2TextboxA.TabIndex = 9;
            this.ScoreTeam2TextboxA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UnplayedOnly
            // 
            this.UnplayedOnly.AutoSize = true;
            this.UnplayedOnly.Location = new System.Drawing.Point(325, 138);
            this.UnplayedOnly.Name = "UnplayedOnly";
            this.UnplayedOnly.Size = new System.Drawing.Size(95, 17);
            this.UnplayedOnly.TabIndex = 11;
            this.UnplayedOnly.Text = "Unplayed Only";
            this.UnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // ScoreButton
            // 
            this.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ScoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ScoreButton.Location = new System.Drawing.Point(641, 263);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(90, 36);
            this.ScoreButton.TabIndex = 16;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            // 
            // MatchUplistBox
            // 
            this.MatchUplistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchUplistBox.FormattingEnabled = true;
            this.MatchUplistBox.ItemHeight = 16;
            this.MatchUplistBox.Location = new System.Drawing.Point(12, 161);
            this.MatchUplistBox.Name = "MatchUplistBox";
            this.MatchUplistBox.Size = new System.Drawing.Size(419, 212);
            this.MatchUplistBox.TabIndex = 13;
            // 
            // TournamentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 439);
            this.Controls.Add(this.MatchUplistBox);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.UnplayedOnly);
            this.Controls.Add(this.ScoreTeam2TextboxA);
            this.Controls.Add(this.ScoreTeam1Textbox);
            this.Controls.Add(this.ScoreTeam2label);
            this.Controls.Add(this.ScoreTeam1Label);
            this.Controls.Add(this.Team2Label);
            this.Controls.Add(this.Team1label);
            this.Controls.Add(this.RoundComboBox);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.TournamentLabel);
            this.Name = "TournamentView";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentLabel;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RoundComboBox;
        private System.Windows.Forms.Label Team1label;
        private System.Windows.Forms.Label Team2Label;
        private System.Windows.Forms.Label ScoreTeam1Label;
        private System.Windows.Forms.Label ScoreTeam2label;
        private System.Windows.Forms.TextBox ScoreTeam1Textbox;
        private System.Windows.Forms.TextBox ScoreTeam2TextboxA;
        private System.Windows.Forms.CheckBox UnplayedOnly;
        private System.Windows.Forms.Button ScoreButton;
        private System.Windows.Forms.ListBox MatchUplistBox;
    }
}

