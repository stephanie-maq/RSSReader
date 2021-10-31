
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newPodcast = new System.Windows.Forms.Button();
            this.btnSparaPodd = new System.Windows.Forms.Button();
            this.btnTaBortPodd = new System.Windows.Forms.Button();
            this.LBAvsnitt = new System.Windows.Forms.ListBox();
            this.labelTitel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxEpisodeDesc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.categoriesView = new System.Windows.Forms.ListBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.newCategory = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.updateFrequencyDropdown = new System.Windows.Forms.ComboBox();
            this.categoryDropdown = new System.Windows.Forms.ComboBox();
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
            this.podcastsView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.podcastsView.Name = "podcastsView";
            this.podcastsView.Size = new System.Drawing.Size(543, 160);
            this.podcastsView.TabIndex = 1;
            this.podcastsView.UseCompatibleStateImageBehavior = false;
            this.podcastsView.View = System.Windows.Forms.View.Details;
            this.podcastsView.SelectedIndexChanged += new System.EventHandler(this.lvBokLista_SelectedIndexChanged);
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
            this.urlBox.Location = new System.Drawing.Point(33, 229);
            this.urlBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(87, 22);
            this.urlBox.TabIndex = 2;
            this.urlBox.TextChanged += new System.EventHandler(this.urlBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategori:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Uppdateringsfrekvens:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // newPodcast
            // 
            this.newPodcast.Location = new System.Drawing.Point(244, 278);
            this.newPodcast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newPodcast.Name = "newPodcast";
            this.newPodcast.Size = new System.Drawing.Size(100, 28);
            this.newPodcast.TabIndex = 9;
            this.newPodcast.Text = "Ny podcast";
            this.newPodcast.UseVisualStyleBackColor = true;
            this.newPodcast.Click += new System.EventHandler(this.newPodcast_Click);
            // 
            // btnSparaPodd
            // 
            this.btnSparaPodd.Location = new System.Drawing.Point(352, 278);
            this.btnSparaPodd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSparaPodd.Name = "btnSparaPodd";
            this.btnSparaPodd.Size = new System.Drawing.Size(100, 28);
            this.btnSparaPodd.TabIndex = 10;
            this.btnSparaPodd.Text = "Spara";
            this.btnSparaPodd.UseVisualStyleBackColor = true;
            // 
            // btnTaBortPodd
            // 
            this.btnTaBortPodd.Location = new System.Drawing.Point(460, 278);
            this.btnTaBortPodd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTaBortPodd.Name = "btnTaBortPodd";
            this.btnTaBortPodd.Size = new System.Drawing.Size(100, 28);
            this.btnTaBortPodd.TabIndex = 11;
            this.btnTaBortPodd.Text = "Ta bort";
            this.btnTaBortPodd.UseVisualStyleBackColor = true;
            this.btnTaBortPodd.Click += new System.EventHandler(this.button3_Click);
            // 
            // LBAvsnitt
            // 
            this.LBAvsnitt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBAvsnitt.FormattingEnabled = true;
            this.LBAvsnitt.ItemHeight = 16;
            this.LBAvsnitt.Location = new System.Drawing.Point(37, 354);
            this.LBAvsnitt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LBAvsnitt.Name = "LBAvsnitt";
            this.LBAvsnitt.Size = new System.Drawing.Size(539, 228);
            this.LBAvsnitt.TabIndex = 12;
            this.LBAvsnitt.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitel.Location = new System.Drawing.Point(33, 324);
            this.labelTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(105, 17);
            this.labelTitel.TabIndex = 13;
            this.labelTitel.Text = "Podcastnamn";
            this.labelTitel.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(781, 310);
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
            this.label6.Location = new System.Drawing.Point(797, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Avsnitt #";
            // 
            // txtBoxEpisodeDesc
            // 
            this.txtBoxEpisodeDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxEpisodeDesc.Location = new System.Drawing.Point(656, 354);
            this.txtBoxEpisodeDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxEpisodeDesc.Multiline = true;
            this.txtBoxEpisodeDesc.Name = "txtBoxEpisodeDesc";
            this.txtBoxEpisodeDesc.Size = new System.Drawing.Size(527, 229);
            this.txtBoxEpisodeDesc.TabIndex = 16;
            this.txtBoxEpisodeDesc.Text = "Beskrivning av avsnittet...";
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
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // categoriesView
            // 
            this.categoriesView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriesView.FormattingEnabled = true;
            this.categoriesView.ItemHeight = 16;
            this.categoriesView.Location = new System.Drawing.Point(676, 39);
            this.categoriesView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoriesView.Name = "categoriesView";
            this.categoriesView.Size = new System.Drawing.Size(507, 116);
            this.categoriesView.TabIndex = 18;
            this.categoriesView.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_2);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryTextBox.Location = new System.Drawing.Point(676, 176);
            this.categoryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(507, 22);
            this.categoryTextBox.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(893, 208);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 22;
            this.button4.Text = "Ta bort";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(785, 208);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 21;
            this.button5.Text = "Spara";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // newCategory
            // 
            this.newCategory.Location = new System.Drawing.Point(677, 208);
            this.newCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label8.Size = new System.Drawing.Size(3, 606);
            this.label8.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(615, 266);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(597, 2);
            this.label9.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(137, 206);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Titel:";
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(137, 229);
            this.txtTitel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(117, 22);
            this.txtTitel.TabIndex = 25;
            // 
            // updateFrequencyDropdown
            // 
            this.updateFrequencyDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateFrequencyDropdown.FormattingEnabled = true;
            this.updateFrequencyDropdown.Location = new System.Drawing.Point(263, 229);
            this.updateFrequencyDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.updateFrequencyDropdown.Name = "updateFrequencyDropdown";
            this.updateFrequencyDropdown.Size = new System.Drawing.Size(169, 24);
            this.updateFrequencyDropdown.TabIndex = 27;
            // 
            // categoryDropdown
            // 
            this.categoryDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryDropdown.FormattingEnabled = true;
            this.categoryDropdown.Location = new System.Drawing.Point(451, 229);
            this.categoryDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.categoryDropdown.Name = "categoryDropdown";
            this.categoryDropdown.Size = new System.Drawing.Size(125, 24);
            this.categoryDropdown.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1251, 663);
            this.Controls.Add(this.categoryDropdown);
            this.Controls.Add(this.updateFrequencyDropdown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.newCategory);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.categoriesView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxEpisodeDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTitel);
            this.Controls.Add(this.LBAvsnitt);
            this.Controls.Add(this.btnTaBortPodd);
            this.Controls.Add(this.btnSparaPodd);
            this.Controls.Add(this.newPodcast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.podcastsView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newPodcast;
        private System.Windows.Forms.Button btnSparaPodd;
        private System.Windows.Forms.Button btnTaBortPodd;
        private System.Windows.Forms.ListBox LBAvsnitt;
        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxEpisodeDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox categoriesView;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button newCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.ComboBox updateFrequencyDropdown;
        private System.Windows.Forms.ComboBox categoryDropdown;
    }
}

