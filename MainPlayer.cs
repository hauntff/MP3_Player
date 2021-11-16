using Mp3Player;
using MP3player;
using System;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainPlayer : Form
    {
        private ArrayList nowPlaylist = new ArrayList();
        private readonly Player pl = new Player();

        public MainPlayer()
        {
            InitializeComponent();
            lstBoxPlayList.Items.Add(@"C:\Users\Admin\source\repos\WindowsFormsApp1\The Rare Occasions-Notion.mp3");
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            lstBoxPlayList.Items.Clear();
            openPlaylistDialog.ShowDialog();
            var readList = new Playlist
            {
                PlayListPath = openPlaylistDialog.FileName
            };
            nowPlaylist = readList.PlayList;
            for (int x = 0; x < nowPlaylist.Count; x++)
                lstBoxPlayList.Items.Add(nowPlaylist[x]);
            lstBoxPlayList.SetSelected(0, true);
        }

        private void lstBoxPlayList_DoubleClick(object sender, System.EventArgs e)
        {
            pl.Close();
            pl.Open(lstBoxPlayList.SelectedItem.ToString());
            pl.Play(false);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            pl.Close();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            pl.Pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (lstBoxPlayList.Items.Count > 0)
            {
                pl.Open(lstBoxPlayList.SelectedItem.ToString());
                pl.Play(false);
            }
        }

        private void leftVolume_Scroll(object sender, EventArgs e)
        {
            pl.LeftVolume = leftVolume.Value * 100;
        }

        private void rightVolume_Scroll(object sender, EventArgs e)
        {
            pl.RightVolume = rightVolume.Value * 100;
        }

        private void masterVolume_Scroll(object sender, EventArgs e)
        {
            pl.MasterVolume = masterVolume.Value * 100;
        }

        private void BassBar_Scroll(object sender, EventArgs e)
        {
            pl.Bass = BassBar.Value * 100;
        }

        private void TrebleBar_Scroll(object sender, EventArgs e)
        {
            pl.Treble = TrebleBar.Value * 100;
        }

    }
}
