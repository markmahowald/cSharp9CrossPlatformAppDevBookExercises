using System;
using System.IO;
using static System.Console;

namespace patternMatchin
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "/Users/markmahowald/personalProjects/dotNetCoreBook/newEdition/code/chapter03/patternMatchin";
            WriteLine("Press R for read only or W for wright");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            Stream s = null;
            if(key.Key == ConsoleKey.R)
            {
                s = File.Open(
                    Path.Combine(filePath, "file.txt"),
                    FileMode.OpenOrCreate,
                    FileAccess.Read
                );
            }
            else
            {
                s = File.Open(
                    Path.Combine(filePath, "file.txt"),
                    FileMode.OpenOrCreate,
                    FileAccess.Write
                );
            }
            string message = string.Empty;
            switch (s)
            {
                case FileStream writableFile when s.CanWrite:
                message = "The stream is a file that i can write to.";
                    break;
                
                case FileStream readOInlyFile:
                message = "The stream is a Read Only file.";
                break;

                case MemoryStream ms:
                message = "The stream is just a memory address.";
                break;

                default:
                message = "the stream is something else...?";
                    break;

                case null:
                message = "the stream is null. ";
                break;
            }
            WriteLine(message);

            message = s switch
            {
                FileStream writeableFile when s.CanWrite
                => "the stream is a file I can write to",
                FileStream readOnlyFile 
                => "The stream is a read-only file",
                MemoryStream ms 
                => "the stream is a memory address",
                null 
                => "the stream is null",
                _ 
                => "How did you even get here?"

            };
            WriteLine(message);
        }
    }
}
