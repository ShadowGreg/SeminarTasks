using System;
using System.IO;

namespace Task001 {
    internal class Program {
        static void Main(string[] args) {
            if (args.Length < 2) {
                Console.WriteLine("Пример запуска: utility.exe create file1.txt file2.txt");
                return;
            }

            string command = args[0];
            string[] files = new string[args.Length - 1];
            Array.Copy(args, 1, files, 0, args.Length - 1);

            switch (command) {
                case "copy":
                    CopyFiles(files);
                    break;
                case "create":
                    CreateFiles(files);
                    break;
                default:
                    Console.WriteLine("Неизвестная команда.");
                    break;
            }
        }

        static void CopyFiles(string[] files) {
            if (files.Length != 2) {
                Console.WriteLine("Для команды 'copy' необходимо указать два файла.");
                return;
            }

            string sourceFile = files[0];
            string destinationFile = files[1];

            try {
                File.Copy(sourceFile, destinationFile);
                Console.WriteLine("Файл успешно скопирован.");
            }
            catch (Exception ex) {
                Console.WriteLine("Ошибка при копировании файла: " + ex.Message);
            }
        }

        static void CreateFiles(string[] files) {
            foreach (string file in files) {
                try {
                    File.Create(file);
                    Console.WriteLine("Файл успешно создан: " + file);
                }
                catch (Exception ex) {
                    Console.WriteLine("Ошибка при создании файла: " + ex.Message);
                }
            }
        }
    }
}