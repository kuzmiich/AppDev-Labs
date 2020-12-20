namespace Laba10.modules
{
    public class ProjectSettings
    {
        public string Title { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Content { get; set; }

        public ProjectSettings(string title, int width, int height, string content)
        {
            Title = title;
            Width = width;
            Height = height;
            Content = content;
        }
        public ProjectSettings() : this(string.Empty, 350, 400, string.Empty)
        {
        }
    }
}
