using MiscLib;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SortOf
{
    public partial class SetDialog : Form
    {
        enum Page
        {
            Gen,
            Cats,
            Exts
        }

        Page Selected;

        string PrevName;

        CatList DefaultCat;
        CatList CurrentCat;

        public SetDialog()
        {
            DefaultCat = MainForm.CatList;
            CurrentCat = MainForm.CatList;

            InitializeComponent(); //Base
            Selected = Page.Gen; //Default Page
            UpdatePage(Selected);
            InitializeAll();
        }

        void InitGeneral()
        {

        }
        void InitCategories()
        {
            if (CategoryList.Items.Count > 0)
                CategoryList.Items.Clear();

            foreach (Category Cat in DefaultCat)
                CategoryList.Items.Add(new ListViewItem().Text = Cat.Name, Cat.ShouldSort);
        }
        void InitExtensions()
        {
            if (ExtensionList.GetNodeCount(true) > 0)
                ExtensionList.Nodes.Clear();

            foreach (Category Cat in DefaultCat)
            {
                TreeNode[] SubList = new TreeNode[Cat.Extensions.Count];

                for (int i = 0; i < Cat.Extensions.Count; i++)
                    SubList[i] = new TreeNode(Cat.Extensions[i].Name);

                ExtensionList.Nodes.Add(new TreeNode(Cat.Name, SubList));
            }
        }

        void UpdateCategories()
        {
            if (CategoryList.Items.Count > 0)
                CategoryList.Items.Clear();

            foreach (Category Cat in CurrentCat)
                if (Cat != null) CategoryList.Items.Add(new ListViewItem().Text = Cat.Name, Cat.ShouldSort);
        }
        void UpdateExtensions()
        {
            if (ExtensionList.GetNodeCount(true) > 0)
                ExtensionList.Nodes.Clear();

            foreach (Category Cat in CurrentCat)
            {
                TreeNode[] SubList = new TreeNode[Cat.Extensions.Count];

                for (int i = 0; i < Cat.Extensions.Count; i++)
                    SubList[i] = new TreeNode(Cat.Extensions[i].Name);

                ExtensionList.Nodes.Add(new TreeNode(Cat.Name, SubList));
            }
        }

        void InitializeAll()
        {
            InitGeneral();
            InitCategories();
            InitExtensions();
        }
        void UpdateAll()
        {
            UpdateCategories();
            UpdateExtensions();
        }

        void OnPageSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "GenNode":
                    Selected = Page.Gen;
                    break;
                case "CatNode":
                    Selected = Page.Cats;
                    break;
                case "ExtNode":
                    Selected = Page.Exts;
                    break;
            }

            UpdatePage(Selected);
        }

        void UpdatePage(Page page)
        {
            switch (page)
            {
                case Page.Gen:
                    GeneralList.Enabled = true;
                    GeneralList.Visible = true;
                    CategoryList.Enabled = false;
                    CategoryList.Visible = false;
                    ExtensionList.Enabled = false;
                    ExtensionList.Visible = false;
                    break;
                case Page.Cats:
                    GeneralList.Enabled = false;
                    GeneralList.Visible = false;
                    CategoryList.Enabled = true;
                    CategoryList.Visible = true;
                    ExtensionList.Enabled = false;
                    ExtensionList.Visible = false;
                    break;
                case Page.Exts:
                    GeneralList.Enabled = false;
                    GeneralList.Visible = false;
                    CategoryList.Enabled = false;
                    CategoryList.Visible = false;
                    ExtensionList.Enabled = true;
                    ExtensionList.Visible = true;
                    break;
            }
        }

        void RevertClick(object sender, EventArgs e)
        {
            DialogResult DefaultAsk = MessageBox.Show(SetDialog.ActiveForm,
                "Do you really want to revert the settings?",
                "Revert settings?",
                MessageBoxButtons.YesNo);

            if (DefaultAsk == DialogResult.Yes)
                InitializeAll();
        }

        void AddClick(object sender, EventArgs e)
        {
            switch (Selected)
            {
                case Page.Gen:
                    break;

                case Page.Cats:
                    CurrentCat.Add(new Category("New Category", true));
                    break;

                case Page.Exts:
                    if (ExtensionList.SelectedNode != null)
                    {
                        Category Cat;
                        if (ExtensionList.SelectedNode.Level == 0)
                            Cat = CurrentCat.First(x => x.Name == ExtensionList.SelectedNode.Text);
                        else Cat = CurrentCat.First(x => x.Name == ExtensionList.SelectedNode.Parent.Text);

                        if (Cat != null) Cat.Extensions.Add(new Extension(Cat, "New Extension"));
                    }
                    break;
            }
            UpdateAll();
        }

        void RemoveClick(object sender, EventArgs e)
        {
            switch (Selected)
            {
                case Page.Gen:
                    break;
                case Page.Cats:
                    if (CategoryList.SelectedItem != null)
                    {
                        string Item = CategoryList.Items[CategoryList.SelectedIndex] as string;

                        for (int i = 0; i < ExtensionList.Nodes.Count; i++)
                            if (ExtensionList.Nodes[i] != null)
                                if (ExtensionList.Nodes[i].Text == Item)
                                {
                                    ExtensionList.Nodes.Remove(ExtensionList.Nodes[i]);
                                    break;
                                }

                        CategoryList.Items.RemoveAt(CategoryList.SelectedIndex);
                    }
                    break;

                case Page.Exts:
                    if (ExtensionList.SelectedNode != null)
                        if (ExtensionList.SelectedNode.Level != 0)
                        {
                            Category Cat = CurrentCat.First(x => x.Name == ExtensionList.SelectedNode.Parent.Text);
                            if (Cat != null) Cat.Extensions.Remove(Cat.Extensions.Find(x => x.Name == ExtensionList.SelectedNode.Text));
                        }
                    break;
            }
            UpdateAll();
        }

        void AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.CancelEdit) return;

            CurrentCat.Find(x => x.Name == PrevName).Update(e.Label);

            UpdateCategories();
        }

        void BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            PrevName = e.Node.Text;
        }
    }
}