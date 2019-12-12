namespace TrackerUI_2
{
    partial class CreateTeamForm
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
            System.Windows.Forms.Button AddMemberButton;
            System.Windows.Forms.Button CreateMemberButton;
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.TeamMemberLabel = new System.Windows.Forms.Label();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.cellPhoneValue = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.removeSelectedemberButton = new System.Windows.Forms.Button();
            AddMemberButton = new System.Windows.Forms.Button();
            CreateMemberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddMemberButton
            // 
            AddMemberButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            AddMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddMemberButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            AddMemberButton.Location = new System.Drawing.Point(142, 199);
            AddMemberButton.Name = "AddMemberButton";
            AddMemberButton.Size = new System.Drawing.Size(120, 25);
            AddMemberButton.TabIndex = 19;
            AddMemberButton.Text = "Add New Player";
            AddMemberButton.UseVisualStyleBackColor = true;
            AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // CreateMemberButton
            // 
            CreateMemberButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            CreateMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CreateMemberButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            CreateMemberButton.Location = new System.Drawing.Point(142, 347);
            CreateMemberButton.Name = "CreateMemberButton";
            CreateMemberButton.Size = new System.Drawing.Size(120, 25);
            CreateMemberButton.TabIndex = 20;
            CreateMemberButton.Text = "Create Member";
            CreateMemberButton.UseVisualStyleBackColor = true;
            CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(49, 87);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(314, 20);
            this.teamNameValue.TabIndex = 12;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TeamNameLabel.Location = new System.Drawing.Point(44, 56);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(135, 28);
            this.TeamNameLabel.TabIndex = 11;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 18);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(140, 28);
            this.HeaderLabel.TabIndex = 10;
            this.HeaderLabel.Text = "Create Team";
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(49, 151);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(314, 21);
            this.selectTeamMemberDropDown.TabIndex = 14;
            // 
            // TeamMemberLabel
            // 
            this.TeamMemberLabel.AutoSize = true;
            this.TeamMemberLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamMemberLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TeamMemberLabel.Location = new System.Drawing.Point(44, 120);
            this.TeamMemberLabel.Name = "TeamMemberLabel";
            this.TeamMemberLabel.Size = new System.Drawing.Size(227, 28);
            this.TeamMemberLabel.TabIndex = 15;
            this.TeamMemberLabel.Text = "Select Team Member";
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.Location = new System.Drawing.Point(398, 56);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(217, 303);
            this.TeamMembersListBox.TabIndex = 18;
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(96, 241);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(254, 20);
            this.firstNameValue.TabIndex = 21;
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(97, 269);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(254, 20);
            this.lastNameValue.TabIndex = 22;
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(96, 295);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(254, 20);
            this.emailValue.TabIndex = 23;
            // 
            // cellPhoneValue
            // 
            this.cellPhoneValue.Location = new System.Drawing.Point(96, 321);
            this.cellPhoneValue.Name = "cellPhoneValue";
            this.cellPhoneValue.Size = new System.Drawing.Size(254, 20);
            this.cellPhoneValue.TabIndex = 24;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Enabled = false;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FirstNameLabel.Location = new System.Drawing.Point(5, 241);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.FirstNameLabel.TabIndex = 25;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Enabled = false;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LastNameLabel.Location = new System.Drawing.Point(5, 267);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.LastNameLabel.TabIndex = 26;
            this.LastNameLabel.Text = "Last Name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Enabled = false;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EmailLabel.Location = new System.Drawing.Point(5, 293);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(48, 20);
            this.EmailLabel.TabIndex = 27;
            this.EmailLabel.Text = "Email";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Enabled = false;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PhoneLabel.Location = new System.Drawing.Point(5, 319);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(55, 20);
            this.PhoneLabel.TabIndex = 28;
            this.PhoneLabel.Text = "Phone";
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateTeamButton.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateTeamButton.Location = new System.Drawing.Point(228, 404);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(250, 34);
            this.CreateTeamButton.TabIndex = 29;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
            // 
            // removeSelectedemberButton
            // 
            this.removeSelectedemberButton.Location = new System.Drawing.Point(631, 142);
            this.removeSelectedemberButton.Name = "removeSelectedemberButton";
            this.removeSelectedemberButton.Size = new System.Drawing.Size(83, 36);
            this.removeSelectedemberButton.TabIndex = 30;
            this.removeSelectedemberButton.Text = "Remove Selected";
            this.removeSelectedemberButton.UseVisualStyleBackColor = true;
            this.removeSelectedemberButton.Click += new System.EventHandler(this.removeSelectedemberButton_Click);
            // 
            // createTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 486);
            this.Controls.Add(this.removeSelectedemberButton);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.cellPhoneValue);
            this.Controls.Add(this.emailValue);
            this.Controls.Add(this.lastNameValue);
            this.Controls.Add(this.firstNameValue);
            this.Controls.Add(CreateMemberButton);
            this.Controls.Add(AddMemberButton);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.TeamMemberLabel);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "createTeamForm";
            this.Text = "Create Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label TeamMemberLabel;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.TextBox cellPhoneValue;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Button CreateTeamButton;
        private System.Windows.Forms.Button removeSelectedemberButton;
    }
}