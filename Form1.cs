namespace learnEnglish
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int score = 0;
        int wrongScore = 0;
        int allComplete = 0;
        int wordsCount = 0;
        private List<string> wordList;

        public Form1()
        {
            InitializeComponent();
            stat.init();
            wordList = stat.words.Keys.ToList();
            wordsCount= wordList.Count;
            labWordsCount.Text = wordsCount.ToString();
            getRandomWord();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputEnglish.Text.Trim()))
            {
                MessageBox.Show("Enter the English word");
                txtInputEnglish.Text = "";
                return;
            }
            else
            {
                if (stat.words.Count > 0)
                {

                    if (stat.words[LabArabicWord.Text].ToLower() == txtInputEnglish.Text.Trim().ToLower())
                    {
                        score++;
                        LabScore.Text = score.ToString();
                        LabScore.ForeColor = Color.Green;
                        //add to right List
                        wordList.Remove(LabArabicWord.Text);
                    }
                    else
                    {
                        wrongScore++;
                        labWrongCounter.Text = wrongScore.ToString();
                        labWrongCounter.ForeColor = Color.Red;
                        //add to wrong json
                        stat.addToWrongJson(LabArabicWord.Text, txtInputEnglish.Text);
                        MessageBox.Show("the right word is: "+stat.words[LabArabicWord.Text].ToLower());
                    }
                }
            }
            try
            {
                double p = ((double)score - (double)wrongScore) / (double)wordsCount * 100;
                labPersentage.Text = Math.Round((double)p,2).ToString()+"%";

            }
            catch (Exception)
            {
                labPersentage.Text = "0";


            }
            getRandomWord();
            txtInputEnglish.Text = "";
        }

        void getRandomWord()
        {
            if (wordList.Count == 0)
            {
                wordList = stat.words.Keys.ToList();
                allComplete++;
                score = 0;
                wrongScore = 0;
                LabScore.Text = score.ToString();
                LabScore.ForeColor = Color.Black;
                labWrongCounter.Text = wrongScore.ToString();
                labWrongCounter.ForeColor = Color.Black;
                labAllComplete.Text = allComplete.ToString();
                labAllComplete.ForeColor = Color.Purple;
            }

            if (wordList.Count > 0)
            {
                LabArabicWord.Text = wordList.ElementAt(r.Next(0, wordList.Count));
                //LabArabicWord.Text = stat.words.ElementAt(r.Next(0, stat.words.Count)).Key;
            }
            else
            {
                LabArabicWord.Text = "__";

            }
        }

        private void txtInputEnglish_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCheck_Click(null, null);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}