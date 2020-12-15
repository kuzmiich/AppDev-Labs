using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10.modules
{
    public class ProjectSettings
    {
        private string _title { get; set; }
        private int _width { get; set; }
        private int _height { get; set; }

        public ProjectSettings(string Title, int Width, int Height)
        {
            _title = Title;
            _width = Width;
            _height = Height;
        }
    }
}
