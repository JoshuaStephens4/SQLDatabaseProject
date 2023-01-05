using SQLDatabaseProject.DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDatabaseProject
{
    public partial class Login : Form
    {
        DBAccess objDBAccess = new DBAccess();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Add values from boxes into variables
            string userName = txtName.Text;
            string userEmail = txtEmail.Text;
            string userPassword = txtPassword.Text;
            string userCountry = cmdCountry.Text;

            //Validate the information, and if there are blanks inform user
            if(userName.Equals(""))
            {
                MessageBox.Show("Please enter your username.");
            }
            else if (userEmail.Equals(""))
            {
                MessageBox.Show("Please enter your email.");
            }
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("Please enter your password.");
            }
            else if (userCountry.Equals(""))
            {
                MessageBox.Show("Please select your country.");
            }
            else
            {
                //change C# values into sql values, to appropriate columns
                SqlCommand insertCommand = new SqlCommand("Insert into UserTable(Name,Email,Password,Country) values(@userName, @userEmail, @userPassword, @userCountry)");

                //Keep the data private, keep data hidden
                insertCommand.Parameters.AddWithValue("@userName", userName);
                insertCommand.Parameters.AddWithValue("@userEmail", userEmail);
                insertCommand.Parameters.AddWithValue("@userPassword", userPassword);
                insertCommand.Parameters.AddWithValue("@userCountry", userCountry);

               int row = objDBAccess.executeQuery(insertCommand);

               //Tell user if action is successful or not
                if(row == 1)
                {
                    MessageBox.Show("Account created successfully, Please relogin");

                    this.Hide();
                    SignIn signIn = new SignIn();
                    signIn.Show();
                }
                else
                {
                    MessageBox.Show("Issue creating account. Please try again");
                }
            }
        }
    }
}
