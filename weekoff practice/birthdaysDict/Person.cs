namespace birthdaysDict
{
    public class Person
    {      
		public string Name
		{
			get;
			set;
		}

		public string Date
		{
			get;
			set;
		}

		public string Place
		{
			get;
			set;
		}

		public Person(string name, string date, string place)
        {
            Name = name;
            Date = date;
            Place = place;
        }

		public override string ToString()
		{
			return $"Name: {Name}, DOB: {Date}, Place: {Place}";
		}
	}
}