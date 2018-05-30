using System;
namespace GreenFoxOrganization
{
	public class Student : Person, ICloneable
    {
		string previousOrganization;
		int skippedDays;
        
		public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
			this.name = name;
			this.age = age;
			this.gender = gender;
			this.previousOrganization = previousOrganization;
			skippedDays = 0;
        }

		public Student()
		{
			name = "Jane Doe";
			age = 30;
			gender = "female";
			previousOrganization = "The School of Life";
			skippedDays = 0;
		}
        
		public override void GetGoal()
		{
			Console.WriteLine("Be a junior software developer.");
		}

		public override void Introduce()
		{
			Console.WriteLine("Hi, I'm {0} a {1} year old {2} from {3} who skipped {4} days from the course already.", name, age, gender, previousOrganization, skippedDays);
		}

		public int SkipDays(int numberOfDays)
		{
			return skippedDays += numberOfDays;
		}

		public object Clone()
		{
			Student clonedStudent = new Student(name, age, gender, previousOrganization);
			return clonedStudent;
		}
	}
}