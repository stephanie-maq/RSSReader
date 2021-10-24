using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel.Syndication;
using System.Xml;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
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

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            lbKategorier.Items.Add(txtKategorier.Text);
            cbKategori.Items.Add(txtKategorier.Text);
            txtKategorier.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbUpdFrekvens.Items.Add("10 sekunder");
            cbUpdFrekvens.Items.Add("30 sekunder");
            cbUpdFrekvens.Items.Add("1 minut");
        }

        private void btnNyPodd_Click(object sender, EventArgs e)
        {
            try
            {
                XmlReader reader = XmlReader.Create(txtURL.Text);
                SyndicationFeed feed = SyndicationFeed.Load(reader);



                List<SyndicationItem> itemList = new List<SyndicationItem>();

                foreach (SyndicationItem feedItem in feed.Items)
                {
                    itemList.Add(feedItem);

                }



                ListViewItem eachRow = new ListViewItem("#" + itemList.Count.ToString());
                ListViewItem.ListViewSubItem rowName = new ListViewItem.ListViewSubItem(eachRow, feed.Title.Text);
                ListViewItem.ListViewSubItem intervalFrequency = new ListViewItem.ListViewSubItem(eachRow, cbUpdFrekvens.Text);
                ListViewItem.ListViewSubItem categoryName = new ListViewItem.ListViewSubItem(eachRow, cbKategori.Text);


                eachRow.SubItems.Add(rowName);
                eachRow.SubItems.Add(intervalFrequency);
                eachRow.SubItems.Add(categoryName);

                lvBokLista.FullRowSelect = true;

                lvBokLista.Items.Add(eachRow);




            }
            catch (Exception)
            {

            }
        }

        private void lvBokLista_MouseClick(object sender, MouseEventArgs e)
        {
            XmlReader reader = XmlReader.Create(txtURL.Text);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            List<SyndicationItem> itemList = new List<SyndicationItem>();


            foreach (SyndicationItem feedItem in feed.Items)
            {
                itemList.Add(feedItem);
                LBAvsnitt.Items.Add("Avsnitt #" + itemList.Count);

            }

            //LBAvsnitt.Items.Add(itemList);
        }
    }
}
