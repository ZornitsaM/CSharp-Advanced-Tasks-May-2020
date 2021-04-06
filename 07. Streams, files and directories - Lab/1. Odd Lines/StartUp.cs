
namespace Streams__files_and_directories_LAB

{
    using System;
    using System.IO;
    

    class Program
    {
        static void Main(string[] args)

        {
          var stream = new FileStream("Text1.txt",FileMode.OpenOrCreate);

            using (stream)
            {
                var parts = 4;

                var lenght = stream.Length / parts;

                var buffer = new byte[lenght];

                for (int i = 0; i < parts; i++)
                {
                    var bytesRead = stream.Read(buffer, 0, buffer.Length);
                    var currentPartStream = new FileStream($"Part{i+1}.txt",FileMode.OpenOrCreate);

                    using(currentPartStream)
                    {
                        currentPartStream.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
