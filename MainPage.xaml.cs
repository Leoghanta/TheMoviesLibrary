using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TheMoviesLibrary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

		ObservableCollection<Movie> movielist = new ObservableCollection<Movie>();
		Movie currentMovie = null;


		public MainPage()
        {
            this.InitializeComponent();

			movielist.Add(new Movie("Fight Club",
						"An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
						"1999",
						"/MoviePosters/fightclub.jpg"));

			movielist.Add(new Movie("The Goonies",
									"A group of young misfits called The Goonies discover an ancient map and set out on an adventure to find a legendary pirate's long-lost treasure.",
									"1985",
									"/MoviePosters/goonies.jpg"));

			movielist.Add(new Movie("Jurassic Park",
									"A pragmatic paleontologist touring an almost complete theme park on an island in Central America is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose.",
									"1993",
									"/MoviePosters/jurassicpark.jpg"));

			movielist.Add(new Movie("The Terminator",
									"A human soldier is sent from 2029 to 1984 to stop an almost indestructible cyborg killing machine, sent from the same year, which has been programmed to execute a young woman whose unborn son is the key to humanity's future salvation.",
									"1984",
									"/MoviePosters/terminator.jpg"));

			movielist.Add(new Movie("The Dark Knight",
									"When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
									"2008",
									"/MoviePosters/darkknight.jpg"));

			movielist.Add(new Movie("Back to the Future",
									"Marty McFly, a 17-year-old high school student, is accidentally sent 30 years into the past in a time-traveling DeLorean invented by his close friend, the maverick scientist Doc Brown.",
									"1985",
									"/MoviePosters/backtothefuture.jpg"));

			movielist.Add(new Movie("Jaws",
									"When a killer shark unleashes chaos on a beach community off Cape Cod, it's up to a local sheriff, a marine biologist, and an old seafarer to hunt the beast down.",
									"1975",
									"/MoviePosters/jaws.jpg"));

			currentMovie = movielist[0];
		}

		private void NewSelectionClicked(object sender, SelectionChangedEventArgs e)
		{
			currentMovie = movielist[movielistview.SelectedIndex];

			//imageMoviePoster.Source = currentMovie.ImageURL;
			//This line crashes - we can't link image source text into the image source.

			textblockMovieTitle.Text = currentMovie.Title;
			textblockDate.Text = currentMovie.Year;
			textblockDescription.Text = currentMovie.Description;
		}
	}
}
