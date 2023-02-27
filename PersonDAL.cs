using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ProjectLibrary
{
    public delegate void AddPerson(Person p);
    public delegate List<Person> ListPersons();
    public class PersonDAL
    {

        public List<Person> GetPeople()
        {
            SqlConnection cn = new SqlConnection("server=SPD;Initial Catalog=Northwind;Integrated Security=true");
            SqlCommand cmdselect = new SqlCommand("select * from person",cn);
            cmdselect.CommandType = CommandType.Text;
            cn.Open();
            SqlDataReader dr=cmdselect.ExecuteReader();
            List<Person> persons = new List<Person>();
            while (dr.Read())
            {

                Person p = new Person();
                p.PersonId=(int)dr["personid"];//Personid
                p.PersonName=dr["personname"].ToString();//PersonName

                persons.Add(p);

            }
            cn.Close();
            cn.Dispose();

            return persons;


        }


        public void InsertNewPerson(Person p)
        {
            //ExecuteNonQuery----Insert/Update/Delete
            //This is the method for adding new person to the table person in the database
            SqlConnection cn = new SqlConnection("server=SPD;Initial Catalog=Northwind;Integrated Security=true");
            SqlCommand cmd_insertPerson = new SqlCommand("insert into person values(@pid,@pname)",cn);
            cmd_insertPerson.CommandType = CommandType.Text;
            cmd_insertPerson.Parameters.AddWithValue("@pid", p.PersonId);
            cmd_insertPerson.Parameters.AddWithValue("@pname", p.PersonName);
            cn.Open();
            cmd_insertPerson.ExecuteNonQuery();
                 cn.Close();
            cn.Dispose();
                Console.WriteLine("New Person added successfully");
            
        
        }
       

    }
}
