using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using HRLibrary;
using System.Runtime.Serialization.Formatters.Soap;

namespace SerializationDemo
{
    class Program
    {
        void BinaryDeserializeData()
        {
            //using System.Runtime.Serialization.Formatters.Binary;
            FileStream fs = new FileStream("EmpData.dat", FileMode.Open, FileAccess.Read);

            BinaryFormatter bf = new BinaryFormatter();
            Employee emp1=(Employee)bf.Deserialize(fs);
            Console.WriteLine(emp1.Empid);
            Console.WriteLine(emp1.Empname);
            Console.WriteLine(emp1.Empsal);
        
        }


        void XMLSerializeData()
        {
            Employee emp = new Employee();
            emp.Empid = 101;
            emp.Empname = "Aditi";
            
            FileStream fs = new FileStream("EmpXMLData.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            xs.Serialize(fs, emp);
            fs.Close();
            fs.Dispose();

            //using System.Xml.Serialization;


        }

        void XMLDeSerializeData()
        {
            FileStream fs = new FileStream("EmpXMLData.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            Employee emp=(Employee)xs.Deserialize(fs);
            Console.WriteLine(emp.Empid);
            Console.WriteLine(emp.Empname);
            Console.WriteLine(emp.Empsal);
            fs.Close();
            fs.Dispose();


            //using System.Xml.Serialization;
        }



        void BinarySerializeData()
        {
            //using System.Runtime.Serialization.Formatters.Binary;
            Employee emp = new Employee();
            emp.Empid = 101;
            emp.Empname = "Aditi";
            emp.Empsal = 40000.00f;
            FileStream fs = new FileStream("EmpData.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp);
            fs.Close();
            fs.Dispose();

            Console.WriteLine("file created in binary format....");

          
        }


        static void Main(string[] args)
        {
            Console.WriteLine("enter 1 for Binaryserialize, 2 for Binarydeserialize, 3 for XML Serialze,  4 for XML Deserialize, 5 for Soap Serialize , 6 for Soap Deserialize  ");
            int choice = int.Parse(Console.ReadLine());
            Program p = new Program();
            switch (choice)
            {
                
                case 1:
                    p.BinarySerializeData();
                    break;

                case 2:
                    p.BinaryDeserializeData();
                    break;
                case 3:
                    p.XMLSerializeData();

                    break;
                case 4:
                    p.XMLDeSerializeData();
                    break;

                case 5:
                    HRLibrary.Employee emp = new HRLibrary.Employee();
                    emp.Empid = 1;
                    emp.EName = "Pradnya";
                    emp.Deptno = 20;
                    FileStream fs = new FileStream("soapdata1.soap", FileMode.Create, FileAccess.Write);
                    SoapFormatter s = new SoapFormatter();
                    s.Serialize(fs, emp);
                    fs.Close();
                    fs.Dispose();
                    break;
                case 6:
                    fs = new FileStream("soapdata1.soap", FileMode.Open, FileAccess.Read);
                    SoapFormatter s1 = new SoapFormatter();
                    HRLibrary.Employee emp1 = (HRLibrary.Employee) s1.Deserialize(fs);
                    Console.WriteLine(emp1.Empid);
                    Console.WriteLine(emp1.EName);
                    Console.WriteLine(emp1.Deptno);
                    fs.Close();
                    fs.Dispose();

                    break;
                default:
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
