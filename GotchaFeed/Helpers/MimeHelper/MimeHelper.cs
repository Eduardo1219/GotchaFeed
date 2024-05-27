namespace GotchaFeed.Helpers.MimeHelper
{
    public static class MimeHelper
    {
        public static readonly Dictionary<string, string> ContentTypes = new Dictionary<string, string>()
        {
            { ".jpg", "image/jpeg" },
            { ".png", "image/png" },
            { ".gif", "image/gif" },
        };
    }
}
