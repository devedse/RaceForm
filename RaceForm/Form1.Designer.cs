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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StartRaceButton = new System.Windows.Forms.Button();
            this.Mark = new System.Windows.Forms.Label();
            this.Harald = new System.Windows.Forms.Label();
            this.Ketty = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(573, 481);
            this.textBox1.TabIndex = 0;
            // 
            // StartRaceButton
            // 
            this.StartRaceButton.Location = new System.Drawing.Point(867, 443);
            this.StartRaceButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartRaceButton.Name = "StartRaceButton";
            this.StartRaceButton.Size = new System.Drawing.Size(142, 90);
            this.StartRaceButton.TabIndex = 1;
            this.StartRaceButton.Text = "Start Race!";
            this.StartRaceButton.UseVisualStyleBackColor = true;
            this.StartRaceButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mark
            // 
            this.Mark.AutoSize = true;
            this.Mark.Location = new System.Drawing.Point(686, 55);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(44, 20);
            this.Mark.TabIndex = 2;
            this.Mark.Text = "Mark";
            // 
            // Harald
            // 
            this.Harald.AutoSize = true;
            this.Harald.Location = new System.Drawing.Point(686, 102);
            this.Harald.Name = "Harald";
            this.Harald.Size = new System.Drawing.Size(56, 20);
            this.Harald.TabIndex = 3;
            this.Harald.Text = "Harald";
            // 
            // Ketty
            // 
            this.Ketty.AutoSize = true;
            this.Ketty.Location = new System.Drawing.Point(686, 152);
            this.Ketty.Name = "Ketty";
            this.Ketty.Size = new System.Drawing.Size(45, 20);
            this.Ketty.TabIndex = 4;
            this.Ketty.Text = "Ketty";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(776, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(776, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(776, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 741);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Ketty);
            this.Controls.Add(this.Harald);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.StartRaceButton);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button StartRaceButton;
        private System.Windows.Forms.Label Mark;
        private System.Windows.Forms.Label Harald;
        private System.Windows.Forms.Label Ketty;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

