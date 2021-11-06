using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
         string selectedGenre; 

        public MovieForm(List<Movie> movieList, int selectedMovie)
        {
            InitializeComponent();
            listMovie = movieList;
            selected = selectedMovie;
        }
        public MovieForm()
        {
            InitializeComponent();
            
            
        }
        private bool CheckIfFieldOK(string field, string fieldType)
        {
            // Variables for the type of input 
            int intVariable;
            double doubleVariable;
            DateTime dateVariable;
            //Checks if the 'field' parameter is not null or empty
            if (String.IsNullOrEmpty(field))
            {
                // Error message
                MessageBox.Show("At least one required field is empty");

                return false;
            }

            //Checks if the string (the user input) corresponds to the expected data type
            switch (fieldType)
            {
                case "int":  //Checks if the data type is 'int' (in other words, checks if it is possible to convert the value to int)
                    if (int.TryParse(field, out intVariable) == false)
                    {
                        MessageBox.Show("The value: " + field + " must be a(n) " + fieldType + " value");
                        return false;
                    }
                    break;
                case "double":  //Checks if the data type is 'double'
                    if (double.TryParse(field, out doubleVariable) == false)
                    {
                        MessageBox.Show("The value: " + field + " must be a(n) " + fieldType + " value");
                        return false;
                    }
                    break;
                case "string":
                    //Nothing to do
                    break;

            }

            return true;
        }

        /// <summary>
        /// Check if the form is ok
        /// </summary>
        /// <returns></returns>
        private bool CheckIfFormOK()
        {
            // Boolean variable to check if the input is in a correct format
            bool formOK = true;

            // Check if the inputs are correct 
            formOK = formOK && CheckIfFieldOK(titleTextBox.Text, "string");
            formOK = formOK && CheckIfFieldOK(genreTextBox.Text, "string");
            formOK = formOK && CheckIfFieldOK(yearTextBox.Text, "int");
            formOK = formOK && CheckIfFieldOK(lengthTextBox.Text, "string");
            formOK = formOK && CheckIfFieldOK(directorTextBox.Text, "string");
            formOK = formOK && CheckIfFieldOK(ratingTextBox.Text, "double");
            

            // No need to check if path is ok since the path will to be user entered.

            return formOK;

        }
    
    public void LoadTextBoxes()
        {
            for(int i = 0; i < listMovie.Count(); i++)
            {
                if(selected == listMovie[i].Id)
                {
                    
                    titleTextBox.Text = listMovie[i].Title;
                    
                    yearTextBox.Text = listMovie[i].Year.ToString();
                    lengthTextBox.Text = listMovie[i].Length.ToString();
                    directorTextBox.Text = listMovie[i].Director;
                    ratingTextBox.Text = listMovie[i].Rating.ToString();
                    pathTextBox.Text = listMovie[i].Path;

                    if (File.Exists(listMovie[i].Path))
                    {
                        // Display the picture from the path
                        moviePictureBox.Image = Image.FromFile(listMovie[i].Path);
                    }
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
            
            List<Genre> genreList = new List<Genre>();
            Genre currentGenre;



            try
            {
                // Open the connection
               dbConnection.Open();

                string movieQuery2 = "Select * FROM genre g, movie m, jt_genre_movie j WHERE g.code = j.genre_code and j.movie_id = m.id and j.movie_id = " + selected + " and m.title = '" + titleTextBox.Text + "';";

                // sql containing query to be executed
                MySqlCommand dbComm = new MySqlCommand(movieQuery2, dbConnection);


                // Store the results
                MySqlDataReader dataReader = dbComm.ExecuteReader();

                while (dataReader.Read())
                        {
                    currentGenre = new Genre();
                         
                            selectedGenre = dataReader.GetString(1);

                    for (int i = 0; i < listMovie.Count(); i++)
                    {
                        listMovie[i].Genre = selectedGenre;
                        genreTextBox.Text = listMovie[i].Genre;
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
                SetDBConnection("127.0.0.1", "3306", "user1", "yolo123456789", "db_test");
                
                LoadTextBoxes();
                GetGenreFromDb();
               // LoadTextBoxes(); // Need to reload to get genre
                GetMovieMember();
            }
        }

        private void GetPath()
        {
            // Variable for the startup path
            string startupPath = Application.StartupPath;

            using (FolderBrowserDialog fbDialog = new FolderBrowserDialog())
            {
                // fbDialog infos, path 
                fbDialog.Description = "Open a folder";
                fbDialog.RootFolder = Environment.SpecialFolder.MyComputer;

                if (fbDialog.ShowDialog() == DialogResult.OK)
                {
                    // Variable for the selected folder path
                    string folder = fbDialog.SelectedPath;

                    // Display the chosen folder path
                    pathTextBox.Text = folder;
                }
            }
        }
        private void pathButton_Click(object sender, EventArgs e)
        {
            // Call the get path method
            GetPath();
        }

        private void Delete()
        {
            // Remove the movie from the list
            Form1.movieList.Remove(listMovie[selected]);

            // Close the form
            this.Close();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Call the delete method
            Delete();
        }

        private void GetMovieMember()
        {
            Member currentMember;



            try
            {
                // Open the connection
                dbConnection.Open();

                // String to get movies
                string movieQuery = "Select * FROM member m, jt_movie_member j, movie n where j.movie_id = n.id and m.id = j.member_id and n.title = '" + titleTextBox.Text + "';";


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

                    memberListBox.Items.Add(currentMember.Name);

                   
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
        private void Member()
        {
            for (int x = 0; x < Form1.memberList.Count(); x++)
            {
               // if (Form1.memberList[x].Id == )
            }
        }
        private void memberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Modify()
        {
            if (CheckIfFormOK() == true)
            {
                // Associate the infos to the modified movie variable
                listMovie[selected].Title = titleTextBox.Text;
                listMovie[selected].Director = directorTextBox.Text;
                listMovie[selected].Year = int.Parse(yearTextBox.Text);
                listMovie[selected].Length = lengthTextBox.Text;
                listMovie[selected].Genre = genreTextBox.Text;
                listMovie[selected].Rating = Double.Parse(ratingTextBox.Text);
                listMovie[selected].Path = pathTextBox.Text;
            }
        }
        private void modifyButton_Click(object sender, EventArgs e)
        {
            // Call the modiy method
            Modify();
        }

        private void AddMovie()
        {
            if (CheckIfFormOK() == true)
            { 
                    // Create a new movie
                    Movie mov = new Movie();

                    // Associate the infos with the newly created movie
                    mov.Title = titleTextBox.Text;
                    mov.Genre = genreTextBox.Text;
                    mov.Year = int.Parse(yearTextBox.Text);
                    mov.Length = lengthTextBox.Text;
                    mov.Director = directorTextBox.Text;
                    mov.Rating = Double.Parse(ratingTextBox.Text);
                    mov.Path = pathTextBox.Text;

                    // Add the movie to the list
                    Form1.movieList.Add(mov);      
            }
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            // Call the add a movie method
            AddMovie();
        }
    }
}
