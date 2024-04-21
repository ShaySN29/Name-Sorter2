using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace Name_Sorter
{
    internal class FileReaderAndWriter
    {
        public static string[] ReadFromFile(string filePath)
        {
            //string file = @"C:\src\Name-Sorter\Name-Sorter\Name-Sorter\Text_Files\unsorted-names-list.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                return lines;

                //foreach (string line in lines)
                //{
                //    Console.WriteLine(line);
                //}
                //Console.WriteLine();
            }

            throw new FileNotFoundException("File does not exist.");
        }


    }
}

