using System.Runtime.InteropServices;

namespace DeepSpeechClient.Structs
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct MetadataItem
    {
        public string character;
        public int timestep; // Position of the character in units of 20ms
        public float start_time; // Position of the character in seconds
    }
}
