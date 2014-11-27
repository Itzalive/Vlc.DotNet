﻿using System;
using Vlc.DotNet.Core.Interops;

namespace Vlc.DotNet.Core
{
    internal class VideoManagement : IVideoManagement
    {
        private readonly VlcManager myManager;
        private readonly IntPtr myMediaPlayer;

        public VideoManagement(VlcManager manager, IntPtr mediaPlayerInstance)
        {
            myManager = manager;
            myMediaPlayer = mediaPlayerInstance;
            Tracks = new VideoTracks(manager, mediaPlayerInstance);
            Marquee = new MarqueeManagement(manager, mediaPlayerInstance);
            Logo = new LogoManagement(manager, mediaPlayerInstance);
        }

        public string CropGeometry
        {
            get { return myManager.GetVideoCropGeometry(myMediaPlayer);  }
            set { myManager.SetVideoCropGeometry(myMediaPlayer, value); }
        }

        public int Teletext
        {
            get { return myManager.GetVideoTeletext(myMediaPlayer); }
            set { myManager.SetVideoTeletext(myMediaPlayer, value); }
        }

        public ITracksManagement Tracks { get; private set; }

        public string Deinterlace
        {
            set { myManager.SetVideoDeinterlace(myMediaPlayer, value); }
        }

        public IMarqueeManagement Marquee { get; private set; }
        public ILogoManagement Logo { get; private set; }
    }
}
