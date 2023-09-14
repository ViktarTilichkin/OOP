using System;
using System.Reflection.Metadata;
using System.Text;
using TestLibery;

namespace FileSystem
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StreamWriter sw1 = null;
            try
            {
                sw1 = new StreamWriter("C:\\Users\\Flog\\Documents\\Hscool\\OOP\\FileSystem.txt", true);
                sw1.WriteLine("Турлиту");
                sw1.WriteLine("人人 都 爱 喝可乐");
                using StreamWriter sw2 = new StreamWriter("C:\\Users\\Flog\\Documents\\Hscool\\OOP\\FileSystem2.txt", false, Encoding.UTF32);
                sw2.WriteLine("人人 都 爱 喝可乐");
                Console.WriteLine("人人 都 爱 喝可乐");
                sw2.WriteLine("блабла");
                sw2?.Close();  
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sw1?.Close();
                Console.WriteLine("Finaly bloc");
            }

            StreamReader sr1 = null;
            try
            {
                StringBuilder stringBuilde = new StringBuilder();
                sr1 = new StreamReader("C:\\Users\\Flog\\Documents\\Hscool\\OOP\\FileSystem.txt", Encoding.ASCII);
                string line = sr1.ReadLine();

                while (line != null)
                {
                    stringBuilde.AppendLine(line);
                    line = sr1.ReadLine();
                }
                sr1.Close();
                Console.WriteLine(stringBuilde.ToString());
                Console.WriteLine();
                using StreamReader sr2 = new StreamReader("C:\\Users\\Flog\\Documents\\Hscool\\OOP\\FileSystem2.txt", Encoding.UTF32);
                string result = sr2.ReadLine();
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sr1?.Close();
                Console.WriteLine("finally bloc");
            }


            string filePath = @"C:\Users\Flog\Documents\Hscool\OOP1\FileSystem2.txt";
            try
            {
                string json = "......";
                Console.WriteLine(Path.GetDirectoryName(filePath));
                if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                {
                    Console.WriteLine("need create directory");
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (File.Exists(filePath))
            {
                try
                {
                    var json = File.ReadAllText(filePath);
                    Console.WriteLine(json);
                }
                catch (Exception ex)
                {
                    File.Delete(filePath);
                    Console.WriteLine(ex);
                }
            }

            User user = new User();
            user.Name = "Test";
            user.Id = 10;
            Console.WriteLine(user);


        }
    }
}
