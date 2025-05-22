namespace learnEnglish
{
    partial class AddWords
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.WordsGrid = new System.Windows.Forms.DataGridView();
            this.btnDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArabicWord = new System.Windows.Forms.TextBox();
            this.txtEnglishWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WordsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(152, 304);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(292, 304);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // WordsGrid
            // 
            this.WordsGrid.AllowUserToAddRows = false;
            this.WordsGrid.AllowUserToDeleteRows = false;
            this.WordsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WordsGrid.Location = new System.Drawing.Point(12, 12);
            this.WordsGrid.Name = "WordsGrid";
            this.WordsGrid.ReadOnly = true;
            this.WordsGrid.RowTemplate.Height = 25;
            this.WordsGrid.Size = new System.Drawing.Size(356, 150);
            this.WordsGrid.TabIndex = 7;
            this.WordsGrid.Click += new System.EventHandler(this.WordsGrid_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(12, 367);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(356, 23);
            this.btnDone.TabIndex = 6;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 500;
            this.label1.Text = "Arabic Word";
            // 
            // txtArabicWord
            // 
            this.txtArabicWord.Location = new System.Drawing.Point(115, 200);
            this.txtArabicWord.Name = "txtArabicWord";
            this.txtArabicWord.Size = new System.Drawing.Size(252, 23);
            this.txtArabicWord.TabIndex = 0;
            // 
            // txtEnglishWord
            // 
            this.txtEnglishWord.Location = new System.Drawing.Point(115, 240);
            this.txtEnglishWord.Name = "txtEnglishWord";
            this.txtEnglishWord.Size = new System.Drawing.Size(252, 23);
            this.txtEnglishWord.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 700;
            this.label2.Text = "English Word";
            // 
            // AddWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 415);
            this.Controls.Add(this.txtEnglishWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArabicWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.WordsGrid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddWords";
            this.Text = "Add Words";
            this.Load += new System.EventHandler(this.AddWords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WordsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView WordsGrid;
        private Button btnDone;
        private Label label1;
        private TextBox txtArabicWord;
        private TextBox txtEnglishWord;
        private Label label2;
    }
}