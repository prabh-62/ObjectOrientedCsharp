using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Populate List
            PopulateList pl = new PopulateList();
            pl.loadList();

            //Load ComboBox
            comboTitle.DataSource = Globals.data;
            comboTitle.DisplayMember = "Title";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            richBox.Clear();
            richBox.Font = new Font("Courier New", richBox.Font.Size, FontStyle.Regular);
            richBox.ForeColor = Color.Purple;
            richBox.Text = Globals.data[comboTitle.SelectedIndex].ToString();
        }


        private void summarise() {
            All a = new All();
            a.Show();
        }
        private void moviesByRating()
        {
            list.Items.Clear();
            var movies = Globals.data.Where(c => c.Type == "Movie").OrderBy(c => c.Type).Select(c => c);
            foreach (var m in movies)
            {
                                list.Items.Add(m.ToString());
            }
        }

        private void musicByGenre()
        {
            list.Items.Clear();
            var genre = Globals.data.Where(c => c.Genre == "Pop").Select(c => c);
            foreach (var g in genre)
            {
                               list.Items.Add(g.ToString());
            }
        }
        private void summary_Click(object sender, EventArgs e)
        {
            summarise();
        }

        private void movieRatings_Click(object sender, EventArgs e)
        {
            moviesByRating();
        }
        private void musisGenre_Click(object sender, EventArgs e)
        {
            musicByGenre();
        }

        //Context menus
        private void moviesByRatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moviesByRating();
        }
        private void musicByGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicByGenre();
        }
        private void viewSummaryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            summarise();
        }

        //Menu
        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moviesByRating();
        }

        private void viewSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicByGenre();
        }

        private void viewSummaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            summarise();
        }
    }
}
