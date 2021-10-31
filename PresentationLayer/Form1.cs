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
        private CategoryController categoryController;
        private EpisodeController episodeController;

        public Form1()
        {
            controller = new Controller();
            categoryController = new CategoryController();
            episodeController = new EpisodeController();
            InitializeComponent();
            DisplayPodcasts(controller.GetAllPodcasts());
        }

        private void lvBokLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Podcast podcast = controller.FetchPodcast(urlBox.Text, categoryDropdown.Text, updateFrequencyDropdown.Text);

            //LBAvsnitt.Items.Clear();
            //foreach (var item in podcast.Episodes)
            //{

            //    LBAvsnitt.Items.Add(item.GetName());
            //    LBAvsnitt.Items.Add(" ");

            //}



            //string name = podcastsView.SelectedItems[0].SubItems[1].Text;
            //Channel podcast = controller.GetPodcastByName(name);

            //foreach (var item in podcast.Episodes)
            //{
            //    LBAvsnitt.Items.Add(item.Name.ToString());
            //}

            ClearEpisodeInfo();
            //Om en podcast är vald hämtas information om podcasten och fylls i respektive textfält/combobox.
            if (podcastsView.SelectedItems.Count == 1)
            {
                string title = podcastsView.SelectedItems[0].SubItems[1].Text;
                string updateInterval = podcastsView.Items[podcastsView.SelectedIndices[0]].SubItems[2].Text;
                string category = podcastsView.Items[podcastsView.SelectedIndices[0]].SubItems[3].Text;
                string url = controller.GetUrlByTitle(title);
                urlBox.Text = url;
                labelTitel.Text = title; 
                txtTitel.Text = title;
                updateFrequencyDropdown.SelectedItem = updateInterval;
                categoryDropdown.SelectedItem = category;
                btnTaBortPodd.Enabled = true;
                btnSparaPodd.Enabled = true;
                newPodcast.Enabled = false;

                foreach (var item in controller.GetAllPodcasts())
                {
                    if (item.Name.Equals(title))
                    {
                        int numberEpisode = 1;
                        foreach (var item2 in item.Episodes) //Hämtar antal avsnitt för vald podcast
                        {
                            LBAvsnitt.Items.Add("* " + item2.Name);
                            numberEpisode++;
                        }
                    }
                }
                controller.GetEpisodes(title); //Hämtar avsnitten för vald podcast
                txtBoxEpisodeDesc.Clear();
            }
            else
            {
                ClearEpisodeInfo();
                ClearTxtNameAndUrl();
                newPodcast.Enabled = true;
                btnTaBortPodd.Enabled = false;
                btnSparaPodd.Enabled = false;
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

        private void newPodcast_Click(object sender, EventArgs e)
        {
            //Podcast podcast = controller.FetchPodcast(urlBox.Text, categoryDropdown.Text, updateFrequencyDropdown.Text);

            //ListViewItem podcastView = new ListViewItem("#" + podcast.NumberOfEpisodes);
            //ListViewSubItem nameView = new ListViewSubItem(podcastView, podcast.Name());
            //ListViewSubItem frequencyView = new ListViewSubItem(podcastView, podcast.UpdateFrequency.ToString());
            //ListViewSubItem categoryView = new ListViewSubItem(podcastView, podcast.Category);


            //podcastView.SubItems.Add(nameView);
            //podcastView.SubItems.Add(frequencyView);
            //podcastView.SubItems.Add(categoryView);

            //podcastsView.FullRowSelect = true;

            //podcastsView.Items.Add(podcastView);
            string category = this.categoryDropdown.GetItemText(this.categoryDropdown.SelectedItem);
            string interval = this.updateFrequencyDropdown.GetItemText(this.updateFrequencyDropdown.SelectedItem);


            controller.CreateChannel(urlBox.Text, txtTitel.Text, category, interval);

            // ------------ Visa Podcast infon i Listviewn --------

            List<Episode> listOfEpisodes = new List<Episode>();
            listOfEpisodes = episodeController.GetEpisodesByUrl(urlBox.Text);

            ListViewItem podcastView = new ListViewItem("#" + listOfEpisodes.Count);
            ListViewSubItem nameView = new ListViewSubItem(podcastView, txtTitel.Text);
            ListViewSubItem frequencyView = new ListViewSubItem(podcastView, interval);
            ListViewSubItem categoryView = new ListViewSubItem(podcastView, category);

            podcastView.SubItems.Add(nameView);
            podcastView.SubItems.Add(frequencyView);
            podcastView.SubItems.Add(categoryView);

            podcastsView.Items.Add(podcastView);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string someText = LBAvsnitt.SelectedItem.ToString();

            List<Channel> allPodcasts = controller.GetAllPodcasts();
            foreach (var item in allPodcasts)
            {
                List<Episode> allEpisodes = item.Episodes;
                foreach (var episode in allEpisodes)
                {
                    if (episode.Name == someText)
                    {
                        txtBoxEpisodeDesc.Text = episode.Description;
                    }
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void newCategory_Click(object sender, EventArgs e)
        {
            categoryController.CreateCategory(categoryTextBox.Text.ToString());
            categoriesView.Items.Add(categoryTextBox.Text);
            categoryDropdown.Items.Add(categoryTextBox.Text);
            categoryTextBox.Clear();


            //string text = categoryTextBox.Text;
            //if (!categoriesView.Items.Contains(text))
            //{
            //    categoriesView.Items.Add(text);
            //    categoryDropdown.Items.Add(text);
            //    categoryTextBox.Clear();
            //}
            //// TODO: add else that shows an error message box that category exists
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    List<Channel> allPods = new List<Channel>();
            //    allPods = controller.GetPodcasts();

            //    foreach (var item in allPods)
            //    {
            //        ListViewItem podcastView = new ListViewItem("#" + item.Episodes.Count);
            //        ListViewSubItem nameView = new ListViewSubItem(podcastView, item.Name.ToString());
            //        ListViewSubItem frequencyView = new ListViewSubItem(podcastView, item.Interval.ToString());
            //        ListViewSubItem categoryView = new ListViewSubItem(podcastView, item.Category.ToString());

            //        podcastView.SubItems.Add(nameView);
            //        podcastView.SubItems.Add(frequencyView);
            //        podcastView.SubItems.Add(categoryView);

            //        podcastsView.Items.Add(podcastView);
            //    }
            //}
            //catch (Exception exception)
            //{

            //    throw new Exception(exception.Message);
            //}

        }

        private void ShowPodcasts(List<Channel> podcastsShow)
        {
            //try
            //{
            //    List<Channel> allPods = new List<Channel>();
            //    allPods = controller.GetPodcasts();

            //    foreach (var item in allPods)
            //    {
            //        ListViewItem podcastView = new ListViewItem("#" + item.Episodes.Count);
            //        ListViewSubItem nameView = new ListViewSubItem(podcastView, item.Name.ToString());
            //        ListViewSubItem frequencyView = new ListViewSubItem(podcastView, item.Interval.ToString());
            //        ListViewSubItem categoryView = new ListViewSubItem(podcastView, item.Category.ToString());

            //        podcastView.SubItems.Add(nameView);
            //        podcastView.SubItems.Add(frequencyView);
            //        podcastView.SubItems.Add(categoryView);

            //        podcastsView.Items.Add(podcastView);
            //    }
            //}
            //catch (Exception exception)
            //{

            //    throw new Exception(exception.Message);
            //}

            //List<Channel> testType = new List<Channel>();
            //List<Category> testCat = new List<Category>();

            //categoryTextBox.Text = testType.GetType().ToString();
            //categoriesView.Items.Add(testType.GetType().ToString());
            //categoriesView.Items.Add(testCat.GetType().ToString());
        }
        private void DisplayPodcasts(List<Channel> podcastsToDisplay)
        {
            podcastsView.Items.Clear();

            foreach (var item in podcastsToDisplay)
            {
                if (item != null)
                {
                    string numberOfEpisodes = item.Episodes.Count().ToString();
                    ListViewItem newList = new ListViewItem(numberOfEpisodes);
                    newList.SubItems.Add(item.Name);
                    newList.SubItems.Add(item.Interval.ToString());
                    newList.SubItems.Add(item.Category);
                    podcastsView.Items.Add(newList);
                }
            }
            
        }
        private void ClearEpisodeInfo()
        {
            txtBoxEpisodeDesc.Clear();
            LBAvsnitt.Items.Clear();
        }
        private void ClearTxtNameAndUrl()
        {
            urlBox.Clear();
            txtTitel.Clear();
            labelTitel.Text = "Podcastnamn";
        }
    }
}
