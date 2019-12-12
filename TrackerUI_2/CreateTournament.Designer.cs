namespace TrackerUI_2
{
    partial class CreateTournament
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
            System.Windows.Forms.Button CreatePrizeButton;
            System.Windows.Forms.Button AddTeamButton;
            System.Windows.Forms.Button DeleteSelectedPrizeButton;
            this.TournamentLabel = new System.Windows.Forms.Label();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.TournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.TeamsPlayerLabel = new System.Windows.Forms.Label();
            this.deleteSelectedTeamButton = new System.Windows.Forms.Button();
            this.PrizeLabel = new System.Windows.Forms.Label();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.selectTeamDropDownLabel = new System.Windows.Forms.Label();
            CreatePrizeButton = new System.Windows.Forms.Button();
            AddTeamButton = new System.Windows.Forms.Button();
            DeleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            CreatePrizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CreatePrizeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            CreatePrizeButton.Location = new System.Drawing.Point(135, 344);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new System.Drawing.Size(95, 30);
            CreatePrizeButton.TabIndex = 15;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // AddTeamButton
            // 
            AddTeamButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            AddTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddTeamButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            AddTeamButton.Location = new System.Drawing.Point(135, 294);
            AddTeamButton.Name = "AddTeamButton";
            AddTeamButton.Size = new System.Drawing.Size(95, 30);
            AddTeamButton.TabIndex = 16;
            AddTeamButton.Text = "Add Team";
            AddTeamButton.UseVisualStyleBackColor = true;
            AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // DeleteSelectedPrizeButton
            // 
            DeleteSelectedPrizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DeleteSelectedPrizeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            DeleteSelectedPrizeButton.Location = new System.Drawing.Point(642, 307);
            DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton";
            DeleteSelectedPrizeButton.Size = new System.Drawing.Size(93, 43);
            DeleteSelectedPrizeButton.TabIndex = 22;
            DeleteSelectedPrizeButton.Text = "Remove Selected";
            DeleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            DeleteSelectedPrizeButton.Click += new System.EventHandler(this.RemoveSelectedPrizeButton_Click);
            // 
            // TournamentLabel
            // 
            this.TournamentLabel.AutoSize = true;
            this.TournamentLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TournamentLabel.Location = new System.Drawing.Point(63, 22);
            this.TournamentLabel.Name = "TournamentLabel";
            this.TournamentLabel.Size = new System.Drawing.Size(208, 28);
            this.TournamentLabel.TabIndex = 1;
            this.TournamentLabel.Text = "Create Tournament";
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TournamentNameLabel.Location = new System.Drawing.Point(84, 99);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(203, 28);
            this.TournamentNameLabel.TabIndex = 2;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(68, 140);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(238, 21);
            this.tournamentNameValue.TabIndex = 9;
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(135, 196);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(110, 21);
            this.entryFeeValue.TabIndex = 11;
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Enabled = false;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EntryFeeLabel.Location = new System.Drawing.Point(50, 198);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(78, 20);
            this.EntryFeeLabel.TabIndex = 10;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(89, 248);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(198, 22);
            this.SelectTeamDropDown.TabIndex = 13;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Location = new System.Drawing.Point(95, 256);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(66, 14);
            this.SelectTeamLabel.TabIndex = 12;
            this.SelectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(293, 251);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(66, 14);
            this.createNewTeamLink.TabIndex = 14;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "Create New";
            this.createNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateNewTeamLink_LinkClicked);
            // 
            // TournamentTeamsListBox
            // 
            this.TournamentTeamsListBox.FormattingEnabled = true;
            this.TournamentTeamsListBox.ItemHeight = 14;
            this.TournamentTeamsListBox.Location = new System.Drawing.Point(387, 62);
            this.TournamentTeamsListBox.Name = "TournamentTeamsListBox";
            this.TournamentTeamsListBox.Size = new System.Drawing.Size(249, 144);
            this.TournamentTeamsListBox.TabIndex = 17;
         
            // 
            // TeamsPlayerLabel
            // 
            this.TeamsPlayerLabel.AutoSize = true;
            this.TeamsPlayerLabel.Enabled = false;
            this.TeamsPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamsPlayerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TeamsPlayerLabel.Location = new System.Drawing.Point(383, 28);
            this.TeamsPlayerLabel.Name = "TeamsPlayerLabel";
            this.TeamsPlayerLabel.Size = new System.Drawing.Size(112, 20);
            this.TeamsPlayerLabel.TabIndex = 18;
            this.TeamsPlayerLabel.Text = "Teams/Players";
         
            // 
            // deleteSelectedTeamButton
            // 
            this.deleteSelectedTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedTeamButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteSelectedTeamButton.Location = new System.Drawing.Point(642, 112);
            this.deleteSelectedTeamButton.Name = "deleteSelectedTeamButton";
            this.deleteSelectedTeamButton.Size = new System.Drawing.Size(93, 42);
            this.deleteSelectedTeamButton.TabIndex = 19;
            this.deleteSelectedTeamButton.Text = "Remove Selected";
            this.deleteSelectedTeamButton.UseVisualStyleBackColor = true;
            this.deleteSelectedTeamButton.Click += new System.EventHandler(this.RemoveSelectedTeamButton_Click);
            // 
            // PrizeLabel
            // 
            this.PrizeLabel.AutoSize = true;
            this.PrizeLabel.Enabled = false;
            this.PrizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizeLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PrizeLabel.Location = new System.Drawing.Point(383, 220);
            this.PrizeLabel.Name = "PrizeLabel";
            this.PrizeLabel.Size = new System.Drawing.Size(52, 20);
            this.PrizeLabel.TabIndex = 21;
            this.PrizeLabel.Text = "Prizes";
          
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 14;
            this.PrizesListBox.Location = new System.Drawing.Point(387, 243);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(249, 144);
            this.PrizesListBox.TabIndex = 20;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateTournamentButton.Location = new System.Drawing.Point(148, 430);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(347, 34);
            this.CreateTournamentButton.TabIndex = 23;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            this.CreateTournamentButton.Click += new System.EventHandler(this.CreateTournamentButton_Click);
            // 
            // selectTeamDropDownLabel
            // 
            this.selectTeamDropDownLabel.AutoSize = true;
            this.selectTeamDropDownLabel.Enabled = false;
            this.selectTeamDropDownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamDropDownLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.selectTeamDropDownLabel.Location = new System.Drawing.Point(143, 225);
            this.selectTeamDropDownLabel.Name = "selectTeamDropDownLabel";
            this.selectTeamDropDownLabel.Size = new System.Drawing.Size(98, 20);
            this.selectTeamDropDownLabel.TabIndex = 10;
            this.selectTeamDropDownLabel.Text = "Select Team";
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = AddTeamButton;
            this.ClientSize = new System.Drawing.Size(759, 482);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(DeleteSelectedPrizeButton);
            this.Controls.Add(this.PrizeLabel);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.deleteSelectedTeamButton);
            this.Controls.Add(this.TeamsPlayerLabel);
            this.Controls.Add(this.TournamentTeamsListBox);
            this.Controls.Add(AddTeamButton);
            this.Controls.Add(CreatePrizeButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.selectTeamDropDownLabel);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.TournamentLabel);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "CreateTournament";
            this.Text = "Create Tournament";
            this.Load += new System.EventHandler(this.CreateTournament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentLabel;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.ComboBox SelectTeamDropDown;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.ListBox TournamentTeamsListBox;
        private System.Windows.Forms.Label TeamsPlayerLabel;
        private System.Windows.Forms.Button deleteSelectedTeamButton;
        private System.Windows.Forms.Label PrizeLabel;
        private System.Windows.Forms.ListBox PrizesListBox;
        private System.Windows.Forms.Button CreateTournamentButton;
        private System.Windows.Forms.Label selectTeamDropDownLabel;
    }
}