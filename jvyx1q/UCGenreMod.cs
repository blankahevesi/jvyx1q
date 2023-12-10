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
    public partial class UCGenreMod : UserControl
    {
        Models.Context context = new Models.Context();
        public UCGenreMod()
        {
            InitializeComponent();
            mgenreBindingSource.DataSource = context.Mgenres.ToList();
            filmBindingSource.DataSource = context.Films.ToList();
            genreBindingSource.DataSource = context.Genres.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
