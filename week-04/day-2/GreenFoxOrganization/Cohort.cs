using System;
using System.Collections.Generic;

namespace GreenFoxOrganization
{
    public class Cohort
    {
		string name;
		private List<Student> students = new List<Student>();
		private List<Mentor> mentors = new List<Mentor>();

		public Cohort(string name)
		{
			this.name = name;         
		}

		public void AddStudent(Student addStudent)
		{
			students.Add(addStudent);
		}

		public void AddMentor(Mentor addMentor)
		{
			mentors.Add(addMentor);
		}

		public void Info()
		{
			Console.WriteLine("The {0} cohort has {1} students and {2} mentors.", name, students.Count, mentors.Count);
		}
    }   
}