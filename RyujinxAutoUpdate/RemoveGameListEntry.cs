using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyujinxAutoUpdate
{
    public partial class RemoveGameListEntry : Form
    {
        public RemoveGameListEntry()
        {
            InitializeComponent();
        }

        private void RemoveGameListEntry_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Images/main.ico");
            RemoveGameList.LargeImageList = MainForm.Instance.GameListImages;
            UpdateList();
        }

        private void RemoveGameList_ItemActivate(object sender, EventArgs e)
        {
            string TitleID = (string)((ListView)sender).SelectedItems[0].Tag;
            string Name    = (string)((ListView)sender).SelectedItems[0].Text;
            DialogResult res = MessageBox.Show("Are you sure you want to Delete " + Name + " (" + TitleID + ")?", "Are you sure?", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                GameList.RemoveGameListEntry(TitleID);
                MainForm.ReloadGameList();
                UpdateList();
            }
        }

        private void UpdateList()
        {
            RemoveGameList.Items.Clear();

            foreach (ListViewItem item in MainForm.Instance.GameList.Items) RemoveGameList.Items.Add(((ListViewItem)item.Clone()));
        }
    }
}
