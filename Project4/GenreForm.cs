using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class GenreForm : Form
    {
        public Genre modifiedGenre { get; set; }

        public GenreForm()
        {
            InitializeComponent();
        }
        public GenreForm(Genre genree)
        {
            InitializeComponent();

            modifiedGenre = genree;
        }
        /// <summary>
        /// Method to check if field is ok
        /// </summary>
        /// <param name="field"></param>
        /// <param name="fieldType"></param>
        /// <returns></returns>
        private bool CheckIfFieldOK(string field, string fieldType)
        {
            // Variables for the type of input 
            int intVariable;
            double doubleVariable;

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
            formOK = formOK && CheckIfFieldOK(codeTextBox.Text, "int");
            formOK = formOK && CheckIfFieldOK(descriptionTextBox.Text, "string");

            // No need to check if path is ok since the path will to be user entered.

            return formOK;

        }

        public void LoadTextBoxes()
        {
            for (int i = 0; i < Form1.genreList.Count(); i++)
            {
                if (modifiedGenre is null)
                {
                }
                else
                {


                    if (modifiedGenre.Code == Form1.genreList[i].Code)
                    {

                        titleTextBox.Text = Form1.genreList[i].Name;
                        codeTextBox.Text = Form1.genreList[i].Code.ToString();
                        descriptionTextBox.Text = Form1.genreList[i].Description;

                    }
                }
            }
        }
        /// <summary>
        /// Method to add a genre
        /// </summary>
        private void AddGenre()
        {
            if (CheckIfFormOK() == true)
            {
                Genre genr = new Genre();

                genr.Name = titleTextBox.Text;
                genr.Code = codeTextBox.Text;
                genr.Description = descriptionTextBox.Text;

                Form1.genreList.Add(genr);
            }
        }
        /// <summary>
        /// Method to modify genre
        /// </summary>
        private void Modify()
        {
            if (CheckIfFormOK() == true)
            {
                modifiedGenre.Name = titleTextBox.Text;
                modifiedGenre.Code = codeTextBox.Text;
                modifiedGenre.Description = descriptionTextBox.Text;
            }
        }
        /// <summary>
        /// If form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (modifiedGenre is null)
            {
                // Call the add genre method
                AddGenre();

            }
            else
            {
                // Call the modify method
                Modify();
            }
            }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            LoadTextBoxes();
        }
    }
}
