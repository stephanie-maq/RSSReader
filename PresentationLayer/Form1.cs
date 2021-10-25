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
using Models;
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
            Podcast podcast = controller.FetchPodcast(urlBox.Text, categoryDropdown.Text, updateFrequencyDropdown.Text);

            ListViewItem podcastView = new ListViewItem("#" + podcast.NumberOfEpisodes);
            ListViewSubItem nameView = new ListViewSubItem(podcastView, podcast.Name());
            ListViewSubItem frequencyView = new ListViewSubItem(podcastView, podcast.UpdateFrequency.ToString());
            ListViewSubItem categoryView = new ListViewSubItem(podcastView, podcast.Category);


            podcastView.SubItems.Add(nameView);
            podcastView.SubItems.Add(frequencyView);
            podcastView.SubItems.Add(categoryView);

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

        private void newCategory_Click(object sender, EventArgs e)
        {
            string text = categoryTextBox.Text;
            if (!categoriesView.Items.Contains(text))
            {
                categoriesView.Items.Add(text);
                categoryDropdown.Items.Add(text);
                categoryTextBox.Clear();
            }
            // TODO: add else that shows an error message box that category exists
        }

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateFrequencyDropdown.Items.Add("10 sekunder");
            updateFrequencyDropdown.Items.Add("30 sekunder");
            updateFrequencyDropdown.Items.Add("1 minut");
        }

        private void urlBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
