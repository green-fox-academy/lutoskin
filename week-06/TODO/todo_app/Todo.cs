using System;
namespace todo_app
{
    public class Todo
    {
		private static int id;
		private string text;
		private DateTime createdAt;
		private DateTime completedAt;
        
		public Todo(string text, DateTime createdAt, DateTime completedAt)
		{
			id++;
			this.text = text;
			this.createdAt = createdAt;
			this.completedAt = completedAt;
		}

        private bool Completed()
		{
			if (completedAt != null && completedAt > createdAt)
			{
				return true;
			}
			return false;
		}
	}
}
