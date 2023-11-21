//Напишите утилиту читающую тестовый файл и выводящую на экран строки содержащие искомое слово.


namespace Task002
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Пример запуска: utility.exe filename.txt searchword");
                return;
            }

            string filename = args[0];
            string searchWord = args[1];

            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(searchWord))
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
            }
        }
    }
}
