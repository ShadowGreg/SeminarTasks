class HelpInfo {
    public static void DisplayHelp()
    {
        Console.WriteLine("Список команд:");
        Console.WriteLine("copy [sourceFile] [destinationFile] - копирование файла");
        Console.WriteLine("create [file1] [file2] ... - создание файлов");
        Console.WriteLine("search [fileExtension] [searchText] - поиск файлов по расширению и тексту");
        Console.WriteLine("write [fileName] [text] - запись текста в файл");
        Console.WriteLine("help - вывод списка команд");
    }
}