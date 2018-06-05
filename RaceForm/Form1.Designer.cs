namespace RaceForm
{
    partial class Form1
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.horseLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.addBetButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.betInfoTextBox = new System.Windows.Forms.TextBox();
            this.raceTextBox = new System.Windows.Forms.TextBox();
            this.startRaceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(109, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // horseLabel
            // 
            this.horseLabel.AutoSize = true;
            this.horseLabel.Location = new System.Drawing.Point(326, 32);
            this.horseLabel.Name = "horseLabel";
            this.horseLabel.Size = new System.Drawing.Size(56, 20);
            this.horseLabel.TabIndex = 1;
            this.horseLabel.Text = "Horse:";
            this.horseLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(558, 32);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(69, 20);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "Amount:";
            // 
            // addBetButton
            // 
            this.addBetButton.Location = new System.Drawing.Point(807, 62);
            this.addBetButton.Name = "addBetButton";
            this.addBetButton.Size = new System.Drawing.Size(93, 41);
            this.addBetButton.TabIndex = 4;
            this.addBetButton.Text = "Add bet";
            this.addBetButton.UseVisualStyleBackColor = true;
            this.addBetButton.Click += new System.EventHandler(this.addBetButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(292, 71);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Horse 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(292, 101);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Horse 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(388, 71);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(90, 24);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Horse 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(388, 101);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(90, 24);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Horse 4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(113, 71);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(110, 32);
            this.nameTextBox.TabIndex = 9;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(562, 71);
            this.amountTextBox.Multiline = true;
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(110, 32);
            this.amountTextBox.TabIndex = 10;
            // 
            // betInfoTextBox
            // 
            this.betInfoTextBox.Location = new System.Drawing.Point(113, 168);
            this.betInfoTextBox.Multiline = true;
            this.betInfoTextBox.Name = "betInfoTextBox";
            this.betInfoTextBox.Size = new System.Drawing.Size(559, 140);
            this.betInfoTextBox.TabIndex = 11;
            // 
            // raceTextBox
            // 
            this.raceTextBox.Location = new System.Drawing.Point(113, 344);
            this.raceTextBox.Multiline = true;
            this.raceTextBox.Name = "raceTextBox";
            this.raceTextBox.Size = new System.Drawing.Size(700, 316);
            this.raceTextBox.TabIndex = 12;
            // 
            // startRaceButton
            // 
            this.startRaceButton.Location = new System.Drawing.Point(881, 430);
            this.startRaceButton.Name = "startRaceButton";
            this.startRaceButton.Size = new System.Drawing.Size(144, 127);
            this.startRaceButton.TabIndex = 13;
            this.startRaceButton.Text = "Start Race!";
            this.startRaceButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 741);
            this.Controls.Add(this.startRaceButton);
            this.Controls.Add(this.raceTextBox);
            this.Controls.Add(this.betInfoTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.addBetButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.horseLabel);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label horseLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button addBetButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox betInfoTextBox;
        private System.Windows.Forms.TextBox raceTextBox;
        private System.Windows.Forms.Button startRaceButton;
    }
}

