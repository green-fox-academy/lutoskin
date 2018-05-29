using System;
namespace GreenFoxOrganization
{
	public class Sponsor : Person
    {
		string company;
		int hiredStudents;

		public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.company = company;
			hiredStudents = 0;
        }

		public Sponsor()
		{
			name = "Jane Doe";
			age = 30;
			gender = "female";
			company = "Google";
			hiredStudents = 0;
		}

		public override void GetGoal()
		{
			Console.WriteLine("Hire brilliant junior software developer.");
		}

		public override void Introduce()
		{
			Console.WriteLine("Hi, I'm {0} a {1} year old {2} who represents {3} and hired {4} students so far.", name, age, gender, company, hiredStudents);
		}

		public void Hire()
		{
			hiredStudents++;
		}
	}
}