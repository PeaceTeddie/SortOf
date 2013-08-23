namespace SortOf
{
    partial class SetDialog
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Categories");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("File Associations");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Archives");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Documents");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ebooks");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Images");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Music");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Pictures");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Programs");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Shortcuts");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Videos");
            this.OKButton = new System.Windows.Forms.Button();
            this.CanButton = new System.Windows.Forms.Button();
            this.SetTree = new System.Windows.Forms.TreeView();
            this.GenPanel = new System.Windows.Forms.Panel();
            this.CatPanel = new System.Windows.Forms.Panel();
            this.OtherBox = new System.Windows.Forms.CheckBox();
            this.VideoBox = new System.Windows.Forms.CheckBox();
            this.TorrentBox = new System.Windows.Forms.CheckBox();
            this.ShortcutBox = new System.Windows.Forms.CheckBox();
            this.ProgramBox = new System.Windows.Forms.CheckBox();
            this.PictureBox = new System.Windows.Forms.CheckBox();
            this.MusicBox = new System.Windows.Forms.CheckBox();
            this.ImageBox = new System.Windows.Forms.CheckBox();
            this.EbookBox = new System.Windows.Forms.CheckBox();
            this.DocumentBox = new System.Windows.Forms.CheckBox();
            this.ArchiveBox = new System.Windows.Forms.CheckBox();
            this.CatTree = new System.Windows.Forms.TreeView();
            this.CatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(316, 177);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 25);
            this.OKButton.TabIndex = 0;
            this.OKButton.TabStop = false;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CanButton
            // 
            this.CanButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CanButton.Location = new System.Drawing.Point(397, 177);
            this.CanButton.Name = "CanButton";
            this.CanButton.Size = new System.Drawing.Size(75, 25);
            this.CanButton.TabIndex = 1;
            this.CanButton.TabStop = false;
            this.CanButton.Text = "Cancel";
            this.CanButton.UseVisualStyleBackColor = true;
            // 
            // SetTree
            // 
            this.SetTree.Location = new System.Drawing.Point(12, 12);
            this.SetTree.Name = "SetTree";
            treeNode1.Name = "GenNode";
            treeNode1.Text = "General";
            treeNode2.Name = "CatNode";
            treeNode2.Text = "Categories";
            treeNode3.Name = "FileNode";
            treeNode3.Text = "File Associations";
            this.SetTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.SetTree.Size = new System.Drawing.Size(121, 188);
            this.SetTree.TabIndex = 3;
            this.SetTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SetTree_AfterSelect);
            // 
            // GenPanel
            // 
            this.GenPanel.Enabled = false;
            this.GenPanel.Location = new System.Drawing.Point(141, 13);
            this.GenPanel.Name = "GenPanel";
            this.GenPanel.Size = new System.Drawing.Size(331, 158);
            this.GenPanel.TabIndex = 4;
            // 
            // CatPanel
            // 
            this.CatPanel.Controls.Add(this.OtherBox);
            this.CatPanel.Controls.Add(this.VideoBox);
            this.CatPanel.Controls.Add(this.TorrentBox);
            this.CatPanel.Controls.Add(this.ShortcutBox);
            this.CatPanel.Controls.Add(this.ProgramBox);
            this.CatPanel.Controls.Add(this.PictureBox);
            this.CatPanel.Controls.Add(this.MusicBox);
            this.CatPanel.Controls.Add(this.ImageBox);
            this.CatPanel.Controls.Add(this.EbookBox);
            this.CatPanel.Controls.Add(this.DocumentBox);
            this.CatPanel.Controls.Add(this.ArchiveBox);
            this.CatPanel.Enabled = false;
            this.CatPanel.Location = new System.Drawing.Point(141, 13);
            this.CatPanel.Name = "CatPanel";
            this.CatPanel.Size = new System.Drawing.Size(331, 158);
            this.CatPanel.TabIndex = 5;
            // 
            // OtherBox
            // 
            this.OtherBox.AutoSize = true;
            this.OtherBox.Location = new System.Drawing.Point(3, 118);
            this.OtherBox.Name = "OtherBox";
            this.OtherBox.Size = new System.Drawing.Size(57, 17);
            this.OtherBox.TabIndex = 11;
            this.OtherBox.Text = "Others";
            this.OtherBox.UseVisualStyleBackColor = true;
            // 
            // VideoBox
            // 
            this.VideoBox.AutoSize = true;
            this.VideoBox.Location = new System.Drawing.Point(89, 95);
            this.VideoBox.Name = "VideoBox";
            this.VideoBox.Size = new System.Drawing.Size(58, 17);
            this.VideoBox.TabIndex = 10;
            this.VideoBox.Text = "Videos";
            this.VideoBox.UseVisualStyleBackColor = true;
            // 
            // TorrentBox
            // 
            this.TorrentBox.AutoSize = true;
            this.TorrentBox.Location = new System.Drawing.Point(89, 72);
            this.TorrentBox.Name = "TorrentBox";
            this.TorrentBox.Size = new System.Drawing.Size(65, 17);
            this.TorrentBox.TabIndex = 8;
            this.TorrentBox.Text = "Torrents";
            this.TorrentBox.UseVisualStyleBackColor = true;
            // 
            // ShortcutBox
            // 
            this.ShortcutBox.AutoSize = true;
            this.ShortcutBox.Location = new System.Drawing.Point(89, 49);
            this.ShortcutBox.Name = "ShortcutBox";
            this.ShortcutBox.Size = new System.Drawing.Size(71, 17);
            this.ShortcutBox.TabIndex = 7;
            this.ShortcutBox.Text = "Shortcuts";
            this.ShortcutBox.UseVisualStyleBackColor = true;
            // 
            // ProgramBox
            // 
            this.ProgramBox.AutoSize = true;
            this.ProgramBox.Location = new System.Drawing.Point(89, 26);
            this.ProgramBox.Name = "ProgramBox";
            this.ProgramBox.Size = new System.Drawing.Size(70, 17);
            this.ProgramBox.TabIndex = 6;
            this.ProgramBox.Text = "Programs";
            this.ProgramBox.UseVisualStyleBackColor = true;
            // 
            // PictureBox
            // 
            this.PictureBox.AutoSize = true;
            this.PictureBox.Location = new System.Drawing.Point(89, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(64, 17);
            this.PictureBox.TabIndex = 5;
            this.PictureBox.Text = "Pictures";
            this.PictureBox.UseVisualStyleBackColor = true;
            // 
            // MusicBox
            // 
            this.MusicBox.AutoSize = true;
            this.MusicBox.Location = new System.Drawing.Point(3, 95);
            this.MusicBox.Name = "MusicBox";
            this.MusicBox.Size = new System.Drawing.Size(54, 17);
            this.MusicBox.TabIndex = 4;
            this.MusicBox.Text = "Music";
            this.MusicBox.UseVisualStyleBackColor = true;
            // 
            // ImageBox
            // 
            this.ImageBox.AutoSize = true;
            this.ImageBox.Location = new System.Drawing.Point(3, 72);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(60, 17);
            this.ImageBox.TabIndex = 3;
            this.ImageBox.Text = "Images";
            this.ImageBox.UseVisualStyleBackColor = true;
            // 
            // EbookBox
            // 
            this.EbookBox.AutoSize = true;
            this.EbookBox.Location = new System.Drawing.Point(3, 49);
            this.EbookBox.Name = "EbookBox";
            this.EbookBox.Size = new System.Drawing.Size(62, 17);
            this.EbookBox.TabIndex = 2;
            this.EbookBox.Text = "Ebooks";
            this.EbookBox.UseVisualStyleBackColor = true;
            // 
            // DocumentBox
            // 
            this.DocumentBox.AutoSize = true;
            this.DocumentBox.Location = new System.Drawing.Point(3, 26);
            this.DocumentBox.Name = "DocumentBox";
            this.DocumentBox.Size = new System.Drawing.Size(80, 17);
            this.DocumentBox.TabIndex = 1;
            this.DocumentBox.Text = "Documents";
            this.DocumentBox.UseVisualStyleBackColor = true;
            // 
            // ArchiveBox
            // 
            this.ArchiveBox.AutoSize = true;
            this.ArchiveBox.Location = new System.Drawing.Point(3, 3);
            this.ArchiveBox.Name = "ArchiveBox";
            this.ArchiveBox.Size = new System.Drawing.Size(67, 17);
            this.ArchiveBox.TabIndex = 0;
            this.ArchiveBox.Text = "Archives";
            this.ArchiveBox.UseVisualStyleBackColor = true;
            // 
            // CatTree
            // 
            this.CatTree.Enabled = false;
            this.CatTree.Location = new System.Drawing.Point(141, 13);
            this.CatTree.Name = "CatTree";
            treeNode4.Name = "ArcNode";
            treeNode4.Text = "Archives";
            treeNode5.Name = "DocNode";
            treeNode5.Text = "Documents";
            treeNode6.Name = "EboNode";
            treeNode6.Text = "Ebooks";
            treeNode7.Name = "ImgNode";
            treeNode7.Text = "Images";
            treeNode8.Name = "MusNode";
            treeNode8.Text = "Music";
            treeNode9.Name = "PicNode";
            treeNode9.Text = "Pictures";
            treeNode10.Name = "ProNode";
            treeNode10.Text = "Programs";
            treeNode11.Name = "ShoNode";
            treeNode11.Text = "Shortcuts";
            treeNode12.Name = "VidNode";
            treeNode12.Text = "Videos";
            this.CatTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.CatTree.Size = new System.Drawing.Size(90, 158);
            this.CatTree.TabIndex = 15;
            // 
            // SetDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 212);
            this.Controls.Add(this.CatPanel);
            this.Controls.Add(this.GenPanel);
            this.Controls.Add(this.CatTree);
            this.Controls.Add(this.SetTree);
            this.Controls.Add(this.CanButton);
            this.Controls.Add(this.OKButton);
            this.Name = "SetDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.CatPanel.ResumeLayout(false);
            this.CatPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CanButton;
        private System.Windows.Forms.TreeView SetTree;
        private System.Windows.Forms.TreeView CatTree;
        private System.Windows.Forms.Panel GenPanel;
        private System.Windows.Forms.Panel CatPanel;
        private System.Windows.Forms.CheckBox ArchiveBox;
        private System.Windows.Forms.CheckBox ShortcutBox;
        private System.Windows.Forms.CheckBox ProgramBox;
        private System.Windows.Forms.CheckBox PictureBox;
        private System.Windows.Forms.CheckBox MusicBox;
        private System.Windows.Forms.CheckBox ImageBox;
        private System.Windows.Forms.CheckBox EbookBox;
        private System.Windows.Forms.CheckBox DocumentBox;
        private System.Windows.Forms.CheckBox VideoBox;
        private System.Windows.Forms.CheckBox TorrentBox;
        private System.Windows.Forms.CheckBox OtherBox;
    }
}