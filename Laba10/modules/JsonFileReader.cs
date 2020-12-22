using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Laba10.modules
{
    public class JsonFileReader
    {
        public readonly string _path;

        public JsonFileReader(string path)
        {
            _path = path;
        }

        public async Task<ProjectObject> ReadFile()
        {
            ProjectObject projectObj;
            using (FileStream fin = new FileStream(_path, FileMode.OpenOrCreate))
            {
                try
                {
                    projectObj = await JsonSerializer.DeserializeAsync<ProjectObject>(fin);
                }
                catch
                {
                    projectObj = new ProjectObject();
                }
            }
            return projectObj;
        }
        public async void WriteFile(ProjectObject projectObj)
        {
            using (FileStream fout = new FileStream(_path, FileMode.Create))
            {
                await JsonSerializer.SerializeAsync<ProjectObject>(fout, projectObj);
            }
        }
    }
}
