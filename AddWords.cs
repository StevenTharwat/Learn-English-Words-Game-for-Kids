using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learnEnglish
{
    public partial class AddWords : Form
    {
        int selectedIndex = -1;
        public AddWords()
        {
            InitializeComponent();
        }

        private void AddWords_Load(object sender, EventArgs e)
        {
            try
            {
                afterBtn();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        bool ifOk()
        {
            if (string.IsNullOrEmpty(txtArabicWord.Text.Trim()) || string.IsNullOrEmpty(txtEnglishWord.Text.Trim()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {

            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
            if (ifOk())
            {
                stat.words.Add(txtArabicWord.Text, txtEnglishWord.Text.ToLower());
            }
                afterBtn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
            if (ifOk())
            {
                stat.words.Remove(txtArabicWord.Text);
            }
                afterBtn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
            if (ifOk())
            {
                stat.words.Remove(txtArabicWord.Text);
                stat.words.Add(txtArabicWord.Text, txtEnglishWord.Text.ToLower());
            }
                afterBtn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WordsGrid_Click(object sender, EventArgs e)
        {
            try
            {
                selectedIndex = WordsGrid.SelectedRows[0].Index;
                txtArabicWord.Text = stat.words.ElementAt(selectedIndex).Key;
                txtEnglishWord.Text = stat.words.ElementAt(selectedIndex).Value;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void afterBtn()
        {
            WordsGrid.DataSource = stat.words.ToArray();
            txtArabicWord.Text = "";
            txtEnglishWord.Text = "";
            //json = dic
            stat.CreateDefaultJsonFile();
        }
    }
}
