using jvyx1q.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace jvyx1q
{
    public partial class UCDetails : UserControl
    {
        Models.Context context = new Models.Context();
        public UCDetails()
        {
            InitializeComponent();
            GetLanguage();
        }

        private void textBoxLanguage_TextChanged(object sender, EventArgs e)
        {
            GetLanguage();
        }
        private void GetLanguage()
        {
            var language = from l in context.Languages
                           where l.Language1.Contains(textBoxLanguage.Text)
                           select l;
            listBoxLanguage.DataSource = language.ToList();
            listBoxLanguage.DisplayMember = "Language1";
        }

        private void listBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            var language = (Language)listBoxLanguage.SelectedItem;
            var film = from f in context.Mlanguages
                       where f.LanguageId == language.LanguageId
                       select f;
            listBoxFilms.DisplayMember = "ID";
            listBoxFilms.DataSource = film.ToList();
        }

        private void listBoxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            var languageofthefilms = (Mlanguage)listBoxFilms.SelectedItem;
            var information = from i in context.Films
                              where i.Id == languageofthefilms.Id
                              select new Movies
                              {
                                  Id = i.Id,
                                  Names = i.Names,
                                  Language1 = languageofthefilms.Language.Language1,
                                  Score = i.Score,
                                  Overview = i.Overview
                              };
            dataGridView1.DataSource = information.ToList();
        }
    }
}
