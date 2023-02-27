using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectLibrary;
namespace ProjectDemo
{
    class Program:EventArgs
    {
        public static event AddPerson CreatePerson;
        public static event ListPersons ShowPersonsData;
        static void Main(string[] args)
        {

            Console.WriteLine("1 for add , 2 for list");
            int userchoice = int.Parse(Console.ReadLine());
            PersonDAL d = new PersonDAL();
            switch (userchoice)
            {
                case 1:
                    Person p = new Person();
                    Console.WriteLine("enter person id");
                    p.PersonId = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter naem");
                    p.PersonName = Console.ReadLine().Trim();

                    

                    //AddPerson a = new AddPerson(d.InsertNewPerson);
                    //a(p);
                    CreatePerson += new AddPerson(d.InsertNewPerson);
                     Console.WriteLine("Do u want to add the person data");
                    char ans = char.Parse(Console.ReadLine());
                    if (ans == 'Y' || ans == 'y')
                    {

                        CreatePerson(p);
                    }
                    else
                    {
                        Console.WriteLine("Ok got that you dont want to call the person details");
                    }
                    break;
                case 2:
                    ShowPersonsData += new ListPersons(d.GetPeople);

                    List<Person> list=ShowPersonsData();
                    foreach (var item in list)
                    {
                        Console.WriteLine(item.PersonId);
                        Console.WriteLine(item.PersonName);
                    }

                    break;
                default:
                    break;
            }

            

            Console.ReadLine();
        }
    }
}
