using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesDemo
{
    class DirectoryDemoProgram
    {
        static void Main(string[] args)
        {

            string[] drives=Directory.GetLogicalDrives();


            foreach (var info1    in drives)
            {
                Console.WriteLine(info1);

                Console.WriteLine();
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("C drives info");
            DriveInfo info = new DriveInfo("C");
            Console.WriteLine("Name=" + info.Name);
            Console.WriteLine("Volumne Label= " + info.VolumeLabel);
            Console.WriteLine("Drive Format  " + info.DriveFormat);
            Console.WriteLine("Drive Type= " + info.DriveType);
            Console.WriteLine("Root Dir" + info.RootDirectory);
            Console.WriteLine();

            Console.WriteLine("D drives info");
            info = new DriveInfo("D");
            Console.WriteLine("Name=" + info.Name);
            Console.WriteLine("Volumne Label= " + info.VolumeLabel);
            Console.WriteLine("Drive Format  " + info.DriveFormat);
            Console.WriteLine("Drive Type= " + info.DriveType);
            Console.WriteLine("Root Dir" + info.RootDirectory);
            Console.WriteLine();

            Console.WriteLine("E drives info");
             info = new DriveInfo("E");
            Console.WriteLine("Name=" + info.Name);
            Console.WriteLine("Volumne Label= " + info.VolumeLabel);
            Console.WriteLine("Drive Format  " + info.DriveFormat);
            Console.WriteLine("Drive Type= " + info.DriveType);
            Console.WriteLine("Root Dir" + info.RootDirectory);
            //const string path= @"D:\Sulakshana\StudyMaterial\Feb23\FilesDemo\FilesDemo\";
            //string dirname = "Students";
            //string s=string.Concat(path, dirname);
            //string destpath = string.Concat(path, dirname+ "\\");
            //Console.WriteLine("Destination Path"+ destpath);
            //Console.WriteLine(  );
            //string[] filenames=Directory.GetFiles(@"D:\Sulakshana\StudyMaterial\Feb23\FilesDemo\FilesDemo\MyFiles\");

            //foreach (string item in filenames)
            //{

            //    Console.WriteLine("FileName=" + item);

            //}



            //foreach (var item in filenames)
            //{

            //   File.Copy(item, string.Concat(destpath, "file1.txt"));



            //}


            //Directory.CreateDirectory(s);
            //Console.WriteLine("Created Dir");
            //string subdir=string.Concat(s,  "\\CourseInfo");
            //Directory.CreateDirectory(subdir);

            //Console.WriteLine("Sub  directory created....");



            Console.ReadLine();

        }
    }
}
