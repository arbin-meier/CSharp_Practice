using System.Media;

namespace AudioOutput
{
    public partial class Form1 : Form
    {
        #region SoundPlayer
        private List<Task> _taskList = new List<Task>();
        private SoundPlayer _loopPlayer = null;
        private WMPLib.WindowsMediaPlayer _wLoopPlayer = null;
        public Form1()
        {
            InitializeComponent();
        }

        //Embeded within .NET library
        private void Button_PlayAudioWavSingle_Click(object sender, EventArgs e)
        {            
            //Threaded player
            var task1 = Task.Factory.StartNew(() =>
            {
                PlayWavAudioSingle((s, e) => MessageBox.Show("Done playing."));
            });
            _taskList.Add(task1 as Task);            

            //Normal player
            //PlayWavAudioSingle((s, e) => MessageBox.Show("Done playing."));
        }

        private void PlayWavAudioSingle(EventHandler donePlayCallBack = null)
        {
            //SoundPlayer player = new SoundPlayer("StarWars3.wav"); //System.Media.SoundPlayer
            //Or 
            SoundPlayer player = new SoundPlayer() { SoundLocation = "StarWars3.wav" };

            player.PlaySync(); //Use current thread for playing sound
            //Callback after the sound finished playing, since no default field like SoundFinished exists.
            if (donePlayCallBack != null)
            {
                // the callback is executed on the thread.
                donePlayCallBack(player, new EventArgs());
            }
        }

        private void Button_PlayAudioWavLoop_Click(object sender, EventArgs e)
        {
            if (sender == Button_PlayAudioWavLoop)
            {
                _loopPlayer = new SoundPlayer();

                try
                {
                    _loopPlayer.SoundLocation = "StarWars3.wav";
                    _loopPlayer.LoadAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                _loopPlayer.PlayLooping(); //PlayLooping() opens its own thread
            }
            else if (sender == Button_StopAudioWavLoop)
            {
                if (_loopPlayer != null) _loopPlayer.Stop();
            }
        }
        #endregion


        #region WMPLib Windows Media Player

        private void Button_PlayAudioMp3Single_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = "SoundEffect1.mp3";
            wplayer.controls.play();
        }

        private void Button_PlayAudioMp3Simul_Click(object sender, EventArgs e)
        {
            //
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = "SoundEffect1.mp3";
            wplayer.controls.play();

            WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();
            wplayer2.URL = "StarWars3.mp3";
            wplayer2.controls.play();
        }

        private void Button_PlayAudioMp3Playlist_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            var playlist = wplayer.newPlaylist("Mp3 playlist", "");
            playlist.appendItem(wplayer.newMedia("SoundEffect1.mp3"));
            playlist.appendItem(wplayer.newMedia("StarWars3.mp3"));

            wplayer.currentPlaylist = playlist;
            wplayer.controls.play();

            //No support of forum thread which provides playing delays in between each 
            //sound effects in the playlist. Use different player Winamp.
        }

        private void Button_PlayAudioMp3Loop_Click(object sender, EventArgs e)
        {
            //Method #1
            if (sender == Button_PlayAudioMp3Loop)
            {
                _wLoopPlayer = new WMPLib.WindowsMediaPlayer();
                _wLoopPlayer.settings.setMode("loop", true);
                _wLoopPlayer.URL = "StarWars3.mp3";
                _wLoopPlayer.controls.play();
            }
            else if (sender == Button_StopAudioMp3Loop)
            {
                _wLoopPlayer.controls.pause();
            }
        }
        #endregion
    }
}