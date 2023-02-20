using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FilesDemo
{
    class MoreOnFiles
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 1 to create, 2 open a file");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter filename to create");
                    string filename = Console.ReadLine();
                    FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
                    Console.WriteLine("Enter the file contents");
                    string c = Console.ReadLine();
                    StreamWriter sw = new StreamWriter(fs);


                    try
                    {
                        sw.Write(c);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }

                    finally
                    {
                        sw.Close();
                        fs.Close();
                        sw.Dispose();
                        fs.Dispose();
                    }

                    break;


                case 2:

                    FileStream fs1 = null;
                    StreamReader sr = null;
                    try
                    {

                        Console.WriteLine("Specify filename to open");
                        string fname = Console.ReadLine();

                        fs1 = new FileStream(fname, FileMode.Open, FileAccess.Read);
                        sr = new StreamReader(fs1);
                        bool status = File.Exists(fname);
                        if (status)
                        {
                            string s = sr.ReadToEnd();
                            Console.WriteLine(s);
                        }


                    }
                    catch (FileNotFoundException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        sr.Close();
                        fs1.Close();
                        sr.Dispose();
                        fs1.Dispose();
                    }


                    break;
                default:
                    break;
            }



            Console.ReadLine();
        }
    }
}
