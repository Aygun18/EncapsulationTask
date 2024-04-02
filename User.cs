using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask
{
	internal class User
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		
		


        public User(string username,string password)
        {
			Username = username;
			Password = password;
        }
    }
}
