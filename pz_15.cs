using System;
using System.IO;

namespace FilesInFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите полный путь к папке:");
            string folderPath = Console.ReadLine();

            if(Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath);

                Console.WriteLine("Файлы с именем на латинице:");
                foreach(string file in files)
                {
                    if(IsLatin(file))
                    {
                        Console.WriteLine(file);
                    }
                }
            }
            else
            {
                Console.WriteLine("Папка не существует");
            }
        }

        static bool IsLatin(string input)
        {
            foreach(char c in input)
            {
                if((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
