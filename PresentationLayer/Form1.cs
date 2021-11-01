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
    public partial class App : Form
    {
        private PodcastController podcastController;
        private CategoryController categoryController;

        public App()
        {
            podcastController = new PodcastController();
            categoryController = new CategoryController();
            InitializeComponent();
            Task.Run(() => podcastController.KeepPodcastsUpToDate());
        }

        private void episodesView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (podcastsView.SelectedItems.Count == 1)
            {
                string title = podcastsView.SelectedItems[0].SubItems[1].Text;
                (bool exists, Podcast podcast) = podcastController.GetPodcastByTitle(title);
                podcast.Episodes.Reverse();

                if (exists)
                {
                    for (int i = 0; i < podcast.Episodes.Count; i++)
                    {
                        int episodeNumber = i + 1;
                        string episodeName = podcast.Episodes[i].Title;
                        episodesView.Items.Add($"#{episodeNumber} - {episodeName}");
                    }
                    urlBox.Text = podcast.Url;
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

        private void UpdatePodcastsViewWith(List<Podcast> podcasts)
        {
            podcastsView.Items.Clear();

            podcasts.ForEach(podcast =>
            {
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
                ListViewSubItem categoryView = new ListViewSubItem(podcastView, podcast.Category.Name);


                podcastView.SubItems.Add(nameView);
                podcastView.SubItems.Add(frequencyView);
                podcastView.SubItems.Add(categoryView);

                podcastsView.FullRowSelect = true;

                podcastsView.Items.Add(podcastView);
            });


        }

        private void UpdatePodcastsView()
        {
            UpdatePodcastsViewWith(podcastController.GetAllPodcasts());
        }

        private void ClearLeftBoxes()
        {
            urlBox.Clear();
            titleBox.Clear();
            episodesView.Items.Clear();
        }


        private async void newPodcast_Click(object sender, EventArgs e)
        {
            await podcastController.FetchPodcastAsync(urlBox.Text, categoryDropdown.Text, updateFrequencyDropdown.Text);
            UpdatePodcastsView();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void episodeView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (podcastsView.SelectedItems.Count == 1)
            {
                string title = episodesView.SelectedItem.ToString().Split('-')[1].TrimStart();
                string desc = podcastController.GetEpisodeDescriptionByTitle(title);
                episodeDescriptionView.Text = desc;
                episodeDescriptionView.Update();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void UpdateCategoriesView()
        {
            categoriesView.Items.Clear();
            categoryDropdown.Items.Clear();
            categoryController.GetAllCategories().ForEach(cat =>
                {
                    categoriesView.Items.Add(cat.Name);
                    categoryDropdown.Items.Add(cat.Name);
                });
        }

        private void newCategory_Click(object sender, EventArgs e)
        {
            string category = categoryTextBox.Text;

            try
            {
                categoryController.AddNewCategory(category);
            }
            catch (CustomExceptions.ItemAlreadyExistsException exn)
            {
                MessageBox.Show(exn.Message);
            }

            UpdateCategoriesView();
            categoryTextBox.Clear();
        }

        private void categoriesView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoriesView.SelectedItems.Count == 1)
            {
                string category = categoriesView.SelectedItem.ToString();
                List<Podcast> filteredPodcasts = podcastController.GetPodcastsbyCategory(category);
                UpdatePodcastsViewWith(filteredPodcasts);
            }
            else
            {
                UpdatePodcastsView();
            }
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

        private void updatePodcast_Click(object sender, EventArgs e)
        {
            if (!titleBox.Text.Equals(""))
            {
                podcastController.UpdatePodcastTitle(urlBox.Text, titleBox.Text);
            }
            podcastController.UpdatePodcastCategory(urlBox.Text, categoryDropdown.Text);
            podcastController.UpdatePodcastIntervalFrequency(urlBox.Text, updateFrequencyDropdown.Text);
            UpdatePodcastsView();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void deletePodcast_Click(object sender, EventArgs e)
        {
            podcastController.DeletePodcast(urlBox.Text);
            UpdatePodcastsView();
            ClearLeftBoxes();
        }

        private void episodeDescriptionView_TextChanged(object sender, EventArgs e)
        {

        }


        private void updateCategory_Click(object sender, EventArgs e)
        {
            if (categoriesView.SelectedItems.Count == 1)
            {
                string category = categoriesView.SelectedItem.ToString();
                podcastController.UpdateCategoryTitle(category, categoryTextBox.Text);
                categoryController.UpdateCategoryTitle(category, categoryTextBox.Text);
                UpdateCategoriesView();
                UpdatePodcastsView();
                categoryTextBox.Clear();
            }

        }

        private void deleteCategory_Click(object sender, EventArgs e)
        {
            if (categoriesView.SelectedItems.Count == 1)
            {
                string category = categoriesView.SelectedItem.ToString();

                DialogResult yesNo = MessageBox.Show("Är du säker att du vill ta bort kategorin: " + category, "Ta bort", MessageBoxButtons.YesNo);

                if (yesNo == DialogResult.Yes)
                {
                    podcastController.RemovePodcastsByCategory(category);
                    categoryController.RemoveCategoryByName(category);
                    UpdatePodcastsView();
                    UpdateCategoriesView();
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void unselectCategory_Click(object sender, EventArgs e)
        {
            categoriesView.ClearSelected();
        }
    }
}
