using System;
namespace Cloneable
{
    public class Student : ICloneable
    {
		string name;
		int age;
		string gender;
		string previousOrganization;

		public Student(string name, int age, string gender, string previousOrganization) 
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
			this.previousOrganization = previousOrganization;
        }
        
        public object Clone()
        {
			Student clonedStudent = new Student(name, age, gender, previousOrganization);
            return clonedStudent;
        }

		public override string ToString()
		{
			return string.Format("Hi, I'm {0} a {1} years old {2} from {3}", name, age, gender, previousOrganization);
		}
	}
}