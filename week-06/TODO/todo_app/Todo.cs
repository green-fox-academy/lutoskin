using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace todo_app
{
    public class Todo
    {
		private static int id;
		private string text;
		private DateTime createdAt;
		private DateTime? completedAt;

		CreateToDoListFromFile();


		public Todo(string text)
        {
            id++;
            this.text = text;            
        }

		public Todo(string text, DateTime createdAt)
		{
			id++;
			this.text = text;
			this.createdAt = createdAt;
		}

        private bool Completed()
		{
			return completedAt != null && completedAt > createdAt;
		}
        
		private static void CreateTodoListFromFile()
        {
			var todos = File.ReadLines("todos.txt").ToList();                                
		}

		private static void PrintStartUpText()
        {
            Console.WriteLine(File.ReadAllText("manual.txt"));
        }

        private static void PrintTasks()
        {         
            todos == null ?  Console.WriteLine("No todos for today");
         
            todos.ForEach(x => Console.WriteLine($"{todos.IndexOf(x) + 1} - {todos[todos.IndexOf(x)]}"));
        }

        private static void StartProgram(string[] args)
        {
            string[] commands = new string[] { "-l", "-a", "-r", "-c" };
            Todo todo = new Todo();

            if (args.Length == 0)
            {
                PrintStartUpText();
            }

            else if (args[0] == "-l")
            {
                PrintTasks();
            }

            else if (args[0] == "-a")
            {
                Todo todoToAdd = new Todo(args.Reverse().Take(args.Length - 1).Reverse().ToString());
                todo.todos.Add(todoToAdd);
                Console.WriteLine("new todo added, todolist now contains:");

            }

            else if (args[0] == "-r")
            {
                try
                {
                    todo.todos.RemoveAt(Int32.Parse(args[1]) - 1);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Unable to remove: index is out of bound");
                }
                catch (NotFiniteNumberException)
                {
                    Console.WriteLine("Unable to remove: index is not a number");
                }
            }

            else if (args[0] == "-c")
            {
                try
                {

                }
                catch
                {

                }
            }

            else if (!commands.Contains(args[0]))
            {
                Console.WriteLine("Unsupported argument");
            }
        }
	}
}
