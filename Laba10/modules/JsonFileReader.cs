using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
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

        static async Task<ProjectSettings> ReadFile()
        {
            using (FileStream fin = new FileStream(JsonFileReader._path, FileMode.Open))
            {
                ProjectSettings settings = await JsonSerializer.DeserializeAsync<ProjectSettings>(fin);

                return settings;
            }
        }
        static async Task WriteFile(ProjectSettings settings)
        {
            using (FileStream fout = new FileStream(JsonFileReader._path, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<ProjectSettings>(fout, settings);
            }
        }
    }
}
