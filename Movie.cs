using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoviesLibrary
{
	internal class Movie
	{
		private string _title;
		private string _description;
		private string _year;
		private string _imageURL;

		public string Title { get { return _title; } set { _title = value; } }
		public string Description { get { return _description; } set { _description = value; } }
		public string Year { get { return _year; } set { _year = value; } }
		public string ImageURL { get { return _imageURL; } set { _imageURL = value; } }

		public Movie(string title, string description, string year, string imageURL)
		{
			Title = title;
			Description = description;
			Year = year;
			ImageURL = imageURL;
		}
	}
}
