using System;
using System.Runtime.InteropServices;

namespace DeepSpeechClient.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct MetadataItem
    {
        /// <summary>
        /// Native character.
        /// </summary>
        public unsafe IntPtr character;
        /// <summary>
        /// Position of the character in units of 20ms.
        /// </summary>
        public unsafe int timestep;
        /// <summary>
        /// Position of the character in seconds.
        /// </summary>
        public unsafe float start_time;
    }
}
