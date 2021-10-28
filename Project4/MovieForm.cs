using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project4
{
    public partial class MovieForm : Form
    {
        List<Movie> listMovie; 
        public int selected;
        MySqlConnection dbConnection;
        public List<Genre> genreList;
        public string selectedGenre; 

        public MovieForm(List<Movie> movieList, int selectedMovie)
        {
            InitializeComponent();
            listMovie = movieList;
            selected = selectedMovie;
        }

        public void LoadTextBoxes()
        {
            for(int i = 0; i < listMovie.Count(); i++)
            {
                if(selected == listMovie[i].Id)
                {
                    listMovie[i].Genre = selectedGenre;
                    titleTextBox.Text = listMovie[i].Title;
                    genreTextBox.Text = listMovie[i].Genre;
                    yearTextBox.Text = listMovie[i].Year.ToString();
                    lengthTextBox.Text = listMovie[i].Length.ToString();
                    directorTextBox.Text = listMovie[i].Director;
                    ratingTextBox.Text = listMovie[i].Rating.ToString();
                    pathTextBox.Text = listMovie[i].Path;
                }
            }
        }
        private void SetDBConnection(string serverAddress, string serverPort, string username, string passwd, string dbName)
        {

            // For connection testing purposes
            //string conectionString = "server=127.0.0.1; user=user1; database=test; port=3306; password=oop2; SSL Mode=None";

            string conectionString = "server=" + serverAddress + "; port=" + serverPort + "; user=" + username + "; password=" + passwd + "; database=" + dbName + "; SSL Mode=None;";

            Console.WriteLine(conectionString);

            dbConnection = new MySqlConnection(conectionString);

        }


        public void GetGenreFromDb() 
        {
            Genre currentGenre;



            try
            {
                // Open the connection
                dbConnection.Open();

                // String to get movies
                string movieQuery = "Select * FROM jt_genre_movie WHERE movie_id = " + selected + " ;";


                // sql containing query to be executed
                MySqlCommand dbComm = new MySqlCommand(movieQuery, dbConnection);


                // Store the results
                MySqlDataReader dataReader = dbComm.ExecuteReader();
                //PROBLEM WITH THIS 
                while (dataReader.Read())
                {
                    // Create a new movie
                    currentGenre = new Genre();

                    string genreCode = dataReader.GetString(0);
                    int movie_id = dataReader.GetInt32(1);
                    if(movie_id == selected)
                    {
                        string movieQuery2 = "Select * FROM genre WHERE code = " + genreCode + ";";

                        MySqlCommand genreMovie = new MySqlCommand(movieQuery2, dbConnection);

                        MySqlDataReader reader = genreMovie.ExecuteReader();

                        while (reader.Read())
                        {
                            /*
                            currentGenre.Code = reader.GetString(0);
                            currentGenre.Name = reader.GetString(1);
                            currentGenre.Description = reader.GetString(2);
                            genreList.Add(currentGenre);
                            */
                            selectedGenre = reader.GetString(1);
                            
                            
                        }

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

        private void MovieForm_Load(object sender, EventArgs e)
        {
            if (selected >= 0)
            {
                SetDBConnection("127.0.0.1", "3306", "user1", "yolo123456789", "test_db");
                GetGenreFromDb();
                LoadTextBoxes();
            }
        }
    }
}
