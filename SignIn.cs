using SQLDatabaseProject.DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDatabaseProject
{
    public partial class SignIn : Form
    {
        public static string id, name, email, password, country;
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUserTable = new DataTable();    
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string userEmail = txtEmailLogin.Text;
            string userPassword = txtPasswordLogin.Text;
            if(userEmail.Equals(""))
            {
                MessageBox.Show("Please enter a valid email");
            }
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("Please enter a valid password");
            }
            else
            {
                //if any values are in email and password, check the database for matches
                string query = "Select * From UserTable Where email='" + userEmail + "' And Password ='" + userPassword + "'";

                objDBAccess.readDatathroughAdapter(query, dtUserTable);

                //If the correct amount of data is pulled from the connection, show success
                if(dtUserTable.Rows.Count == 1)
                {
                    //add data that is pulled from the server into variables that c# can use anywhere
                    id = dtUserTable.Rows[0]["ID"].ToString();
                    name = dtUserTable.Rows[0]["Name"].ToString();
                    email = dtUserTable.Rows[0]["Email"].ToString();
                    password = dtUserTable.Rows[0]["Password"].ToString();
                    country = dtUserTable.Rows[0]["Country"].ToString();

                    MessageBox.Show("You are now logged in");
                    objDBAccess.closeConn();

                    this.Hide();
                    MainPage home = new MainPage();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Those were not valid credentials, please try again");
                }
            }
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            //hide current window
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
