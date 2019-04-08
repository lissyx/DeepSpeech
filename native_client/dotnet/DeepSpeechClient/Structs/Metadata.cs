using System.Runtime.InteropServices;

namespace DeepSpeechClient.Structs
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct Metadata
    {
        [MarshalAs(UnmanagedType.LPArray, SizeConst=24)] public MetadataItem[] items;
        public int num_items;
        public double probability;// Approximated probability (confidence value) for this transcription.
    }
}
