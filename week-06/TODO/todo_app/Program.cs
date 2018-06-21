using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace todo_app
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			StartUpText();
			PrintTasks();
		}
        
        private static void StartUpText()
        {
			Console.WriteLine(File.ReadAllText("manual.txt"));
        }

		private static void PrintTasks()
		{
			var todos = File.ReadLines("todos.txt").ToList();

			(todos == null) ? Console.WriteLine("No todos for today") :
			todos.ForEach(x => Console.WriteLine($"{todos.IndexOf(x) + 1} - {todos[todos.IndexOf(x)]}"));         
		}

		private static void StartProgram(string[] args)
		{
			string[] commands = new string[] { "-l", "-a", "-r", "-c" };

			from input in args
			where args[0] == null ? StartUpText() :
				  args[0] == "-l" ? PrintTasks() :
				  args[0] == "-a" ? :
				  args[0] == "-r" ? :
			      args[0] == "-c" ? ;           //WTF IS WRONG WITH THIS
		}
    }
}
