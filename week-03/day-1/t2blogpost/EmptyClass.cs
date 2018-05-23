using System;
namespace t2blogpost
{
    public class BlogPost
    {
		public string authorName;
	    public string title;
	    public string text;
		public DateTime publicationDate;

		public BlogPost(string authorName, string title, string text, DateTime publicationDate)
		{
			this.authorName = authorName;
			this.title = title;
			this.text = text;
			this.publicationDate = publicationDate;
		}
	}
}
