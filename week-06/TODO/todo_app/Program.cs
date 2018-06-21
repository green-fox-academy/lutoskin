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

		}

        public static void StartUpText()
        {
			Console.WriteLine(File.ReadAllText("manual.txt"));
        }

        public static void PrintTasks()
		{
			List<string> todos = new List<string>(File.ReadLines("todos.txt"));
			for (int i = 0; i < todos.Count; i++)
			{
				Console.WriteLine($"{i + 1} - {todos[i]}");
			} 
		}
    }
}
