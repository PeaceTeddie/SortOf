namespace SortOf
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BrowseButton = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.SortButton = new System.Windows.Forms.Button();
            this.Browser = new System.Windows.Forms.FolderBrowserDialog();
            this.ProgBar = new System.Windows.Forms.ProgressBar();
            this.UnsortButton = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.SetButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton.Location = new System.Drawing.Point(550, 90);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 25);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseClick);
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MainLabel.Location = new System.Drawing.Point(62, 10);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(517, 62);
            this.MainLabel.TabIndex = 2;
            this.MainLabel.Text = "Please browse for the folder you want \r\nand pick what categories you want to sort" +
    " out.";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SortButton
            // 
            this.SortButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortButton.Location = new System.Drawing.Point(10, 120);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(615, 50);
            this.SortButton.TabIndex = 17;
            this.SortButton.Text = "~~Sort Out~~";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortClick);
            // 
            // Browser
            // 
            this.Browser.Description = "Please select folder to ~~Sort Out~~";
            this.Browser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // ProgBar
            // 
            this.ProgBar.Location = new System.Drawing.Point(10, 120);
            this.ProgBar.Name = "ProgBar";
            this.ProgBar.Size = new System.Drawing.Size(615, 50);
            this.ProgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgBar.TabIndex = 0;
            this.ProgBar.Visible = false;
            // 
            // UnsortButton
            // 
            this.UnsortButton.Location = new System.Drawing.Point(10, 10);
            this.UnsortButton.Name = "UnsortButton";
            this.UnsortButton.Size = new System.Drawing.Size(25, 25);
            this.UnsortButton.TabIndex = 22;
            this.UnsortButton.TabStop = false;
            this.UnsortButton.Text = "<";
            this.UnsortButton.UseVisualStyleBackColor = true;
            this.UnsortButton.Click += new System.EventHandler(this.UnsortClick);
            // 
            // PathBox
            // 
            this.PathBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.PathBox.ContextMenuStrip = this.ContextMenuStrip;
            this.PathBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PathBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PathBox.Location = new System.Drawing.Point(10, 90);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(530, 23);
            this.PathBox.TabIndex = 1;
            this.PathBox.TabStop = false;
            this.PathBox.WordWrap = false;
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(600, 10);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(25, 25);
            this.SetButton.TabIndex = 23;
            this.SetButton.TabStop = false;
            this.SetButton.Text = "S";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SettingsClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "ContextMenuStrip";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextClick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(634, 182);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.ProgBar);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.UnsortButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.BrowseButton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sort Of";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button UnsortButton;
        private System.Windows.Forms.FolderBrowserDialog Browser;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.ProgressBar ProgBar;
        private System.Windows.Forms.Button SetButton;

        protected override void OnLoad(System.EventArgs e)
        {
            this.Activate();
        }

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

