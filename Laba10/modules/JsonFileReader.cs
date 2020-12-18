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

        public async Task<ProjectSettings> ReadFile()
        {
            using (FileStream fin = new FileStream(_path, FileMode.Open))
            {
                ProjectSettings settings = await JsonSerializer.DeserializeAsync<ProjectSettings>(fin);

                return settings;
            }
        }
        public async void WriteFile(ProjectSettings settings)
        {
            using (FileStream fout = new FileStream(_path, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<ProjectSettings>(fout, settings);
            }
        }
    }
}
