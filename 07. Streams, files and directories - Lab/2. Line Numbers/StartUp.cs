﻿using System;
using System.Text;

using System.IO;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var stream = new StreamWriter("Text1.txt");
            var text = "Me";
            var buffer = Encoding.UTF8.GetBytes(text);
        }
    }
}
