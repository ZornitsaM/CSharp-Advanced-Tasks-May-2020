using System;
using System.Linq;
using System.Collections.Generic;
using System.IO.Compression;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string picFolderPath = ".";
            string targetPath = "../../../result.zip";

            ZipFile.CreateFromDirectory(picFolderPath, targetPath);
            ZipFile.ExtractToDirectory(targetPath, "../../");
        }
    }
}
