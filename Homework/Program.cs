using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Пример запуска: utility.exe command1 [args1] command2 [args2] ...");
            return;
        }
        for (int i = 0; i < args.Length; i += 2)
        {
            string command = args[i];
            string[] commandArgs = new string[args.Length - i - 1];
            Array.Copy(args, i + 1, commandArgs, 0, args.Length - i - 1);
            switch (command)
            {
                case "copy":
                    FileController.CopyFiles(commandArgs);
                    break;
                case "create":
                    FileController.CreateFiles(commandArgs);
                    break;
                case "search":
                    if (SearchCase(commandArgs)) return;
                    break;
                case "write":
                    if (WriteCase(commandArgs)) return;
                    break;
                case "help":
                    HelpInfo.DisplayHelp();
                    break;
                default:
                    Console.WriteLine("Неизвестная команда: " + command);
                    break;
            }
        }
    }

    private static bool WriteCase(string[] commandArgs) {
        if (commandArgs.Length != 2) {
            Console.WriteLine("Для команды 'write' необходимо указать два аргумента: имя файла и текст для записи.");
            return true;
        }

        string fileName = commandArgs[0];
        string text = commandArgs[1];
        FileController.WriteToFile(fileName, text);
        return false;
    }

    private static bool SearchCase(string[] commandArgs) {
        if (commandArgs.Length != 2) {
            Console.WriteLine("Для команды 'search' необходимо указать два аргумента: расширение файла и искомый текст.");
            return true;
        }

        string fileExtension = commandArgs[0];
        string searchText = commandArgs[1];
        FileController.SearchFiles(Directory.GetCurrentDirectory(), fileExtension, searchText);
        return false;
    }

    static void CopyFiles(string[] files) {
        FileController.CopyFiles(files);
    }

    static void CreateFiles(string[] files) {
        FileController.CreateFiles(files);
    }

    static void SearchFiles(string directory, string fileExtension, string searchText) {
        FileController.SearchFiles(directory, fileExtension, searchText);
    }

    static void WriteToFile(string fileName, string text) {
        FileController.WriteToFile(fileName, text);
    }
}