using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DatabaseConnection;

namespace RejestracjaCzasuPracyWinForms
{
    public partial class SignIn : Form
    {
        UserManager userManager = new UserManager();
        User currentUser;
        string name;

        public SignIn()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            name = chooseUserComboBox.Text;

            currentUser = userManager.GetUserWithName(name);

            if (currentUser != null)
            {
                HomePage homePage = new HomePage(currentUser);
                homePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            FillUserComboBox();
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            SIgnUpForm signUpForm = new SIgnUpForm();
            signUpForm.Show();
            this.Hide();
        }

        void FillUserComboBox()
        {
            List<User> userList = userManager.GetAllUsers();
            List<string> usersNamesList = new List<string>();

            foreach (User user in userList)
            {
                usersNamesList.Add(user.name);
            }

            chooseUserComboBox.DataSource = usersNamesList;
        }
    }
}
