class FileController {
    public static void CopyFiles(string[] files)
    {
        if (files.Length != 2)
        {
            Console.WriteLine("Для команды 'copy' необходимо указать два файла.");
            return;
        }
        string sourceFile = files[0];
        string destinationFile = files[1];
        try
        {
            File.Copy(sourceFile, destinationFile);
            Console.WriteLine("Файл успешно скопирован.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при копировании файла: " + ex.Message);
        }
    }

    public static void CreateFiles(string[] files)
    {
        foreach (string file in files)
        {
            try
            {
                File.WriteAllText(file, "");
                Console.WriteLine("Файл успешно создан: " + file);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при создании файла: " + ex.Message);
            }
        }
    }

    public static void SearchFiles(string directory, string fileExtension, string searchText)
    {
        try
        {
            string[] files = Directory.GetFiles(directory, $"*.{fileExtension}", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(searchText))
                        {
                            Console.WriteLine($"Найдено совпадение в файле: {file}");
                            break;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при поиске файлов: " + ex.Message);
        }
    }

    public static void WriteToFile(string fileName, string text)
    {
        try
        {
            File.WriteAllText(fileName, text);
            Console.WriteLine("Текст успешно записан в файл.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при записи в файл: " + ex.Message);
        }
    }
}