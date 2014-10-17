﻿using System;
using System.Runtime.InteropServices;
using System.Text;
using Vlc.DotNet.Core.Interops.Signatures.TheLuggage;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcTheLuggageManager
    {
        public void SetMediaMeta(IntPtr mediaInstance, MediaMetadatas metadata, string value)
        {
            if (mediaInstance == IntPtr.Zero)
                throw new ArgumentException("Media instance is not initialized.");
            var handle = GCHandle.Alloc(Encoding.UTF8.GetBytes(value), GCHandleType.Pinned);
            GetInteropDelegate<SetMediaMetadata>().Invoke(mediaInstance, metadata, handle.AddrOfPinnedObject());
            handle.Free();
        }
    }
}
