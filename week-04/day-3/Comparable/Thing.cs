using System;
namespace Comparable
{
	public class Thing : IComparable
    {
		private string Name;
        private bool Completed;

        public Thing(string name)
        {
            this.Name = name;
        }

		public int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}

		public void Complete()
        {
            this.Completed = true;
        }
    }
}
