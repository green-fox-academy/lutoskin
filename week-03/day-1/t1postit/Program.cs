using System;

namespace t1postit
{
    class Program
    {
        static void Main(string[] args)
        {
                PostIt Idea1 = new PostIt("orange", "Idea1", "blue");
                PostIt Awesome = new PostIt("pink", "Awesome", "black");
                PostIt Superb = new PostIt("yellow", "Superb!", "green");

			    Console.WriteLine(Superb.backgroundColor);

		}

        public struct PostIt
        {
            public string backgroundColor;
            string text;
            string textColor;
                     
            public PostIt(string backgroundColor, string text, string textColor)
            {
                this.backgroundColor = backgroundColor;
                this.text = text;
                this.textColor = textColor;
            }
        }
    }
}
