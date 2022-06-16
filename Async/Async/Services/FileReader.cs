using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    internal class FileReader
    {
        public async Task<string> Result(string helloFile, string worldFile)
        {
            FileReader fileReader = new FileReader();

            string hello = await ReadHelloAsync(helloFile);
            string world = await ReadWorldAsync(worldFile);
            return hello + " " + world;
        }

        public async Task<string> ReadHelloAsync(string pathHello)
        {
            string hello = string.Empty;
            await Task.Run(() =>
            {
                hello = ReadHello(pathHello);
            });
            return hello;
        }

        public async Task<string> ReadWorldAsync(string pathWorld)
        {
            string world = string.Empty;
            await Task.Run(() =>
            {
                world = ReadHello(pathWorld);
            });
            return world;
        }

        private string ReadHello(string pathHello)
        {
            using (StreamReader streamReader = new StreamReader(pathHello))
            {
                return streamReader.ReadLine();
            }
        }

        private string ReadWorld(string pathWorld)
        {
            using (StreamReader streamReader = new StreamReader(pathWorld))
            {
                return streamReader.ReadLine();
            }
        }
    }
}
