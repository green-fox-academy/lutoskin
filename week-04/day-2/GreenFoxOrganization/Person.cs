using System;
namespace GreenFoxOrganization
{
    public class Person
    {   
            protected string name;
            protected int age;
            protected string gender;

            public Person(string name, int age, string gender)
            {
                this.name = name;
                this.age = age;
                this.gender = gender;
            }
        
		    public Person()
            {
                name = "Jane Doe";
                age = 30;
                gender = "female";
            }

		    public virtual void Introduce()
            {
			    Console.WriteLine("Hi, my name is {0}, I'm a {1} years old {2}.", name, age, gender);
            }

		    public virtual void GetGoal()
            {
                Console.WriteLine("My goal is to live for the moment.");
            }
    }
}
