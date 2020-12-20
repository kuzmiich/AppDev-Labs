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
            ProjectSettings settings;
            using (FileStream fin = new FileStream(_path, FileMode.OpenOrCreate))
            {
                try
                {
                    settings = await JsonSerializer.DeserializeAsync<ProjectSettings>(fin);
                }
                catch
                {
                    settings = new ProjectSettings();
                }
            }
            return settings;
        }
        public async Task<string> ReadFile(string path)
        {
            string text;
            using (FileStream fin = new FileStream(path, FileMode.OpenOrCreate))
            {
                try
                {
                    text = await JsonSerializer.DeserializeAsync<string>(fin);
                }
                catch
                {
                    text = string.Empty;
                }
            }
            return text;
        }
        public async void WriteFile(ProjectSettings settings)
        {
            using (FileStream fout = new FileStream(_path, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<ProjectSettings>(fout, settings);
            }
        }
        public async void WriteFile(string path, string text)
        {
            using (FileStream fout = new FileStream(_path, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync(fout, text);
            }
        }
    }
}
