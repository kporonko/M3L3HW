using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    internal class Starter
    {
        public static void Start()
        {
            PathConfigService pathConfigService = new PathConfigService();
            var pathConfig = pathConfigService.Deserialization();
            FileReader fileReader = new FileReader();
            Task<string> res = fileReader.Result(pathConfig.HelloFile, pathConfig.WorldFile);
            Console.WriteLine(res.Result);
        }
    }
}
