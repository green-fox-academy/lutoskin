using System;
namespace GreenFoxOrganization
{
	public class Mentor : Person
    {
		string level;

		public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
			this.level = level;
        }

		public Mentor()
		{
			name = "Jane Doe";
			age = 30;
			gender = "female";
			level = "intermediate";			
		}

		public override void GetGoal()
		{
			Console.WriteLine("Educate brilliant junior software developers.");
		}

		public override void Introduce()
		{
			Console.WriteLine("Hi, I'm {0} a {1} year old {2} {3} level mentor.", name, age, gender, level);
		}
	}
}