using System.Text;

namespace SoruBankam.Presentation.MauiBlazorApp.Tools
{
    public static class Base64Tool
    {
        public static Byte[] ToByteArray(String base64Photo)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(base64Photo);
            return bytes;
        }

        public static String ToBase64(Byte[] bytes)
        {
            var base64Photo = Encoding.Default.GetString(bytes);
            return base64Photo;
        }
    }
}
