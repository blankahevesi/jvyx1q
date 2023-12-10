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

namespace jvyx1q
{
    public partial class LanguageModification : Form
    {
        Models.Context context = new Models.Context();
        public LanguageModification()
        {
            InitializeComponent();
            GetFilms();
            GetLanguage();
        }

        private void textBoxFilm_TextChanged(object sender, EventArgs e)
        {
            GetFilms();
        }
        private void GetFilms()
        {
            var film = from f in context.Films
                       where f.Names.Contains(textBoxFilm.Text)
                       select f;
            listBoxFilm.DataSource = film.ToList();
            listBoxFilm.DisplayMember = "Names";
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

        private void listBoxFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            Languageofthefilm();
        }
        private void Languageofthefilm()
        {
            var selectedFilm = (Film)listBoxFilm.SelectedItem;
            var languageofthefilm = from f in context.Mlanguages
                                    where f.MovieId == selectedFilm.Id
                                    select new Languagesofthefilm
                                    {
                                        LanguageId = f.Language.LanguageId,
                                        Language1 = f.Language.Language1,
                                        MovieId = f.MovieId,
                                        Id = f.Id
                                    };

            ListBoxAddLanguage.DataSource = languageofthefilm.ToList();
            ListBoxAddLanguage.DisplayMember = "Language1";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Film selectedFilm = (Film)listBoxFilm.SelectedItem;
            Language selectedLanguage = (Language)listBoxLanguage.SelectedItem;
            Mlanguage newLanguage = new Mlanguage();
            newLanguage.LanguageId = selectedLanguage.LanguageId;
            newLanguage.MovieId = selectedFilm.Id;

            context.Mlanguages.Add(newLanguage);
            try
            {

                context.SaveChanges();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            Languageofthefilm();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

            var selectedLanguage = (Languagesofthefilm)ListBoxAddLanguage.SelectedItem;

            // Ellenőrizze, hogy van-e kiválasztott elem
            if (selectedLanguage == null)
            {
                MessageBox.Show("Nincs kiválasztott nyelv a törléshez.");
                return;
            }

            // Megerősítési ablak megjelenítése
            var confirmation = MessageBox.Show("Biztosan törölni szeretné ezt a nyelvet?", "Megerősítés", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                // Nyelv törlése az adatbázisból
                var languagetobedeleted = (from l in context.Mlanguages
                                           where l.Id == selectedLanguage.Id
                                           select l).FirstOrDefault();

                if (languagetobedeleted != null)
                {
                    context.Mlanguages.Remove(languagetobedeleted);

                    try
                    {
                        context.SaveChanges();
                        Languageofthefilm();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
                else
                {
                    MessageBox.Show("A kiválasztott nyelvet nem találta az adatbázisban.");
                }
            }
            else
            {
                // A felhasználó nem erősítette meg a törlést
            }
        }
    }
}
