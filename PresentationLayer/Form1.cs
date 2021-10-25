using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLayer;
using static System.Windows.Forms.ListViewItem;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private Controller controller;

        public Form1()
        {
            controller = new Controller();
            InitializeComponent();
        }

        private void lvBokLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void newPodcast_Click(object sender, EventArgs e)
        {
            var podcast = controller.FetchPodcast(urlBox.Text);

            ListViewItem podcastView = new ListViewItem("#" + podcast.NumberOfEpisodes);
            ListViewSubItem nameView = new ListViewSubItem(podcastView, podcast.Name());

            podcastView.SubItems.Add(nameView);

            podcastsView.FullRowSelect = true;

            podcastsView.Items.Add(podcastView);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void urlBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
