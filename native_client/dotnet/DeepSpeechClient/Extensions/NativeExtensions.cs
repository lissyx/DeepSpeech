using DeepSpeechClient;
using DeepSpeechClient.Interfaces;
using DeepSpeechClient.Structs;

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace DeepSpeechClient.Extensions
{
    internal static class NativeExtensions
    {
        internal static string PtrToString(this IntPtr intPtr)
        {
            int len = 0;
            while (Marshal.ReadByte(intPtr, len) != 0) ++len;
            byte[] buffer = new byte[len];
            Marshal.Copy(intPtr, buffer, 0, buffer.Length);
            NativeImp.DS_FreeString(intPtr);
            string result = Encoding.UTF8.GetString(buffer);
            return result;
        }
    }
}
