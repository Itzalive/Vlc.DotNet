﻿using System;
using System.ComponentModel;
using Vlc.DotNet.Core.TheLuggage;

namespace Vlc.DotNet.Forms
{
    public partial class VlcTheLuggageControl
    {
        private void RegisterEvents()
        {
            myVlcMediaPlayer.Backward += OnBackwardInternal;
            myVlcMediaPlayer.EncounteredError += OnEncounteredErrorInternal;
            myVlcMediaPlayer.EndReached += OnEndReachedInternal;
            myVlcMediaPlayer.Forward += OnForwardInternal;
            myVlcMediaPlayer.LengthChanged += OnLengthChangedInternal;
            myVlcMediaPlayer.MediaChanged += OnMediaChangedInternal;
            myVlcMediaPlayer.Opening += OnOpeningInternal;
            myVlcMediaPlayer.PausableChanged += OnPausableChangedInternal;
            myVlcMediaPlayer.Paused += OnPausedInternal;
            myVlcMediaPlayer.Playing += OnPlayingInternal;
            myVlcMediaPlayer.PositionChanged += OnPositionChangedInternal;
            myVlcMediaPlayer.SeekableChanged += OnSeekableChangedInternal;
            myVlcMediaPlayer.SnapshotTaken += OnSnapshotTakenInternal;
            myVlcMediaPlayer.Stopped += OnStoppedInternal;
            myVlcMediaPlayer.TimeChanged += OnTimeChangedInternal;
            myVlcMediaPlayer.TitleChanged += OnTitleChangedInternal;
        }

        private void UnregisterEvents()
        {
            myVlcMediaPlayer.Backward -= OnBackwardInternal;
            myVlcMediaPlayer.EncounteredError -= OnEncounteredErrorInternal;
            myVlcMediaPlayer.EndReached -= OnEndReachedInternal;
            myVlcMediaPlayer.Forward -= OnForwardInternal;
            myVlcMediaPlayer.LengthChanged -= OnLengthChangedInternal;
            myVlcMediaPlayer.MediaChanged -= OnMediaChangedInternal;
            myVlcMediaPlayer.Opening -= OnOpeningInternal;
            myVlcMediaPlayer.PausableChanged -= OnPausableChangedInternal;
            myVlcMediaPlayer.Paused -= OnPausedInternal;
            myVlcMediaPlayer.Playing -= OnPlayingInternal;
            myVlcMediaPlayer.PositionChanged -= OnPositionChangedInternal;
            myVlcMediaPlayer.SeekableChanged -= OnSeekableChangedInternal;
            myVlcMediaPlayer.SnapshotTaken -= OnSnapshotTakenInternal;
            myVlcMediaPlayer.Stopped -= OnStoppedInternal;
            myVlcMediaPlayer.TimeChanged -= OnTimeChangedInternal;
            myVlcMediaPlayer.TitleChanged -= OnTitleChangedInternal;
        }

        #region Backward event
        private void OnBackwardInternal(object sender, VlcMediaPlayerBackwardEventArgs e)
        {
            OnBackward();
        }

        [Category("Media Player")]
        public event EventHandler<VlcMediaPlayerBackwardEventArgs> Backward;

        public void OnBackward()
        {
            lock (myEventSyncLocker)
            {
                var del = Backward;
                if (del != null)
                    del(this, new VlcMediaPlayerBackwardEventArgs());
            }
        }
        #endregion


        #region Encountered Error event
        private void OnEncounteredErrorInternal(object sender, VlcMediaPlayerEncounteredErrorEventArgs e)
        {
            OnEncounteredError();
        }

        [Category("Media Player")]
        public event EventHandler<VlcMediaPlayerEncounteredErrorEventArgs> EncounteredError;

        public void OnEncounteredError()
        {
            lock (myEventSyncLocker)
            {
                var del = EncounteredError;
                if (del != null)
                    del(this, new VlcMediaPlayerEncounteredErrorEventArgs());
            }
        }
        #endregion

        #region EndReached event
        private void OnEndReachedInternal(object sender, VlcMediaPlayerEndReachedEventArgs e)
        {
            OnEndReached();
        }

        [Category("Media Player")]
        public event EventHandler<VlcMediaPlayerEndReachedEventArgs> EndReached;

        public void OnEndReached()
        {
            lock (myEventSyncLocker)
            {
                var del = EndReached;
                if (del != null)
                    del(this, new VlcMediaPlayerEndReachedEventArgs());
            }
        }
        #endregion

        #region Forward event
        private void OnForwardInternal(object sender, VlcMediaPlayerForwardEventArgs e)
        {
            OnForward();
        }

        [Category("Media Player")]
        public event EventHandler<VlcMediaPlayerForwardEventArgs> Forward;

        public void OnForward()
        {
            lock (myEventSyncLocker)
            {
                var del = Forward;
                if (del != null)
                    del(this, new VlcMediaPlayerForwardEventArgs());
            }
        }
        #endregion

        #region Length Changed event
        private void OnLengthChangedInternal(object sender, VlcMediaPlayerLengthChangedEventArgs e)
        {
            OnLengthChanged(e.NewLength);
        }

        [Category("Media Player")]
        public event EventHandler<VlcMediaPlayerLengthChangedEventArgs> LengthChanged;

        public void OnLengthChanged(float newLength)
        {
            var del = LengthChanged;
            if (del != null)
                del(this, new VlcMediaPlayerLengthChangedEventArgs(newLength));
        }
        #endregion

        #region Media Changed event
        private void OnMediaChangedInternal(object sender, VlcMediaPlayerMediaChangedEventArgs e)
        {
            OnMediaChanged(e.NewMedia);
        }

