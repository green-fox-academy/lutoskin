using System;
using System.Text;

namespace w2d2t5
{
    class Program
    {
        static void Main(string[] args)
        {
			string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(Reverse(reversed));
        }
        
		public static string Reverse(string reversedText)
		{
			StringBuilder reverseBuilder = new StringBuilder();
			int n = reversedText.Length;
           
            
			for (int i = n-1; i >= 0; i--)
			{
				reverseBuilder.Append(reversedText[i]); 
			}

			return reverseBuilder.ToString();

		}
    }
}
