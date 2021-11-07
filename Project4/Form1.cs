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
using MySql.Data.MySqlClient;

namespace Project4
{
    public partial class Form1 : Form
    {

        // Variable for the list
        public static List<Movie> movieList = new List<Movie>();
        public static List<Genre> genreList = new List<Genre>();
        public static List<Member> memberList = new List<Member>();

        // Variable for the movie that will be read
        Movie currentMovie;

        public GenreForm genre;
        public MemberForm memb;
        public MovieForm mov;


        MySqlConnection dbConnection;

        public Form1()
        {
            InitializeComponent();
        }
        private void SetDBConnection(string serverAddress, string serverPort, string username, string passwd, string dbName)
        {
            // Variable for the connection
            string conectionString = "server=" + serverAddress + "; port=" + serverPort + "; user=" + username + "; password=" + passwd + "; database=" + dbName + "; SSL Mode=None;";

           // Connection
            dbConnection = new MySqlConnection(conectionString);

        }

        private void GetMoviesFromDb()
        {
            // Create movie
            Movie currentMov;

            try
            {
                // Open the connection
                dbConnection.Open();

                // String to get movies
                string movieQuery = "Select * FROM movie;";

                // sql containing query to be executed
                MySqlCommand dbComm = new MySqlCommand(movieQuery, dbConnection);

                // Store the results
                MySqlDataReader dataReader = dbComm.ExecuteReader();

                while (dataReader.Read())
                {
                    // Create a new movie
                    currentMov = new Movie();

                    currentMov.Id = dataReader.GetInt32(0);
                    currentMov.Title = dataReader.GetString(1);
                    currentMov.Year = dataReader.GetInt32(2);
                    currentMov.Length = dataReader.GetString(3);
                    currentMov.Rating = double.Parse(dataReader.GetString(4));
                    currentMov.Path = dataReader.GetString(5);

                    // Add the movie to the list
                    movieList.Add(currentMov);
                }

                // Close the connection
                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    // Close the connection
                    dbConnection.Close();
                }
            }
        }

