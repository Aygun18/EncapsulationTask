using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask
{
	internal class Student:User
	{
		public int Grade { get; set; }

        public Student(string name,string surname,string username,string password,int grade):base(username,password)
        {
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            Grade = grade;
        }
    }
}
