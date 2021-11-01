﻿
namespace PresentationLayer
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.episodesView = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.episodeDescriptionView = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.categoriesView = new System.Windows.Forms.ListBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.newCategory = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
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
            this.podcastsView.Location = new System.Drawing.Point(25, 32);
            this.podcastsView.Name = "podcastsView";
            this.podcastsView.Size = new System.Drawing.Size(408, 131);
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
            this.urlBox.Location = new System.Drawing.Point(28, 186);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(405, 20);
            this.urlBox.TabIndex = 2;
            this.urlBox.TextChanged += new System.EventHandler(this.urlBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // categoryDropdown
            // 
            this.categoryDropdown.BackColor = System.Drawing.SystemColors.Window;
            this.categoryDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryDropdown.FormattingEnabled = true;
            this.categoryDropdown.Location = new System.Drawing.Point(317, 233);
            this.categoryDropdown.Name = "categoryDropdown";
            this.categoryDropdown.Size = new System.Drawing.Size(116, 21);
            this.categoryDropdown.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategori:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Uppdateringsfrekvens:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // updateFrequencyDropdown
            // 
            this.updateFrequencyDropdown.BackColor = System.Drawing.SystemColors.Window;
            this.updateFrequencyDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateFrequencyDropdown.FormattingEnabled = true;
            this.updateFrequencyDropdown.Location = new System.Drawing.Point(168, 233);
            this.updateFrequencyDropdown.Name = "updateFrequencyDropdown";
            this.updateFrequencyDropdown.Size = new System.Drawing.Size(132, 21);
            this.updateFrequencyDropdown.TabIndex = 7;
            this.updateFrequencyDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // newPodcast
            // 
            this.newPodcast.Location = new System.Drawing.Point(28, 288);
            this.newPodcast.Name = "newPodcast";
            this.newPodcast.Size = new System.Drawing.Size(75, 23);
            this.newPodcast.TabIndex = 9;
            this.newPodcast.Text = "Ny podcast";
            this.newPodcast.UseVisualStyleBackColor = true;
            this.newPodcast.Click += new System.EventHandler(this.newPodcast_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Spara";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(358, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Ta bort";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deletePodcast_Click);
            // 
            // episodesView
            // 
            this.episodesView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.episodesView.FormattingEnabled = true;
            this.episodesView.Location = new System.Drawing.Point(28, 345);
            this.episodesView.Name = "episodesView";
            this.episodesView.Size = new System.Drawing.Size(405, 147);
            this.episodesView.TabIndex = 12;
            this.episodesView.SelectedIndexChanged += new System.EventHandler(this.episodeView_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Podcastnamn";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Podcastnamn";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(502, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Avsnitt #";
            // 
            // episodeDescriptionView
            // 
            this.episodeDescriptionView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.episodeDescriptionView.Location = new System.Drawing.Point(492, 327);
            this.episodeDescriptionView.Multiline = true;
            this.episodeDescriptionView.Name = "episodeDescriptionView";
            this.episodeDescriptionView.Size = new System.Drawing.Size(396, 165);
            this.episodeDescriptionView.TabIndex = 16;
            this.episodeDescriptionView.Text = "Beskrivning av avsnittet...";
            this.episodeDescriptionView.TextChanged += new System.EventHandler(this.episodeDescriptionView_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(504, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kategorier:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // categoriesView
            // 
            this.categoriesView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriesView.FormattingEnabled = true;
            this.categoriesView.Location = new System.Drawing.Point(507, 32);
            this.categoriesView.Name = "categoriesView";
            this.categoriesView.Size = new System.Drawing.Size(381, 95);
            this.categoriesView.TabIndex = 18;
            this.categoriesView.SelectedIndexChanged += new System.EventHandler(this.categoriesView_SelectedIndexChanged);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryTextBox.Location = new System.Drawing.Point(505, 186);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(381, 20);
            this.categoryTextBox.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(813, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Ta bort";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.deleteCategory_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(715, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Spara";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // newCategory
            // 
            this.newCategory.Location = new System.Drawing.Point(507, 218);
            this.newCategory.Name = "newCategory";
            this.newCategory.Size = new System.Drawing.Size(75, 23);
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
            this.label8.Location = new System.Drawing.Point(461, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 503);
            this.label8.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(469, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(448, 2);
            this.label9.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Titel:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(28, 233);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(121, 20);
            this.titleBox.TabIndex = 25;
            this.titleBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Updatera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.updatePodcast_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(605, 218);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "Updatera";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.updateCategory_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(504, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Skriv in kategori:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(787, 133);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 23);
            this.button7.TabIndex = 30;
            this.button7.Text = "ta bort markering";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.unselectCategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(938, 517);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.newCategory);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.categoriesView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.episodeDescriptionView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.episodesView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.newPodcast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateFrequencyDropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.podcastsView);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox episodesView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox episodeDescriptionView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox categoriesView;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button newCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button7;
    }
}

