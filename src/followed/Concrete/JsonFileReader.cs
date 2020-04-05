using Solid.Followed.Contract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Solid.Followed.Concrete
{
    public class JsonFileReader : IReader
    {
        public string ReadFromJson(string nameOfJsonFile)
            => File.ReadAllText(nameOfJsonFile);
    }
}
