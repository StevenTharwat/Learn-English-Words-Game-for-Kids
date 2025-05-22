namespace learnEnglish
{
    partial class Form1
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
            btnCheck = new Button();
            label1 = new Label();
            label2 = new Label();
            txtInputEnglish = new TextBox();
            label3 = new Label();
            LabScore = new Label();
            LabArabicWord = new Label();
            labWrongCounter = new Label();
            labAllComplete = new Label();
            label4 = new Label();
            label5 = new Label();
            labWordsCount = new Label();
            label7 = new Label();
            labPersentage = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(12, 271);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(529, 23);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 142);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 100;
            label1.Text = "Arabic Word";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 203);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 200;
            label2.Text = "English Word";
            // 
            // txtInputEnglish
            // 
            txtInputEnglish.Location = new Point(107, 200);
            txtInputEnglish.Name = "txtInputEnglish";
            txtInputEnglish.Size = new Size(434, 23);
            txtInputEnglish.TabIndex = 0;
            txtInputEnglish.KeyPress += txtInputEnglish_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 88);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 500;
            label3.Text = "Right:";
            label3.Click += label3_Click;
            // 
            // LabScore
            // 
            LabScore.AutoSize = true;
            LabScore.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LabScore.Location = new Point(99, 75);
            LabScore.Name = "LabScore";
            LabScore.Size = new Size(38, 45);
            LabScore.TabIndex = 600;
            LabScore.Text = "0";
            // 
            // LabArabicWord
            // 
            LabArabicWord.AutoSize = true;
            LabArabicWord.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LabArabicWord.Location = new Point(145, 133);
            LabArabicWord.Name = "LabArabicWord";
            LabArabicWord.Size = new Size(60, 32);
            LabArabicWord.TabIndex = 7;
            LabArabicWord.Text = "كلمة";
            // 
            // labWrongCounter
            // 
            labWrongCounter.AutoSize = true;
            labWrongCounter.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labWrongCounter.Location = new Point(256, 75);
            labWrongCounter.Name = "labWrongCounter";
            labWrongCounter.Size = new Size(38, 45);
            labWrongCounter.TabIndex = 601;
            labWrongCounter.Text = "0";
            // 
            // labAllComplete
            // 
            labAllComplete.AutoSize = true;
            labAllComplete.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labAllComplete.Location = new Point(431, 75);
            labAllComplete.Name = "labAllComplete";
            labAllComplete.Size = new Size(38, 45);
            labAllComplete.TabIndex = 602;
            labAllComplete.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(176, 88);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 603;
            label4.Text = "Wrong:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(328, 88);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 604;
            label5.Text = "Complete:";
            // 
            // labWordsCount
            // 
            labWordsCount.AutoSize = true;
            labWordsCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labWordsCount.Location = new Point(156, 12);
            labWordsCount.Name = "labWordsCount";
            labWordsCount.Size = new Size(38, 45);
            labWordsCount.TabIndex = 606;
            labWordsCount.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(24, 25);
            label7.Name = "label7";
            label7.Size = new Size(126, 25);
            label7.TabIndex = 605;
            label7.Text = "Words Count:";
            // 
            // labPersentage
            // 
            labPersentage.AutoSize = true;
            labPersentage.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labPersentage.Location = new Point(431, 12);
            labPersentage.Name = "labPersentage";
            labPersentage.Size = new Size(66, 45);
            labPersentage.TabIndex = 608;
            labPersentage.Text = "0%";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(314, 25);
            label9.Name = "label9";
            label9.Size = new Size(111, 25);
            label9.TabIndex = 607;
            label9.Text = "percentage:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 320);
            Controls.Add(labPersentage);
            Controls.Add(label9);
            Controls.Add(labWordsCount);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(labAllComplete);
            Controls.Add(labWrongCounter);
            Controls.Add(LabArabicWord);
            Controls.Add(LabScore);
            Controls.Add(label3);
            Controls.Add(txtInputEnglish);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCheck);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Challenge";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheck;
        private Label label1;
        private Label label2;
        private TextBox txtInputEnglish;
        private Label label3;
        private Label LabScore;
        private Label LabArabicWord;
        private Button btn;
        private Label labWrongCounter;
        private Label labAllComplete;
        private Label label4;
        private Label label5;
        private Label labWordsCount;
        private Label label7;
        private Label labPersentage;
        private Label label9;
    }
}