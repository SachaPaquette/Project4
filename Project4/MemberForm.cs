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
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        public MemberForm(Member memb)
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
            formOK = formOK && CheckIfFieldOK(idTextBox.Text, "int");
            formOK = formOK && CheckIfFieldOK(nameTextBox.Text, "string");
            formOK = formOK && CheckIfFieldOK(dobTextBox.Text, "");
            formOK = formOK && CheckIfFieldOK(typeTextBox.Text, "int");

            // No need to check if path is ok since the path will to be user entered.

            return formOK;

        }
    }
}
