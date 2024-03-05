using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLecture13_14Files
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string path = "C:/Users/pc-10/source/repos/CodeLecture13-14Files/text.txt";
            using (FileStream stream = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                Console.WriteLine("Введите данные: ");
                string str = Console.ReadLine();
                byte[] bytes = Encoding.UTF8.GetBytes(Foo() + str);
                stream.Write(bytes,0, bytes.Length);
            }

            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                string message = Encoding.UTF8.GetString(bytes);
                Console.WriteLine(message);
            }

            
        }

        public static string Foo()
        {
            return "\n";
        }
    }
}
