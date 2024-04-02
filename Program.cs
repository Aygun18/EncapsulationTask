using System;

namespace EncapsulationTask
{
	internal class Program
	{
		static void Main(string[] args)
		{


			#region Task2

			Student student = new Student("Aygun", "Shahmuradova", "Aygun", "pass123", 90);
			Student student1 = new Student("Nigar", "Aliyeva", "Nigar", "pass1234", 80);

			Student[] students = new Student[] { student, student1 };
			User[] users = new User[] { student, student1 };


			Console.WriteLine("Username daxil edin:");
			string username = Console.ReadLine();
			Console.WriteLine("Password daxil edin:");
			string password = Console.ReadLine();

			User check = null;
			foreach (User user in users)
			{
				if (user.Username == username && user.Password == password)
				{
					check = user;
					break;
				}
			}
			foreach (Student st in students)
			{
				if (st.Username.Equals(check.Username))
				{
					Console.WriteLine($"Grade: {st.Grade}");
					break;
				}
				else
				{
					Console.WriteLine("Duzgun daxil edin");
				}
			}

			#endregion
			#region Task1
			int[] arr1 = { 1, 2, 3, 4, 5, 6 };
			int[] arr2 = { 1, 2, 3 };
			Console.WriteLine(IsArrayContains(arr1, arr2));

			#endregion
		}

		static bool IsArrayContains(int[] arr1, int[] arr2)
		{


			int index1 = 0;
			for (int i = 0; i < arr1.Length; i++)
			{
				if (arr1[i] == arr2[index1])
				{
					index1++;
				}

				if (index1 == arr2.Length)
				{
					return true;
				}
			}

			return false;
		}
	}
}