        private void GetGenreFromDb()
        {
            // Create genre
            Genre currentGenre;

            try
            {
                // Open the connection
                dbConnection.Open();

                // String to get movies
                string movieQuery = "Select * FROM genre;";

                // sql containing query to be executed
                MySqlCommand dbComm = new MySqlCommand(movieQuery, dbConnection);


                // Store the results
                MySqlDataReader dataReader = dbComm.ExecuteReader();


                while (dataReader.Read())
                {
                    // Create a new genre
                    currentGenre = new Genre();

                    currentGenre.Code = dataReader.GetString(0);
                    currentGenre.Name = dataReader.GetString(1);
                    currentGenre.Description = dataReader.GetString(2);

                    // Add the genre to the list
                    genreList.Add(currentGenre);

                    if (!genreListBox.Items.Contains(currentGenre.Name))
                    {
                        // Add the genre to the listbox
                        genreListBox.Items.Add(currentGenre.Name);
                    }
                }

                // Close the connection
                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    // Close the connection
                    dbConnection.Close();
                }
            }
        }

        private void RefreshGenre()
        {
            // Clear the list box
            genreListBox.Items.Clear();

            for (int x = 0; x < genreList.Count(); x++)
            {
                if (!genreListBox.Items.Contains(genreList[x].Name))
                {
                    // Add to the listbox the genre name
                    genreListBox.Items.Add(genreList[x].Name);
                }
            }
        }


        private void GetMemberFromDb()
        {
            // Create member
            Member currentMember;

            try
            {
                // Open the connection
                dbConnection.Open();

                // String to get movies
                string movieQuery = "Select * FROM member;";


                // sql containing query to be executed
                MySqlCommand dbComm = new MySqlCommand(movieQuery, dbConnection);


                // Store the results
                MySqlDataReader dataReader = dbComm.ExecuteReader();


                while (dataReader.Read())
                {
                    // Create a new movie
                    currentMember = new Member();

                    currentMember.Id = dataReader.GetInt32(0);
                    currentMember.Name = dataReader.GetString(1);
                    currentMember.DoB = dataReader.GetDateTime(2);
                    currentMember.TypeId = dataReader.GetInt32(3);

                    // Add to the member list
                    memberList.Add(currentMember);

                    if (!memberListBox.Items.Contains(currentMember.Name))
                    {
                        // Add the member to the listbox
                        memberListBox.Items.Add(currentMember.Name);
                    }
                }

                // Close the connection
                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    // Close the connection
                    dbConnection.Close();
                }
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

            if (genreListBox.SelectedIndex == -1)
            {
                // Display error message
                MessageBox.Show("Please select a genre in the listbox");
            }
            else
            {
                // Variable for the selected genre
                string genre = genreListBox.SelectedItem.ToString();

                // Create movie
                Movie currentMov;

                try
                {
                    // Clear the listview
                    movieListView.Items.Clear();

                    // Open the connection
                    dbConnection.Open();

                    // String to get movies
                    string movieQuery = "select * from movie m, jt_genre_movie j , genre g where m.id = j.movie_id and g.code = j.genre_code and g.name = '" + genre + "';";


                    // sql containing query to be executed
                    MySqlCommand dbComm = new MySqlCommand(movieQuery, dbConnection);

                    // Store the results
                    MySqlDataReader dataReader = dbComm.ExecuteReader();

                    // Variable for the index
                    int index = 0;

                    while (dataReader.Read())
                    {
                        // Create a new movie
                        currentMov = new Movie();

                        // Assign the title
                        currentMov.Title = dataReader.GetString(1);

                        for (int x = 0; x < movieList.Count(); x++)
                        {
                            if (currentMov.Title == movieList[x].Title)
                            {
                                // View details
                                movieListView.View = View.Details;

                                // Add the items
                                movieListView.Items.Add(movieList[x].Id.ToString());
                                movieListView.Items[index].SubItems.Add(movieList[x].Title);
                                movieListView.Items[index].SubItems.Add(movieList[x].Year.ToString());

                                // Increment the index
                                index += 1;
                            }
                        }
                        // Reset the title
                        currentMov.Title = "";
                    }

                    // Close the connection
                    dbConnection.Close();
                }
                catch (MySqlException ex)
                {
                    if (dbConnection.State.ToString() == "Open")
                    {
                        // Close the connection
                        dbConnection.Close();
                    }
                }



            }
        }

        /// <summary>
        /// When the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //   LoadFile(filePath);
            //This method sets up a connection to a MySQL database
            SetDBConnection("127.0.0.1", "3306", "user1", "yolo123456789", "db_test");

            // Call the header method
            Headers();

            // Call the method to get the genre from the database
            GetGenreFromDb();

            // Call the method to get the movies from the database
            GetMoviesFromDb();

            // Call the method to get the members from the database
            GetMemberFromDb();
        }
        /// <summary>
        /// When a movie is selected in the listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Variable for the selected movie
            string selected = movieListView.SelectedItems[0].SubItems[0].Text;

            // Create new movie form
            mov = new MovieForm(movieList, Convert.ToInt32(selected));

            // Show the new movie form
            mov.Show();

            // Call the method to refresh the listview
            Selected();
        }

        /// <summary>
        /// When a genre is selected in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the listview
            movieListView.Items.Clear();

            // Call the selected method
            Selected();
        }
        /// <summary>
        /// Method to modify a genre
        /// </summary>
        private void ModifyGenre()
        {
            // Variable for the genre name
            string genreName = genreListBox.SelectedItem.ToString();

            for (int x = 0; x < genreList.Count(); x++)
            {
                if (genreName == genreList[x].Name)
                {
                    // Create a new genre form
                    genre = new GenreForm(genreList[x]);

                    // Show the new form
                    genre.ShowDialog();

                    // Call the method to refresh the genre listbox
                    RefreshGenre();
                }
            }
        }
        /// <summary>
        /// Modify genre button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifyGenreButton_Click(object sender, EventArgs e)
        {
            // Call the modify genre method
            ModifyGenre();
        }
        /// <summary>
        /// Method to add a genre
        /// </summary>
        private void AddGenre()
        {
            // create new genre form
            genre = new GenreForm();

            // Show the form
            genre.ShowDialog();

            // Call the method to refresh the genre listbox
            RefreshGenre();
        }
        /// <summary>
        /// Add genre button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addGenreButton_Click(object sender, EventArgs e)
        {
            // Call the add genre method
            AddGenre();
        }
        /// <summary>
        /// Method to refresh members listbox
        /// </summary>
        private void RefreshMember()
        {
            // Clear the list box
            memberListBox.Items.Clear();

            for (int x = 0; x < memberList.Count(); x++)
            {
                if (!memberListBox.Items.Contains(memberList[x].Name))
                {
                    // Add to the listbox the genre name
                    memberListBox.Items.Add(memberList[x].Name);
                }
            }
        }
        /// <summary>
        /// Method to modify a member
        /// </summary>
        private void ModifyMember()
        {
            // Variable for the member name that is selected
            string memberName = memberListBox.SelectedItem.ToString();

            for (int x = 0; x < genreList.Count(); x++)
            {
                if (memberName == memberList[x].Name)
                {
                    // Create new member form
                    memb = new MemberForm(memberList[x]);

                    // Show the form
                    memb.ShowDialog();

                    // Call the refresh member method
                    RefreshMember();
                }
            }
        }
        /// <summary>
        /// Modify member button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void memberModButton_Click(object sender, EventArgs e)
        {
            // Call the modify member method
            ModifyMember();
        }
        /// <summary>
        /// Method to add a member (open form)
        /// </summary>
        private void AddMember()
        {
            // Create new member form
            memb = new MemberForm();

            // Show new form
            memb.ShowDialog();

            // Call the refresh member list box method
            RefreshMember();
        }
        /// <summary>
        /// Add member button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMemberButton_Click(object sender, EventArgs e)
        {
            // Call the add member method
            AddMember();
        }
        /// <summary>
        /// Method to search by name
        /// </summary>
        private void SearchName()
        {
            // Value to search for
            string value = nameTextBox.Text.ToLower();

            // Variables for a counter and index
            int counter = 0;
            int index = 0;

            // Clear the listview
            movieListView.Items.Clear();

            for (int x = 0; x < movieList.Count(); x++)
            {
                // Variable for the movie title in the list to lower
                string lower = movieList[x].Title.ToLower();

                if (lower.Contains(value))
                {
                    // Add the title and the year of the searched movie(s)
                    movieListView.Items.Add(movieList[x].Id.ToString());
                    movieListView.Items[index].SubItems.Add(movieList[x].Title);
                    movieListView.Items[index].SubItems.Add(movieList[x].Year.ToString());

                    // Increment the indexs
                    index += 1;
                    counter++;
                }
            }
            if (counter == 0)
            {
                // No movies found
                MessageBox.Show("No Movies with this name were found.");
            }
        }
        /// <summary>
        /// When search by name button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchNameButton_Click(object sender, EventArgs e)
        {
            // Call the search by name method
            SearchName();
        }

        /// <summary>
        /// Method to search by year
        /// </summary>
        private void SearchYear()
        {
            // Value to search for
            int value = int.Parse(yearTextBox.Text);

            // Variables for a counter and index
            int counter = 0;
            int index = 0;

            // Clear the listview
            movieListView.Items.Clear();

            for (int x = 0; x < movieList.Count(); x++)
            {
                // Variable for the movie title in the list to lower
                int year = movieList[x].Year;

                if (year == value)
                {
                    // Add the title and the year of the searched movie(s)
                    movieListView.Items.Add(movieList[x].Id.ToString());
                    movieListView.Items[index].SubItems.Add(movieList[x].Title);
                    movieListView.Items[index].SubItems.Add(movieList[x].Year.ToString());

                    // Increment the indexs
                    index += 1;
                    counter++;
                }
            }
            if (counter == 0)
            {
                // No movies found
                MessageBox.Show("No Movies with this year were found.");
            }
        }

        /// <summary>
        /// When search year button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchYearButton_Click(object sender, EventArgs e)
        {
            // Call the search by year method
            SearchYear();
        }

        /// <summary>
        /// Method to add a movie
        /// </summary>
        private void AddMovie()
        {

            // Create new movie form
            mov = new MovieForm(movieList, -1);

            // Show form
            mov.ShowDialog();

            if (genreListBox.SelectedIndex != -1)
            {
                // Call the method to refresh movies listview
                Selected();
            }
        }
        /// <summary>
        /// When add movie button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMovieButton_Click(object sender, EventArgs e)
        {
            // Call the add movie method
            AddMovie();
        }

        private void SaveMovies()
        {
            for (int x = 0; x < movieList.Count(); x++)
            {

                try
                {
                    // Open the connection
                    dbConnection.Open();
                    string selectQuery = "Select m.id from movie m";
                    MySqlCommand testSelect = new MySqlCommand(selectQuery, dbConnection);
                    MySqlDataReader dataReader = testSelect.ExecuteReader();

                    //Check to see if the new movie has an existing ID in the db 
                    int index = 0;
                    List<int> idsMovie = new List<int>();
                    while (dataReader.Read())
                    {
                        idsMovie.Add(dataReader.GetInt32(0));

                        index++;
                    }

                    for (int y = 0; x < movieList.Count(); x++)
                    {

                        if (!idsMovie.Contains(movieList[x].Id))
                        {
                            string movieQuery = "Insert into movie(id, title, year, length, audience_rating, image_file_path) VALUES(" + movieList[x].Id + ", '" + movieList[x].Title + "' ," + movieList[x].Year + ", '" + movieList[x].Length + "' ," + movieList[x].Rating + ", '" + movieList[x].Path + "');";

                            // sql containing query to be executed
                            MySqlCommand dbComm = new MySqlCommand(movieQuery, dbConnection);
                        }                        
                    }

                    // Close the connection
                    dbConnection.Close();
                }
                catch (MySqlException ex)
                {
                    if (dbConnection.State.ToString() == "Open")
                    {
                        // Close the connection
                        dbConnection.Close();
                    }
                }
            }
        }
    }
}
