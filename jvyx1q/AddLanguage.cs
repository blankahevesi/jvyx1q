using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jvyx1q
{
    public partial class AddLanguage : Form
    {
        Models.Context context = new Models.Context();
        public AddLanguage()
        {
            InitializeComponent();
            languageBindingSource.DataSource = context.Languages.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewLanguage newLanguage = new NewLanguage();
            if (newLanguage.ShowDialog() == DialogResult.OK)
            {
                Models.Language language = new Models.Language();
                language.LanguageId = Convert.ToInt16(newLanguage.textBoxID.Text);
                language.Language1 = newLanguage.textBoxLanguage.Text;
                try
                {
                    context.Languages.Add(language);
                    context.SaveChanges();
                }
                catch (InvalidOperationException opex)
                {
                    MessageBox.Show("Már létező Id, adj meg másikat!");
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);

                }
                languageBindingSource.DataSource = context.Languages.ToList();
            }

        }
    }
}
