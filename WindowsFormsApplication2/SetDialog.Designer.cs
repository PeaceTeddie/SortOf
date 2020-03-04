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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Extensions");
            this.OKButton = new System.Windows.Forms.Button();
            this.CanButton = new System.Windows.Forms.Button();
            this.RevertButton = new System.Windows.Forms.Button();
            this.SettingsTree = new System.Windows.Forms.TreeView();
            this.GeneralList = new System.Windows.Forms.ListView();
            this.CategoryList = new System.Windows.Forms.CheckedListBox();
            this.ExtensionList = new System.Windows.Forms.TreeView();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(297, 224);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 25);
            this.OKButton.TabIndex = 5;
            this.OKButton.TabStop = false;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CanButton
            // 
            this.CanButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CanButton.Location = new System.Drawing.Point(216, 224);
            this.CanButton.Name = "CanButton";
            this.CanButton.Size = new System.Drawing.Size(75, 25);
            this.CanButton.TabIndex = 4;
            this.CanButton.TabStop = false;
            this.CanButton.Text = "Cancel";
            this.CanButton.UseVisualStyleBackColor = true;
            // 
            // RevertButton
            // 
            this.RevertButton.Location = new System.Drawing.Point(135, 224);
            this.RevertButton.Name = "RevertButton";
            this.RevertButton.Size = new System.Drawing.Size(75, 25);
            this.RevertButton.TabIndex = 3;
            this.RevertButton.TabStop = false;
            this.RevertButton.Text = "Reverts";
            this.RevertButton.UseVisualStyleBackColor = true;
            this.RevertButton.Click += new System.EventHandler(this.RevertClick);
            // 
            // SettingsTree
            // 
            this.SettingsTree.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsTree.Location = new System.Drawing.Point(10, 10);
            this.SettingsTree.Name = "SettingsTree";
            treeNode1.Name = "GenNode";
            treeNode1.Text = "General";
            treeNode2.Name = "CatNode";
            treeNode2.Text = "Categories";
            treeNode3.Name = "ExtNode";
            treeNode3.Text = "Extensions";
            this.SettingsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.SettingsTree.Size = new System.Drawing.Size(120, 239);
            this.SettingsTree.TabIndex = 1;
            this.SettingsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnPageSelect);
            // 
            // GeneralList
            // 
            this.GeneralList.HideSelection = false;
            this.GeneralList.Location = new System.Drawing.Point(135, 10);
            this.GeneralList.Name = "GeneralList";
            this.GeneralList.Size = new System.Drawing.Size(155, 199);
            this.GeneralList.TabIndex = 2;
            this.GeneralList.UseCompatibleStateImageBehavior = false;
            // 
            // CategoryList
            // 
            this.CategoryList.CheckOnClick = true;
            this.CategoryList.Location = new System.Drawing.Point(135, 10);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(155, 199);
            this.CategoryList.Sorted = true;
            this.CategoryList.TabIndex = 2;
            // 
            // ExtensionList
            // 
            this.ExtensionList.LabelEdit = true;
            this.ExtensionList.Location = new System.Drawing.Point(135, 10);
            this.ExtensionList.Name = "ExtensionList";
            this.ExtensionList.Size = new System.Drawing.Size(154, 199);
            this.ExtensionList.TabIndex = 6;
            this.ExtensionList.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.BeforeLabelEdit);
            this.ExtensionList.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.AfterLabelEdit);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(318, 34);
            this.AddButton.Margin = new System.Windows.Forms.Padding(25);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(40, 40);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddClick);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(318, 124);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(25);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(40, 40);
            this.RemoveButton.TabIndex = 7;
            this.RemoveButton.Text = "-";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveClick);
            // 
            // SetDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.GeneralList);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.ExtensionList);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CanButton);
            this.Controls.Add(this.RevertButton);
            this.Controls.Add(this.SettingsTree);
            this.Name = "SetDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CanButton;
        private System.Windows.Forms.Button RevertButton;
        private System.Windows.Forms.TreeView SettingsTree;
        private System.Windows.Forms.ListView GeneralList;
        private System.Windows.Forms.CheckedListBox CategoryList;
        private System.Windows.Forms.TreeView ExtensionList;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
    }
}