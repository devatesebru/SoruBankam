using System.Text;

namespace SoruBankam.MauiBlazorApp.Tools
{
    public static class Base64Tool
    {
        public static byte[] ToByteArray(string base64Photo)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(base64Photo);
            return bytes;
        }

        public static string ToBase64(byte[] bytes)
        {
            var base64Photo = Encoding.Default.GetString(bytes);
            return base64Photo;
        }
    }
}
