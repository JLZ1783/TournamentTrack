using System;

namespace TrackerUI_2
{
    partial class CreatePrize
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.PrizePercentage = new System.Windows.Forms.Label();
            this.PrizeAmount = new System.Windows.Forms.Label();
            this.PlaceNameLabel = new System.Windows.Forms.Label();
            this.PlaceNumberLabel = new System.Windows.Forms.Label();
            this.PrizePercentageTextbox = new System.Windows.Forms.TextBox();
            this.PrizeAmountTextBox = new System.Windows.Forms.TextBox();
            this.PlaceNameTextbox = new System.Windows.Forms.TextBox();
            this.PlaceNumberTextbox = new System.Windows.Forms.TextBox();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.ORlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HeaderLabel.Location = new System.Drawing.Point(17, 34);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(133, 28);
            this.HeaderLabel.TabIndex = 11;
            this.HeaderLabel.Text = "Create Prize";
            // 
            // PrizePercentage
            // 
            this.PrizePercentage.AutoSize = true;
            this.PrizePercentage.Enabled = false;
            this.PrizePercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizePercentage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PrizePercentage.Location = new System.Drawing.Point(18, 240);
            this.PrizePercentage.Name = "PrizePercentage";
            this.PrizePercentage.Size = new System.Drawing.Size(130, 20);
            this.PrizePercentage.TabIndex = 36;
            this.PrizePercentage.Text = "Prize Percentage";
            // 
            // PrizeAmount
            // 
            this.PrizeAmount.AutoSize = true;
            this.PrizeAmount.Enabled = false;
            this.PrizeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizeAmount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PrizeAmount.Location = new System.Drawing.Point(18, 168);
            this.PrizeAmount.Name = "PrizeAmount";
            this.PrizeAmount.Size = new System.Drawing.Size(104, 20);
            this.PrizeAmount.TabIndex = 35;
            this.PrizeAmount.Text = "Prize Amount";
            // 
            // PlaceNameLabel
            // 
            this.PlaceNameLabel.AutoSize = true;
            this.PlaceNameLabel.Enabled = false;
            this.PlaceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PlaceNameLabel.Location = new System.Drawing.Point(18, 129);
            this.PlaceNameLabel.Name = "PlaceNameLabel";
            this.PlaceNameLabel.Size = new System.Drawing.Size(94, 20);
            this.PlaceNameLabel.TabIndex = 34;
            this.PlaceNameLabel.Text = "Place Name";
            // 
            // PlaceNumberLabel
            // 
            this.PlaceNumberLabel.AutoSize = true;
            this.PlaceNumberLabel.Enabled = false;
            this.PlaceNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceNumberLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PlaceNumberLabel.Location = new System.Drawing.Point(18, 92);
            this.PlaceNumberLabel.Name = "PlaceNumberLabel";
            this.PlaceNumberLabel.Size = new System.Drawing.Size(108, 20);
            this.PlaceNumberLabel.TabIndex = 33;
            this.PlaceNumberLabel.Text = "Place Number";
            // 
            // PrizePercentageTextbox
            // 
            this.PrizePercentageTextbox.Location = new System.Drawing.Point(166, 240);
            this.PrizePercentageTextbox.Name = "PrizePercentageTextbox";
            this.PrizePercentageTextbox.Size = new System.Drawing.Size(254, 20);
            this.PrizePercentageTextbox.TabIndex = 32;
            this.PrizePercentageTextbox.Text = "0";
            // 
            // PrizeAmountTextBox
            // 
            this.PrizeAmountTextBox.Location = new System.Drawing.Point(166, 170);
            this.PrizeAmountTextBox.Name = "PrizeAmountTextBox";
            this.PrizeAmountTextBox.Size = new System.Drawing.Size(254, 20);
            this.PrizeAmountTextBox.TabIndex = 31;
            this.PrizeAmountTextBox.Text = "0";
            this.PrizeAmountTextBox.TextChanged += new System.EventHandler(this.PrizeAmountTextBox_TextChanged);
            // 
            // PlaceNameTextbox
            // 
            this.PlaceNameTextbox.Location = new System.Drawing.Point(166, 131);
            this.PlaceNameTextbox.Name = "PlaceNameTextbox";
            this.PlaceNameTextbox.Size = new System.Drawing.Size(254, 20);
            this.PlaceNameTextbox.TabIndex = 30;
            // 
            // PlaceNumberTextbox
            // 
            this.PlaceNumberTextbox.Location = new System.Drawing.Point(166, 92);
            this.PlaceNumberTextbox.Name = "PlaceNumberTextbox";
            this.PlaceNumberTextbox.Size = new System.Drawing.Size(254, 20);
            this.PlaceNumberTextbox.TabIndex = 29;
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePrizeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreatePrizeButton.Location = new System.Drawing.Point(96, 319);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(250, 34);
            this.CreatePrizeButton.TabIndex = 37;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // ORlabel
            // 
            this.ORlabel.AutoSize = true;
            this.ORlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORlabel.Location = new System.Drawing.Point(274, 205);
            this.ORlabel.Name = "ORlabel";
            this.ORlabel.Size = new System.Drawing.Size(33, 20);
            this.ORlabel.TabIndex = 38;
            this.ORlabel.Text = "-or-";
            // 
            // CreatePrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 365);
            this.Controls.Add(this.ORlabel);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.PrizePercentage);
            this.Controls.Add(this.PrizeAmount);
            this.Controls.Add(this.PlaceNameLabel);
            this.Controls.Add(this.PlaceNumberLabel);
            this.Controls.Add(this.PrizePercentageTextbox);
            this.Controls.Add(this.PrizeAmountTextBox);
            this.Controls.Add(this.PlaceNameTextbox);
            this.Controls.Add(this.PlaceNumberTextbox);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "CreatePrize";
            this.Text = "Create Prize";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label PrizePercentage;
        private System.Windows.Forms.Label PrizeAmount;
        private System.Windows.Forms.Label PlaceNameLabel;
        private System.Windows.Forms.Label PlaceNumberLabel;
        private System.Windows.Forms.TextBox PrizePercentageTextbox;
        private System.Windows.Forms.TextBox PrizeAmountTextBox;
        private System.Windows.Forms.TextBox PlaceNameTextbox;
        private System.Windows.Forms.TextBox PlaceNumberTextbox;
        private System.Windows.Forms.Button CreatePrizeButton;
        private System.Windows.Forms.Label ORlabel;
      
    }
}