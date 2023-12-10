namespace jvyx1q
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailUCs detailUCs = new DetailUCs();
            detailUCs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddLanguage addLanguage = new AddLanguage();
            addLanguage.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LanguageModification languageModification = new LanguageModification();
            languageModification.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan szeretn�d bez�rni az alkalmaz�st?", "K�rd�s", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}