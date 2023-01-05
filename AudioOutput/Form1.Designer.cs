namespace AudioOutput
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_PlayAudioWavSingle = new System.Windows.Forms.Button();
            this.Button_StopAudioWavLoop = new System.Windows.Forms.Button();
            this.Button_PlayAudioWavLoop = new System.Windows.Forms.Button();
            this.Button_PlayAudioMp3Single = new System.Windows.Forms.Button();
            this.Button_PlayAudioMp3Simul = new System.Windows.Forms.Button();
            this.Button_PlayAudioMp3Playlist = new System.Windows.Forms.Button();
            this.Button_PlayAudioMp3Loop = new System.Windows.Forms.Button();
            this.Button_StopAudioMp3Loop = new System.Windows.Forms.Button();
            this.Button_GoodLooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_PlayAudioWavSingle
            // 
            this.Button_PlayAudioWavSingle.Location = new System.Drawing.Point(21, 24);
            this.Button_PlayAudioWavSingle.Name = "Button_PlayAudioWavSingle";
            this.Button_PlayAudioWavSingle.Size = new System.Drawing.Size(153, 49);
            this.Button_PlayAudioWavSingle.TabIndex = 0;
            this.Button_PlayAudioWavSingle.Text = "Play Single WAV Audio";
            this.Button_PlayAudioWavSingle.UseVisualStyleBackColor = true;
            this.Button_PlayAudioWavSingle.Click += new System.EventHandler(this.Button_PlayAudioWavSingle_Click);
            // 
            // Button_StopAudioWavLoop
            // 
            this.Button_StopAudioWavLoop.Location = new System.Drawing.Point(21, 136);
            this.Button_StopAudioWavLoop.Name = "Button_StopAudioWavLoop";
            this.Button_StopAudioWavLoop.Size = new System.Drawing.Size(153, 51);
            this.Button_StopAudioWavLoop.TabIndex = 1;
            this.Button_StopAudioWavLoop.Text = "Stop Loop WAV Audio";
            this.Button_StopAudioWavLoop.UseVisualStyleBackColor = true;
            this.Button_StopAudioWavLoop.Click += new System.EventHandler(this.Button_PlayAudioWavLoop_Click);
            // 
            // Button_PlayAudioWavLoop
            // 
            this.Button_PlayAudioWavLoop.Location = new System.Drawing.Point(21, 79);
            this.Button_PlayAudioWavLoop.Name = "Button_PlayAudioWavLoop";
            this.Button_PlayAudioWavLoop.Size = new System.Drawing.Size(153, 51);
            this.Button_PlayAudioWavLoop.TabIndex = 2;
            this.Button_PlayAudioWavLoop.Text = "Play Loop WAV Audio";
            this.Button_PlayAudioWavLoop.UseVisualStyleBackColor = true;
            this.Button_PlayAudioWavLoop.Click += new System.EventHandler(this.Button_PlayAudioWavLoop_Click);
            // 
            // Button_PlayAudioMp3Single
            // 
            this.Button_PlayAudioMp3Single.Location = new System.Drawing.Point(180, 24);
            this.Button_PlayAudioMp3Single.Name = "Button_PlayAudioMp3Single";
            this.Button_PlayAudioMp3Single.Size = new System.Drawing.Size(152, 50);
            this.Button_PlayAudioMp3Single.TabIndex = 3;
            this.Button_PlayAudioMp3Single.Text = "Play Single MP3 Audio";
            this.Button_PlayAudioMp3Single.UseVisualStyleBackColor = true;
            this.Button_PlayAudioMp3Single.Click += new System.EventHandler(this.Button_PlayAudioMp3Single_Click);
            // 
            // Button_PlayAudioMp3Simul
            // 
            this.Button_PlayAudioMp3Simul.Location = new System.Drawing.Point(180, 79);
            this.Button_PlayAudioMp3Simul.Name = "Button_PlayAudioMp3Simul";
            this.Button_PlayAudioMp3Simul.Size = new System.Drawing.Size(152, 51);
            this.Button_PlayAudioMp3Simul.TabIndex = 4;
            this.Button_PlayAudioMp3Simul.Text = "Play MP3 Audio Simultaneously";
            this.Button_PlayAudioMp3Simul.UseVisualStyleBackColor = true;
            this.Button_PlayAudioMp3Simul.Click += new System.EventHandler(this.Button_PlayAudioMp3Simul_Click);
            // 
            // Button_PlayAudioMp3Playlist
            // 
            this.Button_PlayAudioMp3Playlist.Location = new System.Drawing.Point(180, 137);
            this.Button_PlayAudioMp3Playlist.Name = "Button_PlayAudioMp3Playlist";
            this.Button_PlayAudioMp3Playlist.Size = new System.Drawing.Size(152, 51);
            this.Button_PlayAudioMp3Playlist.TabIndex = 5;
            this.Button_PlayAudioMp3Playlist.Text = "Play MP3 Playlist";
            this.Button_PlayAudioMp3Playlist.UseVisualStyleBackColor = true;
            this.Button_PlayAudioMp3Playlist.Click += new System.EventHandler(this.Button_PlayAudioMp3Playlist_Click);
            // 
            // Button_PlayAudioMp3Loop
            // 
            this.Button_PlayAudioMp3Loop.Location = new System.Drawing.Point(338, 24);
            this.Button_PlayAudioMp3Loop.Name = "Button_PlayAudioMp3Loop";
            this.Button_PlayAudioMp3Loop.Size = new System.Drawing.Size(151, 50);
            this.Button_PlayAudioMp3Loop.TabIndex = 6;
            this.Button_PlayAudioMp3Loop.Text = "Play Loop MP3 Audio";
            this.Button_PlayAudioMp3Loop.UseVisualStyleBackColor = true;
            this.Button_PlayAudioMp3Loop.Click += new System.EventHandler(this.Button_PlayAudioMp3Loop_Click);
            // 
            // Button_StopAudioMp3Loop
            // 
            this.Button_StopAudioMp3Loop.Location = new System.Drawing.Point(338, 79);
            this.Button_StopAudioMp3Loop.Name = "Button_StopAudioMp3Loop";
            this.Button_StopAudioMp3Loop.Size = new System.Drawing.Size(151, 51);
            this.Button_StopAudioMp3Loop.TabIndex = 7;
            this.Button_StopAudioMp3Loop.Text = "Stop Loop MP3 Audio";
            this.Button_StopAudioMp3Loop.UseVisualStyleBackColor = true;
            this.Button_StopAudioMp3Loop.Click += new System.EventHandler(this.Button_PlayAudioMp3Loop_Click);
            // 
            // Button_GoodLooking
            // 
            this.Button_GoodLooking.Location = new System.Drawing.Point(338, 137);
            this.Button_GoodLooking.Name = "Button_GoodLooking";
            this.Button_GoodLooking.Size = new System.Drawing.Size(151, 50);
            this.Button_GoodLooking.TabIndex = 8;
            this.Button_GoodLooking.Text = "Just For Good Looking";
            this.Button_GoodLooking.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 236);
            this.Controls.Add(this.Button_GoodLooking);
            this.Controls.Add(this.Button_StopAudioMp3Loop);
            this.Controls.Add(this.Button_PlayAudioMp3Loop);
            this.Controls.Add(this.Button_PlayAudioMp3Playlist);
            this.Controls.Add(this.Button_PlayAudioMp3Simul);
            this.Controls.Add(this.Button_PlayAudioMp3Single);
            this.Controls.Add(this.Button_PlayAudioWavLoop);
            this.Controls.Add(this.Button_StopAudioWavLoop);
            this.Controls.Add(this.Button_PlayAudioWavSingle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Button_PlayAudioWavSingle;
        private Button Button_StopAudioWavLoop;
        private Button Button_PlayAudioWavLoop;
        private Button Button_PlayAudioMp3Single;
        private Button Button_PlayAudioMp3Simul;
        private Button Button_PlayAudioMp3Playlist;
        private Button Button_PlayAudioMp3Loop;
        private Button Button_StopAudioMp3Loop;
        private Button Button_GoodLooking;
    }
}