
namespace FinalHangman
{
    partial class Hangman
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.typedAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblChecker = new System.Windows.Forms.Label();
            this.btnNewWord = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblDisplayScore = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // typedAnswer
            // 
            this.typedAnswer.Location = new System.Drawing.Point(12, 67);
            this.typedAnswer.Name = "typedAnswer";
            this.typedAnswer.Size = new System.Drawing.Size(184, 23);
            this.typedAnswer.TabIndex = 0;
            this.typedAnswer.TextChanged += new System.EventHandler(this.typedAnswer_TextChanged);
            this.typedAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.typedAnswer_KeyPress);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(12, 46);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(102, 15);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "Type your guesses";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(12, 19);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(34, 15);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "word";
            // 
            // lblChecker
            // 
            this.lblChecker.AutoSize = true;
            this.lblChecker.Location = new System.Drawing.Point(12, 244);
            this.lblChecker.Name = "lblChecker";
            this.lblChecker.Size = new System.Drawing.Size(38, 15);
            this.lblChecker.TabIndex = 3;
            this.lblChecker.Text = "label1";
            this.lblChecker.Visible = false;
            // 
            // btnNewWord
            // 
            this.btnNewWord.Location = new System.Drawing.Point(433, 281);
            this.btnNewWord.Name = "btnNewWord";
            this.btnNewWord.Size = new System.Drawing.Size(75, 23);
            this.btnNewWord.TabIndex = 4;
            this.btnNewWord.Text = "New word";
            this.btnNewWord.UseVisualStyleBackColor = true;
            this.btnNewWord.Click += new System.EventHandler(this.btnNewWord_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(522, 281);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(85, 23);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(433, 34);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(93, 15);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Correct Answers";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(433, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 133);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "This is the word structure";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 259);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(38, 15);
            this.lblLength.TabIndex = 9;
            this.lblLength.Text = "label1";
            this.lblLength.Visible = false;
            // 
            // lblDisplayScore
            // 
            this.lblDisplayScore.AutoSize = true;
            this.lblDisplayScore.Location = new System.Drawing.Point(433, 181);
            this.lblDisplayScore.Name = "lblDisplayScore";
            this.lblDisplayScore.Size = new System.Drawing.Size(38, 15);
            this.lblDisplayScore.TabIndex = 10;
            this.lblDisplayScore.Text = "label1";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(578, 67);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 94);
            this.listBox2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Incorrect Answers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Score";
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblDisplayScore);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnNewWord);
            this.Controls.Add(this.lblChecker);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.typedAnswer);
            this.Name = "Hangman";
            this.Text = "Hangman Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox typedAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblChecker;
        private System.Windows.Forms.Button btnNewWord;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblDisplayScore;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

