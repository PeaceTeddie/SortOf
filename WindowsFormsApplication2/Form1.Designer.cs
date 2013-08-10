namespace SortOf
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BrowseButton = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.ArchiveBox = new System.Windows.Forms.CheckBox();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.DocumentBox = new System.Windows.Forms.CheckBox();
            this.DocumentLabel = new System.Windows.Forms.Label();
            this.MusicBox = new System.Windows.Forms.CheckBox();
            this.MusicLabel = new System.Windows.Forms.Label();
            this.OtherBox = new System.Windows.Forms.CheckBox();
            this.ArchiveLabel = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.CheckBox();
            this.ProgramLabel = new System.Windows.Forms.Label();
            this.ProgramBox = new System.Windows.Forms.CheckBox();
            this.OtherLabel = new System.Windows.Forms.Label();
            this.VideoBox = new System.Windows.Forms.CheckBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ShortcutLabel = new System.Windows.Forms.Label();
            this.ImageBox = new System.Windows.Forms.CheckBox();
            this.VideoLabel = new System.Windows.Forms.Label();
            this.ShortcutBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton.Location = new System.Drawing.Point(551, 89);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(88, 24);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // PathBox
            // 
            this.PathBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.PathBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PathBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PathBox.Location = new System.Drawing.Point(12, 90);
            this.PathBox.Name = "PathBox";
            this.PathBox.ReadOnly = true;
            this.PathBox.Size = new System.Drawing.Size(533, 23);
            this.PathBox.TabIndex = 1;
            this.PathBox.TabStop = false;
            this.PathBox.WordWrap = false;
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MainLabel.Location = new System.Drawing.Point(118, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(415, 52);
            this.MainLabel.TabIndex = 2;
            this.MainLabel.Text = "Please browse for the folder you want \r\nand pick what catagories you want to sort out.";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ArchiveBox
            // 
            this.ArchiveBox.AutoSize = true;
            this.ArchiveBox.BackColor = System.Drawing.Color.Transparent;
            this.ArchiveBox.Checked = true;
            this.ArchiveBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ArchiveBox.ForeColor = System.Drawing.Color.Crimson;
            this.ArchiveBox.Location = new System.Drawing.Point(34, 134);
            this.ArchiveBox.Name = "ArchiveBox";
            this.ArchiveBox.Size = new System.Drawing.Size(15, 14);
            this.ArchiveBox.TabIndex = 3;
            this.ArchiveBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ArchiveBox.UseVisualStyleBackColor = false;
            // 
            // PictureLabel
            // 
            this.PictureLabel.AutoSize = true;
            this.PictureLabel.BackColor = System.Drawing.Color.Transparent;
            this.PictureLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureLabel.ForeColor = System.Drawing.Color.Crimson;
            this.PictureLabel.Location = new System.Drawing.Point(358, 154);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(57, 18);
            this.PictureLabel.TabIndex = 4;
            this.PictureLabel.Text = "Pictures";
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ImageLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageLabel.ForeColor = System.Drawing.Color.White;
            this.ImageLabel.Location = new System.Drawing.Point(173, 154);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(51, 18);
            this.ImageLabel.TabIndex = 5;
            this.ImageLabel.Text = "Images";
            // 
            // DocumentBox
            // 
            this.DocumentBox.AutoSize = true;
            this.DocumentBox.BackColor = System.Drawing.Color.Transparent;
            this.DocumentBox.Checked = true;
            this.DocumentBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DocumentBox.Location = new System.Drawing.Point(116, 134);
            this.DocumentBox.Name = "DocumentBox";
            this.DocumentBox.Size = new System.Drawing.Size(15, 14);
            this.DocumentBox.TabIndex = 6;
            this.DocumentBox.UseVisualStyleBackColor = false;
            // 
            // DocumentLabel
            // 
            this.DocumentLabel.AutoSize = true;
            this.DocumentLabel.BackColor = System.Drawing.Color.Transparent;
            this.DocumentLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.DocumentLabel.Location = new System.Drawing.Point(85, 154);
            this.DocumentLabel.Name = "DocumentLabel";
            this.DocumentLabel.Size = new System.Drawing.Size(72, 18);
            this.DocumentLabel.TabIndex = 7;
            this.DocumentLabel.Text = "Documents";
            // 
            // MusicBox
            // 
            this.MusicBox.AutoSize = true;
            this.MusicBox.BackColor = System.Drawing.Color.Transparent;
            this.MusicBox.Checked = true;
            this.MusicBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MusicBox.Location = new System.Drawing.Point(254, 134);
            this.MusicBox.Name = "MusicBox";
            this.MusicBox.Size = new System.Drawing.Size(15, 14);
            this.MusicBox.TabIndex = 8;
            this.MusicBox.UseVisualStyleBackColor = false;
            // 
            // MusicLabel
            // 
            this.MusicLabel.AutoSize = true;
            this.MusicLabel.BackColor = System.Drawing.Color.Transparent;
            this.MusicLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.MusicLabel.Location = new System.Drawing.Point(240, 154);
            this.MusicLabel.Name = "MusicLabel";
            this.MusicLabel.Size = new System.Drawing.Size(43, 18);
            this.MusicLabel.TabIndex = 9;
            this.MusicLabel.Text = "Music";
            // 
            // OtherBox
            // 
            this.OtherBox.AutoSize = true;
            this.OtherBox.BackColor = System.Drawing.Color.Transparent;
            this.OtherBox.Checked = true;
            this.OtherBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OtherBox.Location = new System.Drawing.Point(313, 134);
            this.OtherBox.Name = "OtherBox";
            this.OtherBox.Size = new System.Drawing.Size(15, 14);
            this.OtherBox.TabIndex = 10;
            this.OtherBox.UseVisualStyleBackColor = false;
            // 
            // ArchiveLabel
            // 
            this.ArchiveLabel.AutoSize = true;
            this.ArchiveLabel.BackColor = System.Drawing.Color.Transparent;
            this.ArchiveLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchiveLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.ArchiveLabel.Location = new System.Drawing.Point(9, 154);
            this.ArchiveLabel.Name = "ArchiveLabel";
            this.ArchiveLabel.Size = new System.Drawing.Size(60, 18);
            this.ArchiveLabel.TabIndex = 11;
            this.ArchiveLabel.Text = "Archives";
            // 
            // PictureBox
            // 
            this.PictureBox.AutoSize = true;
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.Checked = true;
            this.PictureBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PictureBox.Location = new System.Drawing.Point(379, 134);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(15, 14);
            this.PictureBox.TabIndex = 12;
            this.PictureBox.UseVisualStyleBackColor = false;
            // 
            // ProgramLabel
            // 
            this.ProgramLabel.AutoSize = true;
            this.ProgramLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProgramLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramLabel.ForeColor = System.Drawing.Color.Lime;
            this.ProgramLabel.Location = new System.Drawing.Point(431, 154);
            this.ProgramLabel.Name = "ProgramLabel";
            this.ProgramLabel.Size = new System.Drawing.Size(63, 18);
            this.ProgramLabel.TabIndex = 13;
            this.ProgramLabel.Text = "Programs";
            // 
            // ProgramBox
            // 
            this.ProgramBox.AutoSize = true;
            this.ProgramBox.BackColor = System.Drawing.Color.Transparent;
            this.ProgramBox.Checked = true;
            this.ProgramBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProgramBox.Location = new System.Drawing.Point(460, 134);
            this.ProgramBox.Name = "ProgramBox";
            this.ProgramBox.Size = new System.Drawing.Size(15, 14);
            this.ProgramBox.TabIndex = 14;
            this.ProgramBox.UseVisualStyleBackColor = false;
            // 
            // OtherLabel
            // 
            this.OtherLabel.AutoSize = true;
            this.OtherLabel.BackColor = System.Drawing.Color.Transparent;
            this.OtherLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherLabel.ForeColor = System.Drawing.Color.Khaki;
            this.OtherLabel.Location = new System.Drawing.Point(299, 154);
            this.OtherLabel.Name = "OtherLabel";
            this.OtherLabel.Size = new System.Drawing.Size(43, 18);
            this.OtherLabel.TabIndex = 15;
            this.OtherLabel.Text = "Other";
            // 
            // VideoBox
            // 
            this.VideoBox.AutoSize = true;
            this.VideoBox.BackColor = System.Drawing.Color.Transparent;
            this.VideoBox.Checked = true;
            this.VideoBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VideoBox.Location = new System.Drawing.Point(610, 134);
            this.VideoBox.Name = "VideoBox";
            this.VideoBox.Size = new System.Drawing.Size(15, 14);
            this.VideoBox.TabIndex = 16;
            this.VideoBox.UseVisualStyleBackColor = false;
            // 
            // SortButton
            // 
            this.SortButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortButton.Location = new System.Drawing.Point(12, 182);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(627, 51);
            this.SortButton.TabIndex = 17;
            this.SortButton.Text = "~~Sort Out~~";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Please select folder to ~~Sort Out~~";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 182);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(626, 51);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            // 
            // ShortcutLabel
            // 
            this.ShortcutLabel.AutoSize = true;
            this.ShortcutLabel.BackColor = System.Drawing.Color.Transparent;
            this.ShortcutLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortcutLabel.ForeColor = System.Drawing.Color.Gold;
            this.ShortcutLabel.Location = new System.Drawing.Point(510, 154);
            this.ShortcutLabel.Name = "ShortcutLabel";
            this.ShortcutLabel.Size = new System.Drawing.Size(67, 18);
            this.ShortcutLabel.TabIndex = 18;
            this.ShortcutLabel.Text = "Shortcuts";
            // 
            // ImageBox
            // 
            this.ImageBox.AutoSize = true;
            this.ImageBox.BackColor = System.Drawing.Color.Transparent;
            this.ImageBox.Checked = true;
            this.ImageBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ImageBox.Location = new System.Drawing.Point(191, 134);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(15, 14);
            this.ImageBox.TabIndex = 19;
            this.ImageBox.UseVisualStyleBackColor = false;
            // 
            // VideoLabel
            // 
            this.VideoLabel.AutoSize = true;
            this.VideoLabel.BackColor = System.Drawing.Color.Transparent;
            this.VideoLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoLabel.ForeColor = System.Drawing.Color.MediumOrchid;
            this.VideoLabel.Location = new System.Drawing.Point(593, 154);
            this.VideoLabel.Name = "VideoLabel";
            this.VideoLabel.Size = new System.Drawing.Size(48, 18);
            this.VideoLabel.TabIndex = 20;
            this.VideoLabel.Text = "Videos";
            // 
            // ShortcutBox
            // 
            this.ShortcutBox.AutoSize = true;
            this.ShortcutBox.BackColor = System.Drawing.Color.Transparent;
            this.ShortcutBox.Checked = true;
            this.ShortcutBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShortcutBox.Location = new System.Drawing.Point(539, 134);
            this.ShortcutBox.Name = "ShortcutBox";
            this.ShortcutBox.Size = new System.Drawing.Size(15, 14);
            this.ShortcutBox.TabIndex = 21;
            this.ShortcutBox.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(651, 245);
            this.Controls.Add(this.ShortcutBox);
            this.Controls.Add(this.VideoLabel);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.ShortcutLabel);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.VideoBox);
            this.Controls.Add(this.OtherLabel);
            this.Controls.Add(this.ProgramBox);
            this.Controls.Add(this.ProgramLabel);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.ArchiveLabel);
            this.Controls.Add(this.OtherBox);
            this.Controls.Add(this.MusicLabel);
            this.Controls.Add(this.MusicBox);
            this.Controls.Add(this.DocumentLabel);
            this.Controls.Add(this.DocumentBox);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.PictureLabel);
            this.Controls.Add(this.ArchiveBox);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sort Of";
            this.ResumeLayout(true);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.CheckBox ArchiveBox;
        private System.Windows.Forms.Label PictureLabel;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.CheckBox DocumentBox;
        private System.Windows.Forms.Label DocumentLabel;
        private System.Windows.Forms.CheckBox MusicBox;
        private System.Windows.Forms.Label MusicLabel;
        private System.Windows.Forms.CheckBox OtherBox;
        private System.Windows.Forms.Label ArchiveLabel;
        private System.Windows.Forms.CheckBox PictureBox;
        private System.Windows.Forms.Label ProgramLabel;
        private System.Windows.Forms.CheckBox ProgramBox;
        private System.Windows.Forms.Label OtherLabel;
        private System.Windows.Forms.CheckBox VideoBox;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label ShortcutLabel;
        private System.Windows.Forms.CheckBox ImageBox;
        private System.Windows.Forms.Label VideoLabel;
        private System.Windows.Forms.CheckBox ShortcutBox;

        protected override void OnLoad(System.EventArgs e)
        {
            this.Activate();
        }
    }
}

