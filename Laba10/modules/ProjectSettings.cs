using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10.modules
{
    public class ProjectSettings
    {
        public string Title { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public ProjectSettings(string title, int width, int height)
        {
            Title = title;
            Width = width;
            Height = height;
        }
    }
}
