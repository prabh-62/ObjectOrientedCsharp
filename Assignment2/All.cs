using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class All : Form
    {
        public All()
        {
            InitializeComponent();
            if (Globals.data.Count < 0)
            {
                PopulateList pl = new PopulateList();
                pl.loadList();
            }

            display();
        }

        private void display()
        {
            list.Items.Clear();
            var metadata = from c in Globals.data select c;
            foreach (var c in metadata)
            {
                list.Items.Add(c.ToString());
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
