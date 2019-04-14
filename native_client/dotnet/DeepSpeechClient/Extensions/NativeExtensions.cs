using System;
using System.Runtime.InteropServices;
using System.Text;

namespace DeepSpeechClient.Extensions
{
    internal static class NativeExtensions
    {
        /// <summary>
        /// Converts native pointer to UTF-8 encoded string.
        /// </summary>
        /// <param name="intPtr">Native pointer.</param>
        /// <returns>Result string.</returns>
        internal static string PtrToString(this IntPtr intPtr)
        {
            int len = 0;
            while (Marshal.ReadByte(intPtr, len) != 0) ++len;
            byte[] buffer = new byte[len];
            Marshal.Copy(intPtr, buffer, 0, buffer.Length);
            //TODO: Release native
            //NativeImp.DS_FreeString(intPtr);
            string result = Encoding.UTF8.GetString(buffer);
            return result;
        }
    }
}
