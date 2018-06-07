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
            this.horse1Button = new System.Windows.Forms.RadioButton();
            this.horse2Button = new System.Windows.Forms.RadioButton();
            this.horse3Button = new System.Windows.Forms.RadioButton();
            this.horse4Button = new System.Windows.Forms.RadioButton();
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
            // horse1Button
            // 
            this.horse1Button.AutoSize = true;
            this.horse1Button.Location = new System.Drawing.Point(292, 71);
            this.horse1Button.Name = "horse1Button";
            this.horse1Button.Size = new System.Drawing.Size(90, 24);
            this.horse1Button.TabIndex = 5;
            this.horse1Button.TabStop = true;
            this.horse1Button.Text = "Horse 1";
            this.horse1Button.UseVisualStyleBackColor = true;
            // 
            // horse2Button
            // 
            this.horse2Button.AutoSize = true;
            this.horse2Button.Location = new System.Drawing.Point(292, 101);
            this.horse2Button.Name = "horse2Button";
            this.horse2Button.Size = new System.Drawing.Size(90, 24);
            this.horse2Button.TabIndex = 6;
            this.horse2Button.TabStop = true;
            this.horse2Button.Text = "Horse 2";
            this.horse2Button.UseVisualStyleBackColor = true;
            // 
            // horse3Button
            // 
            this.horse3Button.AutoSize = true;
            this.horse3Button.Location = new System.Drawing.Point(388, 71);
            this.horse3Button.Name = "horse3Button";
            this.horse3Button.Size = new System.Drawing.Size(90, 24);
            this.horse3Button.TabIndex = 7;
            this.horse3Button.TabStop = true;
            this.horse3Button.Text = "Horse 3";
            this.horse3Button.UseVisualStyleBackColor = true;
            // 
            // horse4Button
            // 
            this.horse4Button.AutoSize = true;
            this.horse4Button.Location = new System.Drawing.Point(388, 101);
            this.horse4Button.Name = "horse4Button";
            this.horse4Button.Size = new System.Drawing.Size(90, 24);
            this.horse4Button.TabIndex = 8;
            this.horse4Button.TabStop = true;
            this.horse4Button.Text = "Horse 4";
            this.horse4Button.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.horse4Button);
            this.Controls.Add(this.horse3Button);
            this.Controls.Add(this.horse2Button);
            this.Controls.Add(this.horse1Button);
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
        private System.Windows.Forms.RadioButton horse1Button;
        private System.Windows.Forms.RadioButton horse2Button;
        private System.Windows.Forms.RadioButton horse3Button;
        private System.Windows.Forms.RadioButton horse4Button;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox betInfoTextBox;
        private System.Windows.Forms.TextBox raceTextBox;
        private System.Windows.Forms.Button startRaceButton;
    }
}

