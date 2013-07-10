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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ArchiveBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DocumentBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MusicBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OtherBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProgramBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.VideoBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.ImageBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ShortcutBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(551, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(12, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(533, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please browse for the folder you want \r\nand pick what catagories you want to sort" +
    " out.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(358, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pictures";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(173, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Images";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(85, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Documents";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(240, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Music";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SpringGreen;
            this.label6.Location = new System.Drawing.Point(9, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Archives";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(431, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Programs";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(299, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Other";
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(627, 51);
            this.button2.TabIndex = 17;
            this.button2.Text = "~~Sort Out~~";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(510, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Shortcuts";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label10.Location = new System.Drawing.Point(593, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Videos";
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.VideoBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProgramBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OtherBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MusicBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DocumentBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArchiveBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sort Of";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ArchiveBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox DocumentBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox MusicBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox OtherBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox PictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ProgramBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox VideoBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;

        protected override void OnLoad(System.EventArgs e)
        {
            this.Activate();
        }

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ImageBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ShortcutBox;
    }
}

