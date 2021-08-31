using Newtonsoft.Json;
using System.IO;

namespace MathOperations.Tests.Common
{
    public static class JsonConverter
    {
        public static T GetValueFromPath<T>(string path)
        {
            var json = ReadFile(path);
            return JsonConvert.DeserializeObject<T>(json);
        }

        private static string ReadFile(string path)
            => File.ReadAllText(
                Directory.GetCurrentDirectory() +
                path
            );
    }
}
