namespace Laba10.modules
{
    public class ProjectObject
    {
        public string Title { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Content { get; set; }

        public ProjectObject(string title, int width, int height, string content)
        {
            Title = title;
            Width = width;
            Height = height;
            Content = content;
        }
        public ProjectObject() : this("Title", 550, 500, string.Empty)
        {
        }
    }
}
