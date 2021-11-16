
namespace WindowsFormsApp1
{
    partial class MainPlayer
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.grpBoxLeftRight = new System.Windows.Forms.GroupBox();
            this.lblLV = new System.Windows.Forms.Label();
            this.lblRV = new System.Windows.Forms.Label();
            this.rightVolume = new System.Windows.Forms.TrackBar();
            this.leftVolume = new System.Windows.Forms.TrackBar();
            this.lstBoxPlayList = new System.Windows.Forms.ListBox();
            this.openPlaylistDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpBoxMasterVolume = new System.Windows.Forms.GroupBox();
            this.lblMasterVolume = new System.Windows.Forms.Label();
            this.masterVolume = new System.Windows.Forms.TrackBar();
            this.grpBoxBassTreble = new System.Windows.Forms.GroupBox();
            this.lbltreble = new System.Windows.Forms.Label();
            this.TrebleBar = new System.Windows.Forms.TrackBar();
            this.lblBass = new System.Windows.Forms.Label();
            this.BassBar = new System.Windows.Forms.TrackBar();
            this.grpBoxLeftRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftVolume)).BeginInit();
            this.grpBoxMasterVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterVolume)).BeginInit();
            this.grpBoxBassTreble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrebleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BassBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(263, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(61, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(396, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(61, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(330, 12);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(61, 23);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(61, 23);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // grpBoxLeftRight
            // 
            this.grpBoxLeftRight.Controls.Add(this.lblLV);
            this.grpBoxLeftRight.Controls.Add(this.lblRV);
            this.grpBoxLeftRight.Controls.Add(this.rightVolume);
            this.grpBoxLeftRight.Controls.Add(this.leftVolume);
            this.grpBoxLeftRight.Location = new System.Drawing.Point(16, 176);
            this.grpBoxLeftRight.Name = "grpBoxLeftRight";
            this.grpBoxLeftRight.Size = new System.Drawing.Size(128, 197);
            this.grpBoxLeftRight.TabIndex = 10;
            this.grpBoxLeftRight.TabStop = false;
            this.grpBoxLeftRight.Text = "Left/Right Volume";
            // 
            // lblLV
            // 
            this.lblLV.AutoSize = true;
            this.lblLV.Location = new System.Drawing.Point(27, 170);
            this.lblLV.Name = "lblLV";
            this.lblLV.Size = new System.Drawing.Size(25, 13);
            this.lblLV.TabIndex = 12;
            this.lblLV.Text = "Left";
            // 
            // lblRV
            // 
            this.lblRV.AutoSize = true;
            this.lblRV.Location = new System.Drawing.Point(72, 170);
            this.lblRV.Name = "lblRV";
            this.lblRV.Size = new System.Drawing.Size(32, 13);
            this.lblRV.TabIndex = 11;
            this.lblRV.Text = "Right";
            // 
            // rightVolume
            // 
            this.rightVolume.LargeChange = 1;
            this.rightVolume.Location = new System.Drawing.Point(67, 19);
            this.rightVolume.Name = "rightVolume";
            this.rightVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.rightVolume.Size = new System.Drawing.Size(42, 148);
            this.rightVolume.TabIndex = 10;
            this.rightVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.rightVolume.Value = 5;
            this.rightVolume.Scroll += new System.EventHandler(this.rightVolume_Scroll);
            // 
            // leftVolume
            // 
            this.leftVolume.LargeChange = 1;
            this.leftVolume.Location = new System.Drawing.Point(19, 19);
            this.leftVolume.Name = "leftVolume";
            this.leftVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.leftVolume.Size = new System.Drawing.Size(42, 148);
            this.leftVolume.TabIndex = 9;
            this.leftVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.leftVolume.Value = 5;
            this.leftVolume.Scroll += new System.EventHandler(this.leftVolume_Scroll);
            // 
            // lstBoxPlayList
            // 
            this.lstBoxPlayList.FormattingEnabled = true;
            this.lstBoxPlayList.Location = new System.Drawing.Point(16, 49);
            this.lstBoxPlayList.Name = "lstBoxPlayList";
            this.lstBoxPlayList.Size = new System.Drawing.Size(441, 121);
            this.lstBoxPlayList.TabIndex = 11;
            this.lstBoxPlayList.DoubleClick += new System.EventHandler(this.lstBoxPlayList_DoubleClick);
            // 
            // openPlaylistDialog
            // 
            this.openPlaylistDialog.FileName = "*.wpl";
            this.openPlaylistDialog.Filter = "Playlist|*.wpl";
            this.openPlaylistDialog.Title = "Select Windows Media Playlist";
            // 
            // grpBoxMasterVolume
            // 
            this.grpBoxMasterVolume.Controls.Add(this.lblMasterVolume);
            this.grpBoxMasterVolume.Controls.Add(this.masterVolume);
            this.grpBoxMasterVolume.Location = new System.Drawing.Point(175, 176);
            this.grpBoxMasterVolume.Name = "grpBoxMasterVolume";
            this.grpBoxMasterVolume.Size = new System.Drawing.Size(87, 197);
            this.grpBoxMasterVolume.TabIndex = 12;
            this.grpBoxMasterVolume.TabStop = false;
            this.grpBoxMasterVolume.Text = "Main Volume";
            // 
            // lblMasterVolume
            // 
            this.lblMasterVolume.AutoSize = true;
            this.lblMasterVolume.Location = new System.Drawing.Point(22, 170);
            this.lblMasterVolume.Name = "lblMasterVolume";
            this.lblMasterVolume.Size = new System.Drawing.Size(39, 13);
            this.lblMasterVolume.TabIndex = 11;
            this.lblMasterVolume.Text = "Master";
            // 
            // masterVolume
            // 
            this.masterVolume.LargeChange = 1;
            this.masterVolume.Location = new System.Drawing.Point(21, 19);
            this.masterVolume.Name = "masterVolume";
            this.masterVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.masterVolume.Size = new System.Drawing.Size(42, 148);
            this.masterVolume.TabIndex = 10;
            this.masterVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.masterVolume.Value = 5;
            this.masterVolume.Scroll += new System.EventHandler(this.masterVolume_Scroll);
            // 
            // grpBoxBassTreble
            // 
            this.grpBoxBassTreble.Controls.Add(this.lbltreble);
            this.grpBoxBassTreble.Controls.Add(this.TrebleBar);
            this.grpBoxBassTreble.Controls.Add(this.lblBass);
            this.grpBoxBassTreble.Controls.Add(this.BassBar);
            this.grpBoxBassTreble.Location = new System.Drawing.Point(288, 175);
            this.grpBoxBassTreble.Name = "grpBoxBassTreble";
            this.grpBoxBassTreble.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpBoxBassTreble.Size = new System.Drawing.Size(169, 197);
            this.grpBoxBassTreble.TabIndex = 13;
            this.grpBoxBassTreble.TabStop = false;
            this.grpBoxBassTreble.Text = "Sound";
            // 
            // lbltreble
            // 
            this.lbltreble.AutoSize = true;
            this.lbltreble.Location = new System.Drawing.Point(104, 170);
            this.lbltreble.Name = "lbltreble";
            this.lbltreble.Size = new System.Drawing.Size(37, 13);
            this.lbltreble.TabIndex = 13;
            this.lbltreble.Text = "Treble";
            // 
            // TrebleBar
            // 
            this.TrebleBar.LargeChange = 1;
            this.TrebleBar.Location = new System.Drawing.Point(102, 19);
            this.TrebleBar.Name = "TrebleBar";
            this.TrebleBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrebleBar.Size = new System.Drawing.Size(42, 148);
            this.TrebleBar.TabIndex = 12;
            this.TrebleBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrebleBar.Value = 5;
            this.TrebleBar.Scroll += new System.EventHandler(this.TrebleBar_Scroll);
            // 
            // lblBass
            // 
            this.lblBass.AutoSize = true;
            this.lblBass.Location = new System.Drawing.Point(27, 170);
            this.lblBass.Name = "lblBass";
            this.lblBass.Size = new System.Drawing.Size(30, 13);
            this.lblBass.TabIndex = 11;
            this.lblBass.Text = "Bass";
            // 
            // BassBar
            // 
            this.BassBar.LargeChange = 1;
            this.BassBar.Location = new System.Drawing.Point(21, 19);
            this.BassBar.Name = "BassBar";
            this.BassBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BassBar.Size = new System.Drawing.Size(42, 148);
            this.BassBar.TabIndex = 10;
            this.BassBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.BassBar.Value = 5;
            this.BassBar.Scroll += new System.EventHandler(this.BassBar_Scroll);
            // 
            // MainPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 384);
            this.Controls.Add(this.grpBoxBassTreble);
            this.Controls.Add(this.grpBoxMasterVolume);
            this.Controls.Add(this.lstBoxPlayList);
            this.Controls.Add(this.grpBoxLeftRight);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Name = "MainPlayer";
            this.Text = "Audio Player";
            this.grpBoxLeftRight.ResumeLayout(false);
            this.grpBoxLeftRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftVolume)).EndInit();
            this.grpBoxMasterVolume.ResumeLayout(false);
            this.grpBoxMasterVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterVolume)).EndInit();
            this.grpBoxBassTreble.ResumeLayout(false);
            this.grpBoxBassTreble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrebleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BassBar)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox grpBoxLeftRight;
        private System.Windows.Forms.Label lblLV;
        private System.Windows.Forms.Label lblRV;
        private System.Windows.Forms.TrackBar rightVolume;
        private System.Windows.Forms.TrackBar leftVolume;
        private System.Windows.Forms.ListBox lstBoxPlayList;
        private System.Windows.Forms.OpenFileDialog openPlaylistDialog;
        private System.Windows.Forms.GroupBox grpBoxMasterVolume;
        private System.Windows.Forms.Label lblMasterVolume;
        private System.Windows.Forms.TrackBar masterVolume;
        private System.Windows.Forms.GroupBox grpBoxBassTreble;
        private System.Windows.Forms.Label lblBass;
        private System.Windows.Forms.TrackBar BassBar;
        private System.Windows.Forms.Label lbltreble;
        private System.Windows.Forms.TrackBar TrebleBar;
    }

}

