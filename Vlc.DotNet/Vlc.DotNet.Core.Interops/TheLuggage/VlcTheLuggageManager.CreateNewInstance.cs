﻿using System;
using Vlc.DotNet.Core.Interops.Signatures.TheLuggage;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcTheLuggageManager
    {
        public IntPtr CreateNewInstance(string[] args)
        {
            if (args == null)
                args = new string[0];
            return GetInteropDelegate<CreateNewInstance>().Invoke(args.Length, args);
        }
    }
}
