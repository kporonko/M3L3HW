using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Async
{
    internal class PathConfigService
    {
        public void Serialization()
        {
            var json = JsonConvert.SerializeObject(new PathConfig());
            File.WriteAllText("config.json", json);
        }

        public PathConfig Deserialization()
        {
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Async\\config.json");
            var configFile = File.ReadAllText(startupPath, Encoding.UTF8);
            var config = JsonConvert.DeserializeObject<PathConfig>(configFile);
            return config;
        }
    }
}
