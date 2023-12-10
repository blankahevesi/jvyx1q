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
    public partial class UCGenre : UserControl
    {
        Models.Context context = new Models.Context();
        public UCGenre()
        {
            InitializeComponent();
            GetGenre();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetGenre();
        }

        private void GetGenre()
        {
            var genre = from g in context.Genres
                        where g.GenreName.Contains(textBox1.Text)
                        select g;
            listBox1.DataSource = genre.ToList();
            listBox1.DisplayMember = "GenreName";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Genre genre = (Genre)listBox1.SelectedItem;
            var film = from f in context.Mgenres
                       where f.GenreId == genre.GenreId
                       select new
                       {
                           film = f.Movie.Names
                       };
            dataGridView1.DataSource = film.ToList();
            var count = (from m in film select m.film).Count();
            textBox2.Text = count.ToString();

            var genreofthefilm = (from g in context.Mgenres
                                  where g.GenreId == genre.GenreId
                                  select g).FirstOrDefault();
            label1.Text = $"{genreofthefilm.Genre.GenreName} movies";
        }
    }
}
