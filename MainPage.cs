using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using SQLDatabaseProject.DatabaseProject;

namespace SQLDatabaseProject
{
    public partial class MainPage : Form
    {
        //use dbaccess object
        DBAccess objDbAccess = new DBAccess();  
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            //Load the main page with data in variables that was pulled from database. 
            //Also display custom welcome message
            lblWelcomeName.Text = "Welcome: " + SignIn.name;
            txtNameMain.Text = SignIn.name;
            txtEmailMain.Text = SignIn.email;
            txtPasswordMain.Text = SignIn.password;
            cmdCountryMain.Text = SignIn.country;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            //add info in text boxes to variables to be converted into SQL values
            string newUserName = txtNameMain.Text;
            string newUserEmail = txtEmailMain.Text;
            string newUserPassword = txtPasswordMain.Text;
            string newUserCountry = cmdCountryMain.Text;

            //Verify that there is data in text boxes
            if(newUserName.Equals(""))
            {
                MessageBox.Show("Please enter new name");
            }
            else if(newUserEmail.Equals(""))
            {
                MessageBox.Show("Please enter new email");
            }
            else if (newUserPassword.Equals(""))
            {
                MessageBox.Show("Please enter new password");
            }
            else if (newUserCountry.Equals(""))
            {
                MessageBox.Show("Please select new country");
            }
            else
            {
                //Query for updating usertable information based off current ID, confidentially
                string query = "Update UserTable SET Name = '" + @newUserName + "', Email = '" + @newUserEmail + "', Password = '" + @newUserPassword + "', Country = '" + @newUserCountry + "' where ID = '" + SignIn.id + "'";

                SqlCommand updateCommand = new SqlCommand(query);
                
                //Keep the data private, keep data hidden
                updateCommand.Parameters.AddWithValue("@userName", @newUserName);
                updateCommand.Parameters.AddWithValue("@userEmail", @newUserEmail);
                updateCommand.Parameters.AddWithValue("@userPassword", @newUserPassword);
                updateCommand.Parameters.AddWithValue("@userCountry", @newUserCountry);

                int row = objDbAccess.executeQuery(updateCommand);

                //Tell user if action is successful or not
                if (row == 1)
                {
                    MessageBox.Show("Account information updated successfully");

                    this.Hide();
                    SignIn signIn = new SignIn();
                    signIn.Show();
                }
                else
                {
                    MessageBox.Show("Issue updating information. Please try again");
                }
            }

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            //ask the user if they are sure they want to delete their info
            DialogResult dialog = MessageBox.Show("Are you sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dialog == DialogResult.Yes)
            {
                //if the user selects yes, create a delete query where the line item with the current id is deleted
                string query = "DELETE from UserTable Where ID = '" + SignIn.id + "'";

                SqlCommand deleteCommand = new SqlCommand(query);

                int row = objDbAccess.executeQuery(deleteCommand);

                //Tell user if action is successful or not
                if (row == 1)
                {
                    MessageBox.Show("Account information deleted successfully");

                    this.Hide();
                    SignIn signIn = new SignIn();
                    signIn.Show();
                }
                else
                {
                    MessageBox.Show("Issue deleteing information. Please try again");
                }
            }
        }
    }
}
