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

        private void episodesView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (podcastsView.SelectedItems.Count == 1)
            {
                string title = podcastsView.SelectedItems[0].SubItems[1].Text;
                (bool exists, Podcast podcast) = controller.GetPodcastByTitle(title);
                podcast.Episodes.Reverse();

                if (exists)
                {
                    for (int i = 0; i < podcast.Episodes.Count; i++)
                    {
                        int episodeNumber = i + 1;
                        string episodeName = podcast.Episodes[i].Title;
                        episodesView.Items.Add($"#{episodeNumber} - {episodeName}");
                    }
                }
            }
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

        private async void newPodcast_Click(object sender, EventArgs e)
        {
            Podcast podcast = await controller.FetchPodcastAsync(urlBox.Text, categoryDropdown.Text, updateFrequencyDropdown.Text);

            ListViewItem podcastView = new ListViewItem("#" + podcast.Episodes.Count);

            ListViewSubItem nameView;
            if (titleBox.Text.Equals(""))
            {
                nameView = new ListViewSubItem(podcastView, podcast.Title);
            }
            else
            {
                nameView = new ListViewSubItem(podcastView, titleBox.Text);
            }

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

        private void episodeView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (podcastsView.SelectedItems.Count == 1)
            {
                string title = episodesView.SelectedItem.ToString().Split('-')[1].TrimStart();
                (bool exists, Episode episode) = controller.GetEpisodeByTitle(title);

                if (exists)
                {
                    episodeDescriptionView.Text = episode.Description;
                }
            }
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
