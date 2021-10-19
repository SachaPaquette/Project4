using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace Project4
{
    public partial class Form1 : Form
    {

        // Variable for the list
        public static List<Movie> movieList = new List<Movie>();

        // Variable for the movie that will be read
        Movie currentMovie;

        // Variable for the file to read
        string filePath = "movies.xml";

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                // Create a textreader with the file path
                XmlTextReader xml = new XmlTextReader(filePath);

                // Read to movie
                xml.ReadToFollowing("movie");

                try
                {
                    do
                    {
                        // Create a new movie
                        currentMovie = new Movie();

                        // Move to the first attribute
                        xml.MoveToFirstAttribute();

                        // Associate the genre
                        currentMovie.Genre = xml.Value;

                        // Read to the next value
                        xml.ReadToFollowing("title");

                        // Associate the title
                        currentMovie.Title = xml.ReadElementContentAsString();

                        // Read to the next value
                        xml.ReadToFollowing("year");

                        // Associate the year
                        currentMovie.Year = Int32.Parse(xml.ReadElementContentAsString());

                        // Read to the next value
                        xml.ReadToFollowing("length");

                        // Associate the length
                        currentMovie.Length = xml.ReadElementContentAsString();

                        // Read to the next value
                        xml.ReadToFollowing("director");

                        // Associate the director
                        currentMovie.Director = xml.ReadElementContentAsString();

                        // Read to the next value
                        xml.ReadToFollowing("audienceRating");

                        // Associate the rating
                        currentMovie.Rating = Double.Parse(xml.ReadElementContentAsString());

                        // Read to next value
                        xml.ReadToFollowing("imageFilePath");

                        // Associate the path
                        currentMovie.Path = xml.ReadElementContentAsString();

                        // Add the movie to the list
                        movieList.Add(currentMovie);



                        if (genreListBox.Items.Contains(currentMovie.Genre))
                        {
                            // Nothing
                        }
                        else
                        {
                            // Add the genre to the listbox
                            genreListBox.Items.Add(currentMovie.Genre);
                        }
                    }
                    while (xml.ReadToFollowing("movie"));

                    // Close the reader
                    xml.Close();
                }

                catch
                {
                    // Error Message
                    MessageBox.Show("Error while attempting to read the file.");

                }
            }
            else
            {
                // Error Message
                Console.WriteLine("The file " + filePath + " does not exists.");
            }

        }

        private void Headers()
        {
            // Get details about file
            movieListView.View = View.Details;

            // Create the header
            ColumnHeader header1 = new ColumnHeader
            {
                // Define the title
                Text = "ID"
            };
            // Add the header
            movieListView.Columns.Add(header1);

            // Create the header
            ColumnHeader header2 = new ColumnHeader
            {
                // Define the title
                Text = "Name"
            };
            // Add the header
            movieListView.Columns.Add(header2);

            // Create the header
            ColumnHeader header3 = new ColumnHeader
            {
                // Define the title
                Text = "Year"
            };
            // Add the header
            movieListView.Columns.Add(header3);
        }

        private void Selected()
        {
            // Clear the listview
            movieListView.Items.Clear();

            if (genreListBox.SelectedIndex == -1)
            {
                // Display error message
                MessageBox.Show("Please select a genre in the listbox");
            }
            else
            {
                // Variable for the index
                int indexs = 0;

                for (int x = 0; x < movieList.Count(); x++)
                {
                    if (genreListBox.SelectedItem.ToString() == movieList[x].Genre)
                    {
                        // View details                    
                        movieListView.View = View.Details;

                        // Add the title to the listview
                        movieListView.Items.Add(movieList[x].Title);

                        // Add the year to the listview
                        movieListView.Items[indexs].SubItems.Add(movieList[x].Year.ToString());

                        // Increment the index
                        indexs = indexs + 1;
                    }

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFile(filePath);

            Headers();
        }

        private void movieListView_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void genreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call the selected method
            Selected();

            
        }

      
    }
}