        [Category("Media Player")]
        public event EventHandler<VlcMediaPlayerMediaChangedEventArgs> MediaChanged;

        public void OnMediaChanged(VlcMedia newMedia)
        {
            var del = MediaChanged;
            if (del != null)
                del(this, new VlcMediaPlayerMediaChangedEventArgs(newMedia));
        }
        #endregion

        #region Opening event
        private void OnOpeningInternal(object sender, VlcMediaPlayerOpeningEventArgs e)
        {
            OnOpening();
        }

        [Category("Media Player")]
        public event EventHandler<VlcMediaPlayerOpeningEventArgs> Opening;

        public void OnOpening()
        {
            var del = Opening;
            if (del != null)
                del(this, new VlcMediaPlayerOpeningEventArgs());
        }
        #endregion

        #region Pausable Changed event
        private void OnPausableChangedInternal(object sender, VlcMediaPlayerPausableChangedEventArgs e)
        {
            OnPausableChanged(e.IsPaused);
        }

        [Category("Media Player")]
        public event EventHandler<VlcMediaPlayerPausableChangedEventArgs> PausableChanged;

        public void OnPausableChanged(bool isPaused)
        {
            var del = PausableChanged;
            if (del != null)
                del(this, new VlcMediaPlayerPausableChangedEventArgs(isPaused));
        }
        #endregion

        #region Paused event
        private void OnPausedInternal(object sender, VlcMediaPlayerPausedEventArgs e)
        {
            OnPaused();
        }

        [Category("Media Player")]
        public event EventHandler<VlcMediaPlayerPausedEventArgs> Paused;

        public void OnPaused()
        {
            var del = Paused;
            if (del != null)
                del(this, new VlcMediaPlayerPausedEventArgs());
        }
        #endregion

        #region Playing event
        private void OnPlayingInternal(object sender, VlcMediaPlayerPlayingEventArgs e)
        {
            OnPlaying();
        }

        [Category("Media Player")]
        public event EventHandler<VlcMediaPlayerPlayingEventArgs> Playing;

        public void OnPlaying()
        {
            var del = Playing;
            if (del != null)
                del(this, new VlcMediaPlayerPlayingEventArgs());
        }
        #endregion

        #region Position Changed event
        private void OnPositionChangedInternal(object sender, VlcMediaPlayerPositionChangedEventArgs e)
        {
            OnPositionChanged(e.NewPosition);
        }

        [Category("Media Player")]
        public event EventHandler<VlcMediaPlayerPositionChangedEventArgs> PositionChanged;

        public void OnPositionChanged(float newPosition)
        {
            var del = PositionChanged;
            if (del != null)
                del(this, new VlcMediaPlayerPositionChangedEventArgs(newPosition));
        }
        #endregion

        #region Seekable Changed event
        private void OnSeekableChangedInternal(object sender, VlcMediaPlayerSeekableChangedEventArgs e)
        {
            OnSeekableChanged(e.NewSeekable);
        }

        [Category("Media Player")]
        public event EventHandler<VlcMediaPlayerSeekableChangedEventArgs> SeekableChanged;

        public void OnSeekableChanged(int newSeekable)
        {
            var del = SeekableChanged;
            if (del != null)
                del(this, new VlcMediaPlayerSeekableChangedEventArgs(newSeekable));
        }
        #endregion

        #region Snapshot Taken event
        private void OnSnapshotTakenInternal(object sender, VlcMediaPlayerSnapshotTakenEventArgs e)
        {
            OnSnapshotTaken(e.FileName);
        }

        [Category("Media Player")]
        public event EventHandler<VlcMediaPlayerSnapshotTakenEventArgs> SnapshotTaken;

        public void OnSnapshotTaken(string fileName)
        {
            var del = SnapshotTaken;
            if (del != null)
                del(this, new VlcMediaPlayerSnapshotTakenEventArgs(fileName));
        }
        #endregion

        #region Time Changed event
        private void OnTimeChangedInternal(object sender, VlcMediaPlayerTimeChangedEventArgs e)
        {
            OnTimeChanged(e.NewTime);
        }

        [Category("Media Player")]
        public event EventHandler<VlcMediaPlayerTimeChangedEventArgs> TimeChanged;

        public void OnTimeChanged(long newTime)
        {
            var del = TimeChanged;
            if (del != null)
                del(this, new VlcMediaPlayerTimeChangedEventArgs(newTime));
        }
        #endregion

        #region Title Changed event
        private void OnTitleChangedInternal(object sender, VlcMediaPlayerTitleChangedEventArgs e)
        {
            OnTitleChanged(e.NewTitle);
        }

        [Category("Media Player")]
        public event EventHandler<VlcMediaPlayerTitleChangedEventArgs> TitleChanged;

        public void OnTitleChanged(string newTitle)
        {
            lock (myEventSyncLocker)
            {
                var del = TitleChanged;
                if (del != null)
                    del(this, new VlcMediaPlayerTitleChangedEventArgs(newTitle));
            }
        }
        #endregion

        #region Stopped event
        private void OnStoppedInternal(object sender, VlcMediaPlayerStoppedEventArgs e)
        {
            OnStopped();
        }

        [Category("Media Player")]
        public event EventHandler<VlcMediaPlayerStoppedEventArgs> Stopped;

        public void OnStopped()
        {
            lock (myEventSyncLocker)
            {
                var del = Stopped;
                if (del != null)
                    del(this, new VlcMediaPlayerStoppedEventArgs());
            }
        }
        #endregion
    }
}
