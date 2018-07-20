using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyujinxAutoUpdate
{
    public partial class AddGameListEntry : Form
    {
        private bool isUnlocked = false;
        private GameList.GameListMetaData Meta;

        public AddGameListEntry()
        {
            InitializeComponent();
        }

        private void AddGameListEntry_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Images/main.ico");
            UpdateLock();
            GetMetadataCDN.Visible = Settings.GET_METADATA_FROM_CDN;
            ScanDir.Visible        = Settings.GET_METADATA_FROM_CDN;
            ScanState.Text         = "";
            Meta                   = new GameList.GameListMetaData();
        }

        private void SelectGamePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog
            {
                Description = "Please select a RomFS / ExeFS Folder."
            };

            DialogResult result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                PathText.Text = folderBrowser.SelectedPath;
                if (GameList.IsGameDirectoryValid(folderBrowser.SelectedPath))
                {
                    if (!String.IsNullOrWhiteSpace(PathText.Text))
                    {
                        isUnlocked = true;
                        Add.Enabled = true;
                        ScanDir.Enabled = false;
                    }

                    UpdateLock();
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(PathText.Text))
                    {
                        ScanDir.Enabled = true;
                        Add.Enabled = true;
                    }
                }
                
                folderBrowser.Dispose();
            }
            else if (result == DialogResult.Cancel)
            {
                folderBrowser.Dispose();
                return;
            }
        }

        private void SelectThumbnail_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Please select a JPEG."
            };

            fileDialog.Filter = "JPEG File (*.jpg, *.jpeg)|*.jpg;*.jpeg";

            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (HasJpegHeader(fileDialog.FileName))
                {
                    ThumbnailPath.Text = fileDialog.FileName;

                    Image image = System.Drawing.Image.FromFile(ThumbnailPath.Text);
                    Bitmap scaledImage = ResizeImage(image, 256, 256);
                    Thumbnail.Image = scaledImage;
                }
                else
                {
                    MessageBox.Show("This file is not a JPEG, please select a JPEG file.", "Error");
                }

                fileDialog.Dispose();
            }
            else if (result == DialogResult.Cancel)
            {
                fileDialog.Dispose();
                return;
            }
        }

        private void SelectNacpPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Please select a NACP."
            };

            fileDialog.Filter = "NACP File (*.nacp)|*.nacp";

            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ContentNacpPath.Text = fileDialog.FileName;

                Meta = RyujinxAutoUpdate.GameList.ParseGameFiles(PathText.Text, ContentNacpPath.Text);

                if (!String.IsNullOrWhiteSpace(Meta.nacp.TitleName)) GameName.Text      = Meta.nacp.TitleName;
                if (!String.IsNullOrWhiteSpace(Meta.nacp.Publisher)) PublisherName.Text = Meta.nacp.Publisher;

                fileDialog.Dispose();
            }
            else if (result == DialogResult.Cancel)
            {
                fileDialog.Dispose();
                return;
            }
        }

        private void GetMetadataCDN_Click(object sender, EventArgs e)
        {
            if (Meta.npdm.TitleID == null) Meta = GameList.ParseGameFiles(PathText.Text);
            GameList.GameListNACP nacp = NintendoCDN.GetGameMetadata(Meta.npdm.TitleID);
            GameName.Text = nacp.TitleName;
            PublisherName.Text = nacp.Publisher;

            Image image = Image.FromFile("./Images/GameThumbnails/" + Meta.npdm.TitleID + ".jpg");
            Bitmap scaledImage = ResizeImage(image, 256, 256);
            Thumbnail.Image = scaledImage;
        }
        List<GameList.GameListEntry> entrysfound;

        private void ScanDir_Click(object sender, EventArgs e)
        {
            entrysfound = new List<GameList.GameListEntry>();
            int foundgames = 0;
            int skippedgames = 0;

            foreach (string dir in Directory.GetDirectories(PathText.Text))
            {
                if (GameList.IsGameDirectoryValid(dir))
                {
                    ScanState.Text = "Games found: " + foundgames + "\nSkipped Games (Aka Games not found on the CDN): " + skippedgames + "\n(This process may take a while)";
                    GameList.GameListMetaData metaData = GameList.ParseGameFiles(dir);
                    metaData.nacp = NintendoCDN.GetGameMetadata(metaData.npdm.TitleID);

                    if (metaData.nacp.TitleName == null)
                    {
                        ++skippedgames;
                        continue;
                    }

                    GameList.GameListEntry entry = new GameList.GameListEntry
                    {
                        AppName = metaData.nacp.TitleName,
                        Publisher = metaData.nacp.Publisher,
                        TitleID   = metaData.npdm.TitleID,
                        GamePath  = dir
                    };

                    entrysfound.Add(entry);
                    ++foundgames;
                }
            }

            ScanState.Text = "All Games found: " + foundgames + "\nAll Games Skipped: " + skippedgames;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (entrysfound != null)
            {
                foreach (GameList.GameListEntry entry in entrysfound) GameList.AddGameListEntry(entry);

                MainForm.ReloadGameList();
            }
            else
            {
                if (Meta.npdm.TitleID == null) Meta = GameList.ParseGameFiles(PathText.Text);

                if (!String.IsNullOrWhiteSpace(ThumbnailPath.Text))
                {
                    if (File.Exists("./Images/GameThumbnails/" + Meta.npdm.TitleID + ".jpg"))
                        File.Delete("./Images/GameThumbnails/" + Meta.npdm.TitleID + ".jpg");
                    File.Copy(ThumbnailPath.Text, "./Images/GameThumbnails/" + Meta.npdm.TitleID + ".jpg");
                }

                GameList.GameListEntry entry = new GameList.GameListEntry();

                if (String.IsNullOrWhiteSpace(GameName.Text) || String.IsNullOrWhiteSpace(PublisherName.Text))
                {
                    MessageBox.Show("Please fill in the Game Name and or the Publisher Name.", "Error");
                    return;
                }

                entry.AppName = GameName.Text;
                entry.Publisher = PublisherName.Text;
                entry.GamePath = PathText.Text;
                entry.TitleID = Meta.npdm.TitleID;

                GameList.AddGameListEntry(entry);
                MainForm.ReloadGameList();

                Meta = new GameList.GameListMetaData();
            }

            this.Close();
        }

        private static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode    = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode  = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode      = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode    = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private static bool HasJpegHeader(string filename)
        {
            using (BinaryReader br = new BinaryReader(File.Open(filename, FileMode.Open, FileAccess.Read)))
            {
                UInt16 soi    = br.ReadUInt16();  // Start of Image (SOI) marker (FFD8)
                UInt16 marker = br.ReadUInt16(); // JFIF marker (FFE0) or EXIF marker(FF01)

                return soi == 0xd8ff && (marker & 0xe0ff) == 0xe0ff;
            }
        }

        private void UpdateLock()
        {
            SelectNacpPath.Enabled  = isUnlocked;
            ContentNacpPath.Enabled = isUnlocked;
            GameName.Enabled        = isUnlocked;
            PublisherName.Enabled   = isUnlocked;
            SelectThumbnail.Enabled = isUnlocked;
            ThumbnailPath.Enabled   = isUnlocked;
            GetMetadataCDN.Enabled  = isUnlocked;
        }
    }
}
