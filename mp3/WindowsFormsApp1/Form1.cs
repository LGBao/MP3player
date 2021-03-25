using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fr_MP3 : Form
    {
        public fr_MP3()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "MP3|*.mp3";
            lst_nhac.Items.Clear();

            if(open.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
               // axWindowsMediaPlayer1.URL = open.FileName;
                WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayer1.newPlaylist("my playlist",string.Empty);

                foreach ( string file in open.FileNames)
                {
                    WMPLib.IWMPMedia Mmedia = axWindowsMediaPlayer1.newMedia(file);
                    playlist.appendItem(Mmedia);
                    lst_nhac.Items.Add(file);
                }
                axWindowsMediaPlayer1.currentPlaylist = playlist;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer1.settings.autoStart = true;
                axWindowsMediaPlayer1.settings.setMode("loop", true);
                
            }    
        }

        private void lst_nhac_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = lst_nhac.FocusedItem.Text;
        }

        private void saveListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists("Mylist.txt"))
            {
                File.Create("Mylist.txt");
                
            }
            
            FileStream stream = File.OpenWrite("Mylist.txt");
            StreamWriter write = new StreamWriter(stream);
            foreach (ListViewItem item in lst_nhac.Items)
            {
                write.WriteLine(item.Text);
            }
            write.Close();
            stream.Close();
            MessageBox.Show("sucess........^^");
        }

        private void loadPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream stream = File.OpenRead("Mylist.txt");
            StreamReader read = new StreamReader(stream);
            string line = "";
            lst_nhac.Items.Clear();
            WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayer1.newPlaylist("my playlist", string.Empty);
            while ((line=read.ReadLine())!=null)
            {
                WMPLib.IWMPMedia Mmedia = axWindowsMediaPlayer1.newMedia(line);
                playlist.appendItem(Mmedia);
                lst_nhac.Items.Add(line);
            }
            axWindowsMediaPlayer1.currentPlaylist = playlist;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }
        private void Exit()
        {
            Application.Exit();
        }    
        private void fr_MP3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("bạn có chắc muốn thoát","thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }
    }
}
