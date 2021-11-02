﻿using System;
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

        public App(string podcastsFile, string categoryFile)
        {
            podcastController = new PodcastController(podcastsFile);
            categoryController = new CategoryController(categoryFile);
            InitializeComponent();
            podcastController.LoadFromFile();
            categoryController.LoadFromFile();
            UpdatePodcastsView();
            UpdateCategoriesView();
            // Start 3 threads that check for updates given some intervall.
            //Task.Run(() => podcastController.UpdateWithIntervall(10));
            //Task.Run(() => podcastController.UpdateWithIntervall(30));
            //Task.Run(() => podcastController.UpdateWithIntervall(60));
        }

        private void episodesView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (podcastsView.SelectedItems.Count == 1)
            {
                string title = podcastsView.SelectedItems[0].SubItems[1].Text;
                (string url, List<string> eps) = podcastController.GetPodcastUrlAndEpisodesByTitle(title);

                if (eps.Count > 0)
                {
                    episodesView.Items.Clear();
                    eps.ForEach(ep => episodesView.Items.Add(ep));
                    urlBox.Text = url;
                }
            }
        }

        private void UpdatePodcastsViewWith(ICollection<Podcast> podcasts)
        {
            podcastsView.Items.Clear();

            foreach (Podcast podcast in podcasts)
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
            }
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


        private void episodeView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (podcastsView.SelectedItems.Count == 1)
            {
                string title = episodesView.SelectedItem.ToString().Trim();
                string desc = podcastController.GetEpisodeDescriptionByTitle(title);
                episodeDescriptionView.Text = desc;
                episodeDescriptionView.Update();
            }
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


        private void updatePodcast_Click(object sender, EventArgs e)
        {
            episodesView.Items.Clear();

            if (!titleBox.Text.Equals(""))
            {
                podcastController.UpdatePodcastTitle(urlBox.Text, titleBox.Text);
            }

            if (!categoryDropdown.Text.Equals(""))
            {
                podcastController.UpdatePodcastCategory(urlBox.Text, categoryDropdown.Text);
            }

            if (!updateFrequencyDropdown.Text.Equals(""))
            {
                podcastController.UpdatePodcastIntervalFrequency(urlBox.Text, updateFrequencyDropdown.Text);
            }

            titleBox.Clear();
            UpdatePodcastsView();
        }

        private void deletePodcast_Click(object sender, EventArgs e)
        {
            podcastController.DeletePodcast(urlBox.Text);
            UpdatePodcastsView();
            ClearLeftBoxes();
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

        private void unselectCategory_Click(object sender, EventArgs e)
        {
            categoriesView.ClearSelected();
        }

        private void savePodcasts_Click(object sender, EventArgs e)
        {
            categoryController.SaveAllCategories();
            podcastController.SaveAllPodcasts();
        }

        private void saveCategories_Click(object sender, EventArgs e)
        {
            categoryController.SaveAllCategories();
            podcastController.SaveAllPodcasts();
        }

        private void app_Closing(object sender, EventArgs e)
        {
            bool catSaved = categoryController.IsAllSaved();
            bool podSaved = podcastController.IsAllSaved();

            if (!catSaved || !podSaved)
            {
                DialogResult save = MessageBox.Show("Du har inte sparat allt. Vill du göra det?", "Spara", MessageBoxButtons.YesNo);
                if (save == DialogResult.Yes)
                {
                    categoryController.SaveAllCategories();
                    podcastController.SaveAllPodcasts();
                }
            }
        }
    }
}
