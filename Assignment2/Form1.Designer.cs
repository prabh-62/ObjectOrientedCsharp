namespace Assignment2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.richBox = new System.Windows.Forms.RichTextBox();
            this.comboTitle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.movieRatings = new System.Windows.Forms.Button();
            this.musisGenre = new System.Windows.Forms.Button();
            this.summary = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSummaryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moviesByRatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicByGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSummaryToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prabhdeep Singh/991337588/Software Development";
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 23;
            this.list.Location = new System.Drawing.Point(403, 319);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(708, 188);
            this.list.TabIndex = 1;
            // 
            // richBox
            // 
            this.richBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richBox.Location = new System.Drawing.Point(403, 61);
            this.richBox.Name = "richBox";
            this.richBox.Size = new System.Drawing.Size(719, 225);
            this.richBox.TabIndex = 2;
            this.richBox.Text = "Prabhdeep Singh";
            // 
            // comboTitle
            // 
            this.comboTitle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTitle.FormattingEnabled = true;
            this.comboTitle.Location = new System.Drawing.Point(82, 91);
            this.comboTitle.Name = "comboTitle";
            this.comboTitle.Size = new System.Drawing.Size(160, 31);
            this.comboTitle.TabIndex = 3;
            this.comboTitle.SelectedIndexChanged += new System.EventHandler(this.comboTitle_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select a Title";
            // 
            // movieRatings
            // 
            this.movieRatings.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieRatings.Location = new System.Drawing.Point(82, 319);
            this.movieRatings.Name = "movieRatings";
            this.movieRatings.Size = new System.Drawing.Size(184, 58);
            this.movieRatings.TabIndex = 5;
            this.movieRatings.Text = "Movies By Rating";
            this.toolTip1.SetToolTip(this.movieRatings, "List all movies grouped by rating (5 stars down to 1) in the ListBox ");
            this.movieRatings.UseVisualStyleBackColor = true;
            this.movieRatings.Click += new System.EventHandler(this.movieRatings_Click);
            // 
            // musisGenre
            // 
            this.musisGenre.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musisGenre.Location = new System.Drawing.Point(85, 413);
            this.musisGenre.Name = "musisGenre";
            this.musisGenre.Size = new System.Drawing.Size(181, 50);
            this.musisGenre.TabIndex = 6;
            this.musisGenre.Text = "Music By Genre";
            this.toolTip1.SetToolTip(this.musisGenre, "List all music items based on Genre");
            this.musisGenre.UseVisualStyleBackColor = true;
            this.musisGenre.Click += new System.EventHandler(this.musisGenre_Click);
            // 
            // summary
            // 
            this.summary.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary.Location = new System.Drawing.Point(522, 539);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(205, 53);
            this.summary.TabIndex = 7;
            this.summary.Text = "View  Summary";
            this.toolTip1.SetToolTip(this.summary, "View Full List of Data");
            this.summary.UseVisualStyleBackColor = true;
            this.summary.Click += new System.EventHandler(this.summary_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customToolStripMenuItem,
            this.viewSummaryToolStripMenuItem,
            this.viewSummaryToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1152, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.customToolStripMenuItem.Text = "Movies By Rating";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // viewSummaryToolStripMenuItem
            // 
            this.viewSummaryToolStripMenuItem.Name = "viewSummaryToolStripMenuItem";
            this.viewSummaryToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.viewSummaryToolStripMenuItem.Text = "Music By Genre";
            this.viewSummaryToolStripMenuItem.Click += new System.EventHandler(this.viewSummaryToolStripMenuItem_Click);
            // 
            // viewSummaryToolStripMenuItem1
            // 
            this.viewSummaryToolStripMenuItem1.Name = "viewSummaryToolStripMenuItem1";
            this.viewSummaryToolStripMenuItem1.Size = new System.Drawing.Size(98, 20);
            this.viewSummaryToolStripMenuItem1.Text = "View Summary";
            this.viewSummaryToolStripMenuItem1.Click += new System.EventHandler(this.viewSummaryToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesByRatingToolStripMenuItem,
            this.musicByGenreToolStripMenuItem,
            this.viewSummaryToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 70);
            // 
            // moviesByRatingToolStripMenuItem
            // 
            this.moviesByRatingToolStripMenuItem.Name = "moviesByRatingToolStripMenuItem";
            this.moviesByRatingToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.moviesByRatingToolStripMenuItem.Text = "Movies By Rating";
            this.moviesByRatingToolStripMenuItem.Click += new System.EventHandler(this.moviesByRatingToolStripMenuItem_Click);
            // 
            // musicByGenreToolStripMenuItem
            // 
            this.musicByGenreToolStripMenuItem.Name = "musicByGenreToolStripMenuItem";
            this.musicByGenreToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.musicByGenreToolStripMenuItem.Text = "Music By Genre";
            this.musicByGenreToolStripMenuItem.Click += new System.EventHandler(this.musicByGenreToolStripMenuItem_Click);
            // 
            // viewSummaryToolStripMenuItem2
            // 
            this.viewSummaryToolStripMenuItem2.Name = "viewSummaryToolStripMenuItem2";
            this.viewSummaryToolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
            this.viewSummaryToolStripMenuItem2.Text = "View Summary";
            this.viewSummaryToolStripMenuItem2.Click += new System.EventHandler(this.viewSummaryToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Assignment2.Properties.Resources._2jb0c3d_1_;
            this.ClientSize = new System.Drawing.Size(1152, 604);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.summary);
            this.Controls.Add(this.musisGenre);
            this.Controls.Add(this.movieRatings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTitle);
            this.Controls.Add(this.richBox);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Assignment 2 - Prabhdeep Singh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.RichTextBox richBox;
        private System.Windows.Forms.ComboBox comboTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button movieRatings;
        private System.Windows.Forms.Button musisGenre;
        private System.Windows.Forms.Button summary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSummaryToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moviesByRatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicByGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSummaryToolStripMenuItem2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

