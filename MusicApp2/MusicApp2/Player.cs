using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using System.IO;
using static System.Net.WebRequestMethods;
using System.Data.SqlClient;

namespace MusicApp2
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
            lbl_volume.Text = "50%";
            errorProvider1.SetIconAlignment(track_list, ErrorIconAlignment.MiddleRight);

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string[] paths, files;



        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            

            ofd.Multiselect = true;
            
            int userId = User.Id;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;

                for(int i = 0; i < files.Length; i++)
                {
                    track_list.Items.Add(files[i]);
                }
            }
        }



        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex >= 0)
            {
                media_plyr.URL = paths[track_list.SelectedIndex];
                media_plyr.Ctlcontrols.play();
                errorProvider1.SetError(track_list, "");
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex >= 0)
            {
                media_plyr.Ctlcontrols.play();
                errorProvider1.SetError(track_list, "");
            }
            else
            {
                errorProvider1.SetError(track_list, "Track list is empty, please add songs.");
            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex >= 0)
            {
                media_plyr.Ctlcontrols.pause();
                errorProvider1.SetError(track_list, "");
            }
            else
            {
                errorProvider1.SetError(track_list, "Track list is empty, please add songs.");
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex >= 0)
            {
                if (track_list.SelectedIndex < track_list.Items.Count - 1)
                {
                    track_list.SelectedIndex = track_list.SelectedIndex + 1;
                }
                errorProvider1.SetError(track_list, "");
            }
            else
            {
                errorProvider1.SetError(track_list, "Track list is empty, please add songs.");
            }            
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            if(track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }
         private void btn_stop_Click(object sender, EventArgs e)
         {
            if (track_list.SelectedIndex >= 0)
            {
                media_plyr.Ctlcontrols.stop();
                errorProvider1.SetError(track_list, "");
            }
            else
            {
                errorProvider1.SetError(track_list, "Track list is empty, please add songs.");
            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(media_plyr.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_bar.Maximum = (int)media_plyr.Ctlcontrols.currentItem.duration;
                p_bar.Value = (int)media_plyr.Ctlcontrols.currentPosition;
            }
            try
            {
                lbl_start.Text = media_plyr.Ctlcontrols.currentPositionString;
               // lbl_end.Text = media_plyr.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch { }
        }

        private void mouse_down(object sender, MouseEventArgs e)
        {
            if (track_list.SelectedIndex >= 0)
            {
                media_plyr.Ctlcontrols.currentPosition = media_plyr.currentMedia.duration * e.X / p_bar.Width;
                errorProvider1.SetError(track_list, "");
            }
            else
            {
                errorProvider1.SetError(track_list, "Track list is empty, please add songs.");
            }
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {            
            if (track_list.SelectedIndex >= 0)
            {
                media_plyr.settings.volume = trackBar1.Value;
                lbl_volume.Text = trackBar1.Value.ToString() + "%";
                errorProvider1.SetError(track_list, "");
            }
            else
            {
                errorProvider1.SetError(track_list, "Track list is empty, please add songs.");
            }
        }


    }
}
