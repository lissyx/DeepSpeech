using System;
using System.Runtime.InteropServices;

namespace DeepSpeechClient.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Metadata
    {
        /// <summary>
        /// Native list of items.
        /// </summary>
        public unsafe IntPtr items;
        /// <summary>
        /// Count of items from the native side.
        /// </summary>
        public unsafe int num_items;
        /// <summary>
        /// Approximated probability (confidence value) for this transcription.
        /// </summary>
        public unsafe double probability;
    }
}
