using System;
using System.Text;

namespace w2d2t4
{
    class Program
    {
        static void Main(string[] args)
        {
			string todoText = " - Buy milk\n";
			// Add "My todo:" to the beginning of the todoText
			// Add " - Download games" to the end of the todoText
			// Add " - Diablo" to the end of the todoText but with indentation

			// Expected output:

			// My todo:
			//  - Buy milk
			//  - Download games
			//      - Diablo
            
			todoText = todoText.Insert(0, "My todo:\n");

			StringBuilder listBuilder = new StringBuilder(todoText);
			listBuilder = listBuilder.Append(" - Download games\n");
			listBuilder = listBuilder.Append("\t- Diablo");
         
			Console.WriteLine(listBuilder);
        }

    }
}
