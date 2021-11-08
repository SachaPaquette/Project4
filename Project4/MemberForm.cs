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
        public Member modifiedMember { get; set; }
        public int AddM { get; set; }

       public List<Member> memberList;

        public int selected;
        public MemberForm(int addM)
        {
            InitializeComponent();
            AddM = addM;
        }

        public MemberForm(Member memb, int addM)
        {
            InitializeComponent();

            modifiedMember = memb;
            AddM = addM;
            

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
                MessageBox.Show("The Member Was not Modified");
                AddM = 3;
                this.Close();
                
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
            formOK = formOK && CheckIfFieldOK(typeTextBox.Text, "int");

            // No need to check if dob is ok 

            return formOK;

        }

        private void AddMember()
        {
            if (CheckIfFormOK() == true)
            {
                // Create new member
                Member memb = new Member();

                memb.Id = int.Parse(idTextBox.Text);
                memb.Name = nameTextBox.Text;

                memb.DoB = DateTime.Parse(dobPicker.Text);
                memb.TypeId = int.Parse(typeTextBox.Text);

                Form1.memberList.Add(memb);
            }
            else
            {
                AddM = 3;
                this.Close();
                
            }
        }

        public void LoadTextBoxes()
        {
            for (int i = 0; i < Form1.memberList.Count(); i++)
            {
                if(modifiedMember is null)
                {

                }
                else if (modifiedMember.Id == Form1.memberList[i].Id)
                {

                    nameTextBox.Text = Form1.memberList[i].Name;
                    idTextBox.Text = Form1.memberList[i].Id.ToString();
                    dobPicker.Value = Form1.memberList[i].DoB;
                    typeTextBox.Text = Form1.memberList[i].TypeId.ToString();
                                   
                }
            }
        }
        private void ModifyMember()
        {
            try
            {


                if (CheckIfFormOK() == true)
                {
                    modifiedMember.Id = int.Parse(idTextBox.Text);
                    modifiedMember.Name = nameTextBox.Text;                 
                    modifiedMember.DoB = DateTime.Parse(dobPicker.Text);
                    modifiedMember.TypeId = int.Parse(typeTextBox.Text);

                }
                else
                {
                    this.Close();

                    AddM = 3;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void MemberForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            
            if (AddM == 1)
            {
                // Call the add member method
                AddMember();
            }
            else if(AddM == 2)
            {
                // Call the modify member method
                ModifyMember();
            }
            else if(AddM == 3)
            {

            }
            
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            // Load the textboxes
            LoadTextBoxes();
        }
    }
}
