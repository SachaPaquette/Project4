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

        MySqlConnection dbConnection;

        public Form1()
        {
            InitializeComponent();
        }
        private void SetDBConnection(string serverAddress, string serverPort, string username, string passwd, string dbName)
        {

            // For connection testing purposes
            //string conectionString = "server=127.0.0.1; user=user1; database=test; port=3306; password=oop2; SSL Mode=None";

            string conectionString = "server=" + serverAddress + "; port=" + serverPort + "; user=" + username + "; password=" + passwd + "; database=" + dbName + "; SSL Mode=None;";

            Console.WriteLine(conectionString);

            dbConnection = new MySqlConnection(conectionString);

        }

        private void ReadDB()
        {
            
        }

        private void GetMoviesFromDb()
        {
            Movie currentMov;

           // List<Movie> movieList = new List<Movie>();

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


                while(dataReader.Read())
                {
                    // Create a new movie
                    currentMov = new Movie();

                    currentMov.Id = dataReader.GetInt32(0);
                    currentMov.Title = dataReader.GetString(1);
                    currentMov.Year = dataReader.GetInt32(2);
                    currentMov.Length = dataReader.GetString(3);
                    currentMov.Path = dataReader.GetString(4);

                    movieList.Add(currentMov);
                }
                // Close the connection
                dbConnection.Close();
            }
            catch(MySqlException ex)
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
                    // Create a new movie
                    currentGenre = new Genre();

                    currentGenre.Code = dataReader.GetInt32(0);
                    currentGenre.Name = dataReader.GetString(1);
                    currentGenre.Description = dataReader.GetString(2);

                    genreList.Add(currentGenre);

                    if (!genreListBox.Items.Contains(currentGenre.Name))
                    {

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

                    memberList.Add(currentMember);

                    if (!genreListBox.Items.Contains(currentMember.Name))
                    {

                        genreListBox.Items.Add(currentMember.Name);
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
                for (int y = 0; y < genreList.Count(); y++)
                {
                    for (int x = 0; x < movieList.Count(); x++)
                    {
                        if (genreListBox.SelectedItem.ToString() == genreList[y].Name)
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //   LoadFile(filePath);
            //This method sets up a connection to a MySQL database
            SetDBConnection("127.0.0.1", "3306", "loc", "yolo123!", "db_test");
            Headers();

            GetGenreFromDb();
        }

        private void movieListView_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void genreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            GetMoviesFromDb();
            // Call the selected method
            Selected();

            
        }
        private void ModifyGenre()
        {
            string genreName = genreListBox.SelectedItem.ToString();
            for (int x = 0; x < genreList.Count(); x++)
            {
                if (genreName == genreList[x].Name)
                {
                    genre = new GenreForm(genreList[x]);

                    genre.ShowDialog();

                    RefreshGenre();
                }
            }
        }
        private void modifyGenreButton_Click(object sender, EventArgs e)
        {
            ModifyGenre();
        }

        private void AddGenre()
        {
            genre = new GenreForm();

            genre.ShowDialog();

            RefreshGenre();
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            AddGenre();
        }
    }
}
