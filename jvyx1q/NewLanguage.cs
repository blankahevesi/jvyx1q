using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jvyx1q
{
    public partial class NewLanguage : Form
    {
        public NewLanguage()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == true)
            {

                DialogResult = DialogResult.OK;

            }
        }
        private void textBoxID_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[0-9]{1,3}$");
            if (!regex.IsMatch(textBoxID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxID, "Legalább 1 és legfeljebb 3 számjegyű szám kell!");
            }
        }

        private void textBoxID_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxID, string.Empty);
        }

        private bool CheckName(string language)
        {
            return !string.IsNullOrEmpty(language);
        }
        private void textBoxLanguage_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckName(textBoxLanguage.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxLanguage, "Nem lehet üres!");
            }
        }

        private void textBoxLanguage_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxLanguage, string.Empty);
        }


    }
}
