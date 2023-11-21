// public static void MyFile(string path)
// {
//     if (!File.Exists(path))
//     {
//         Console.WriteLine("no file");
//     }
//
//     using (StreamReader sr = new StreamReader(path))
//     {
//         while (!sr.EndOfStream)
//         {
//             string value = sr.ReadLine();
//             if (value.Contains("3333"))
//             {
//                 Console.WriteLine(value);
//             }
//         }
//     }
// }
//  using System.Text;
//
// internal class Program
// {
//     static void Main(string[] args)
//     {
//         MyFile(@"/Users/user/Desktop/1.txt" );
//     }
//     public static void MyFile(string path)
//     {
//         using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
//         {
//             using (BufferedStream bs = new BufferedStream(fs))
//             {
//                 byte[] bytes = new Byte[fs.Length];
//                 bs.Read(bytes, 0, bytes.Length);
//                 string date = Encoding.UTF8.GetString(bytes);
//                 string newDate = Environment.NewLine + "New string new Lesson";
//                 byte[] newBytes = Encoding.UTF8.GetBytes(newDate);
//                 bs.Write(newBytes, 0, newBytes.Length);
//             }
//         }
//     }
// }