using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FilesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = @"D:\Sulakshana\StudyMaterial\Feb23\FilesDemo\FilesDemo\MyFiles\";

            const string path1 = @"D:\Sulakshana\StudyMaterial\Feb23\FilesDemo\FilesDemo\Folder1\";
            string filename = FileCreation(path);

            //string filename = "cv.txt";

            string p = string.Concat(path, filename);


            //File.WriteAllText(p, "this is my second demo file created today");
            //string[] contents = new string[1]{"This is a file created usign string array the method  used is WriteAllLines" };
            //File.WriteAllLines(p, contents);
            //Console.WriteLine("file created... ");
            // File.Delete(p);
            //Console.WriteLine("file deleted... ");
            //File.AppendAllLines(p,)
            //File.AppendAllText(p, "\n This is appended lines of text.....");

            CopyFile(p);
            MoveFile(p);

            Console.ReadLine();

        }

        private static void MoveFile(string p)
        {
            const string path1 = @"D:\Sulakshana\StudyMaterial\Feb23\FilesDemo\FilesDemo\NewFolder\";

            string p2 = string.Concat(path1, "c1.txt");
            File.Move(p, p2);
            Console.WriteLine("File Moved....");
        }

        private static void CopyFile(string p)
        {
            const string path1 = @"D:\Sulakshana\StudyMaterial\Feb23\FilesDemo\FilesDemo\NewFolder\";


            string p2 = string.Concat(path1, "c1.txt");
            File.Copy(p, p2);
            Console.WriteLine("File copied....");
        }

        private static string FileCreation(string path)
        {
            Console.WriteLine("Enter the filename");
            string filename = Console.ReadLine().Trim();
            File.Create(string.Concat(path, filename));
            return filename;
        }
    }
}
