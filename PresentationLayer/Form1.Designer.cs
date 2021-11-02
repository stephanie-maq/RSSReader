
namespace PresentationLayer
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.podcastsView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateFrequencyDropdown = new System.Windows.Forms.ComboBox();
            this.newPodcast = new System.Windows.Forms.Button();
            this.btnTaBortPodd = new System.Windows.Forms.Button();
            this.episodesView = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.episodeDescriptionView = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.categoriesView = new System.Windows.Forms.ListBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.btnTaBortCat = new System.Windows.Forms.Button();
            this.newCategory = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.btnUppdateraPodd = new System.Windows.Forms.Button();
            this.btnUppdateraCat = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // podcastsView
            // 
            this.podcastsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.podcastsView.HideSelection = false;
            this.podcastsView.LabelEdit = true;
            this.podcastsView.Location = new System.Drawing.Point(33, 39);
            this.podcastsView.Margin = new System.Windows.Forms.Padding(4);
            this.podcastsView.Name = "podcastsView";
            this.podcastsView.Size = new System.Drawing.Size(543, 160);
            this.podcastsView.TabIndex = 1;
            this.podcastsView.UseCompatibleStateImageBehavior = false;
            this.podcastsView.View = System.Windows.Forms.View.Details;
            this.podcastsView.SelectedIndexChanged += new System.EventHandler(this.episodesView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Avsnitt";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Titel";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Frekvens";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kategori";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 64;
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(37, 229);
            this.urlBox.Margin = new System.Windows.Forms.Padding(4);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(539, 22);
            this.urlBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL:";
            // 
            // categoryDropdown
            // 
            this.categoryDropdown.BackColor = System.Drawing.SystemColors.Window;
            this.categoryDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryDropdown.FormattingEnabled = true;
            this.categoryDropdown.Location = new System.Drawing.Point(423, 287);
            this.categoryDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.categoryDropdown.Name = "categoryDropdown";
            this.categoryDropdown.Size = new System.Drawing.Size(153, 24);
            this.categoryDropdown.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Uppdateringsfrekvens:";
            // 
            // updateFrequencyDropdown
            // 
            this.updateFrequencyDropdown.BackColor = System.Drawing.SystemColors.Window;
            this.updateFrequencyDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateFrequencyDropdown.FormattingEnabled = true;
            this.updateFrequencyDropdown.Location = new System.Drawing.Point(224, 287);
            this.updateFrequencyDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.updateFrequencyDropdown.Name = "updateFrequencyDropdown";
            this.updateFrequencyDropdown.Size = new System.Drawing.Size(175, 24);
            this.updateFrequencyDropdown.TabIndex = 7;
            // 
            // newPodcast
            // 
            this.newPodcast.Location = new System.Drawing.Point(97, 333);
            this.newPodcast.Margin = new System.Windows.Forms.Padding(4);
            this.newPodcast.Name = "newPodcast";
            this.newPodcast.Size = new System.Drawing.Size(100, 28);
            this.newPodcast.TabIndex = 9;
            this.newPodcast.Text = "Ny podcast";
            this.newPodcast.UseVisualStyleBackColor = true;
            this.newPodcast.Click += new System.EventHandler(this.newPodcast_Click);
            // 
            // btnTaBortPodd
            // 
            this.btnTaBortPodd.Location = new System.Drawing.Point(423, 333);
            this.btnTaBortPodd.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaBortPodd.Name = "btnTaBortPodd";
            this.btnTaBortPodd.Size = new System.Drawing.Size(100, 28);
            this.btnTaBortPodd.TabIndex = 11;
            this.btnTaBortPodd.Text = "Ta bort";
            this.btnTaBortPodd.UseVisualStyleBackColor = true;
            this.btnTaBortPodd.Click += new System.EventHandler(this.deletePodcast_Click);
            // 
            // episodesView
            // 
            this.episodesView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.episodesView.FormattingEnabled = true;
            this.episodesView.ItemHeight = 16;
            this.episodesView.Location = new System.Drawing.Point(37, 425);
            this.episodesView.Margin = new System.Windows.Forms.Padding(4);
            this.episodesView.Name = "episodesView";
            this.episodesView.Size = new System.Drawing.Size(539, 180);
            this.episodesView.TabIndex = 12;
            this.episodesView.SelectedIndexChanged += new System.EventHandler(this.episodeView_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 405);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Podcastnamn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(653, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Podcastnamn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(669, 379);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Avsnitt #";
            // 
            // episodeDescriptionView
            // 
            this.episodeDescriptionView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.episodeDescriptionView.Location = new System.Drawing.Point(656, 402);
            this.episodeDescriptionView.Margin = new System.Windows.Forms.Padding(4);
            this.episodeDescriptionView.Multiline = true;
            this.episodeDescriptionView.Name = "episodeDescriptionView";
            this.episodeDescriptionView.Size = new System.Drawing.Size(527, 202);
            this.episodeDescriptionView.TabIndex = 16;
            this.episodeDescriptionView.Text = "Beskrivning av avsnittet...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(672, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kategorier:";
            // 
            // categoriesView
            // 
            this.categoriesView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriesView.FormattingEnabled = true;
            this.categoriesView.ItemHeight = 16;
            this.categoriesView.Location = new System.Drawing.Point(676, 39);
            this.categoriesView.Margin = new System.Windows.Forms.Padding(4);
            this.categoriesView.Name = "categoriesView";
            this.categoriesView.Size = new System.Drawing.Size(507, 116);
            this.categoriesView.TabIndex = 18;
            this.categoriesView.SelectedIndexChanged += new System.EventHandler(this.categoriesView_SelectedIndexChanged);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryTextBox.Location = new System.Drawing.Point(673, 229);
            this.categoryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(507, 22);
            this.categoryTextBox.TabIndex = 19;
            // 
            // btnTaBortCat
            // 
            this.btnTaBortCat.Location = new System.Drawing.Point(1026, 268);
            this.btnTaBortCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaBortCat.Name = "btnTaBortCat";
            this.btnTaBortCat.Size = new System.Drawing.Size(100, 28);
            this.btnTaBortCat.TabIndex = 22;
            this.btnTaBortCat.Text = "Ta bort";
            this.btnTaBortCat.UseVisualStyleBackColor = true;
            this.btnTaBortCat.Click += new System.EventHandler(this.deleteCategory_Click);
            // 
            // newCategory
            // 
            this.newCategory.Location = new System.Drawing.Point(703, 268);
            this.newCategory.Margin = new System.Windows.Forms.Padding(4);
            this.newCategory.Name = "newCategory";
            this.newCategory.Size = new System.Drawing.Size(100, 28);
            this.newCategory.TabIndex = 20;
            this.newCategory.Text = "Ny kategori";
            this.newCategory.UseVisualStyleBackColor = true;
            this.newCategory.Click += new System.EventHandler(this.newCategory_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(615, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 619);
            this.label8.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(625, 309);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(597, 2);
            this.label9.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 267);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Titel:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(37, 287);
            this.titleBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(160, 22);
            this.titleBox.TabIndex = 25;
            // 
            // btnUppdateraPodd
            // 
            this.btnUppdateraPodd.Location = new System.Drawing.Point(256, 333);
            this.btnUppdateraPodd.Margin = new System.Windows.Forms.Padding(4);
            this.btnUppdateraPodd.Name = "btnUppdateraPodd";
            this.btnUppdateraPodd.Size = new System.Drawing.Size(100, 28);
            this.btnUppdateraPodd.TabIndex = 27;
            this.btnUppdateraPodd.Text = "Uppdatera ...";
            this.btnUppdateraPodd.UseVisualStyleBackColor = true;
            this.btnUppdateraPodd.Click += new System.EventHandler(this.updatePodcast_Click);
            // 
            // btnUppdateraCat
            // 
            this.btnUppdateraCat.Location = new System.Drawing.Point(874, 268);
            this.btnUppdateraCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnUppdateraCat.Name = "btnUppdateraCat";
            this.btnUppdateraCat.Size = new System.Drawing.Size(100, 28);
            this.btnUppdateraCat.TabIndex = 28;
            this.btnUppdateraCat.Text = "Uppdatera ...";
            this.btnUppdateraCat.UseVisualStyleBackColor = true;
            this.btnUppdateraCat.Click += new System.EventHandler(this.updateCategory_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(672, 209);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Skriv in kategori:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1049, 164);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 28);
            this.button7.TabIndex = 30;
            this.button7.Text = "ta bort markering";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.unselectCategory_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1251, 636);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnUppdateraCat);
            this.Controls.Add(this.btnUppdateraPodd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTaBortCat);
            this.Controls.Add(this.newCategory);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.categoriesView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.episodeDescriptionView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.episodesView);
            this.Controls.Add(this.btnTaBortPodd);
            this.Controls.Add(this.newPodcast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateFrequencyDropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.podcastsView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "App";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.app_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView podcastsView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox categoryDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox updateFrequencyDropdown;
        private System.Windows.Forms.Button newPodcast;
        private System.Windows.Forms.Button btnTaBortPodd;
        private System.Windows.Forms.ListBox episodesView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox episodeDescriptionView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox categoriesView;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Button btnTaBortCat;
        private System.Windows.Forms.Button newCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button btnUppdateraPodd;
        private System.Windows.Forms.Button btnUppdateraCat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button7;
    }
}

