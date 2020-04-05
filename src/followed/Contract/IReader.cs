using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Followed.Contract
{
    public interface IReader
    {
        string ReadFromJson(string nameOfJsonFile);
    }
}
