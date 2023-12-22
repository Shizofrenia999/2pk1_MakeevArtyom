using System;
using System.IO;

class Program
{
    static void Main()
    {
        String f1Path = "path / to / f1.txt";
        String f2Path = "path / to / f2.txt";
        String tempPath = "path / to / temp.txt";

        // Переписать содержимое файла f1 во временный файл
        File.Copy(f1Path, tempPath, true);

        // Переписать содержимое файла f2 в файл f1
        File.Copy(f2Path, f1Path, true);

        // Переписать содержимое временного файла в файл f2
        File.Copy(tempPath, f2Path, true);

        // Удалить временный файл
        File.Delete(tempPath);

        Console.WriteLine("Содержимое файлов успешно переписано!");
    }
}