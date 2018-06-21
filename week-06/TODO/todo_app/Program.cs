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
			StartProgram(args);
		}
        
        private static void StartUpText()
        {
			Console.WriteLine(File.ReadAllText("manual.txt"));
        }

		private static void PrintTasks()
		{
			var todos = File.ReadLines("todos.txt").ToList();

			if(todos == null)
			{
				Console.WriteLine("No todos for today");	
			} 

			todos.ForEach(x => Console.WriteLine($"{todos.IndexOf(x) + 1} - {todos[todos.IndexOf(x)]}"));         
		}

		private static void StartProgram(string[] args)
		{
			string[] commands = new string[] { "-l", "-a", "-r", "-c" };
            
			if (args.Length == 0)
			{
				StartUpText();
			}

			else if (args[0] == "-l")
			{
				PrintTasks();
			}

			else if (! commands.Contains(args[0]))
			{
                Console.WriteLine("Unsupported argument");
			}         
		}
    }
}
