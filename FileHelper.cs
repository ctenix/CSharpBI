using System;
using System.IO;
namespace Ch06
{
    public class FileHelper
    {
        public static void readText(){
            StreamReader sr = File.OpenText("Data.txt");
            string contents = sr.ReadToEnd();//读取所有内容
            sr.Close();
            string[] lines = contents.Split(new Char[] { '\n' });
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(i + ":\t" + lines[i]);
            }
        }
    }
}