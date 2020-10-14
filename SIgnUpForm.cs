using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using DatabaseConnection;

namespace RejestracjaCzasuPracyWinForms
{
    public partial class SIgnUpForm : Form
    {
        string name;
        string password;

        public SIgnUpForm()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            name = NameTextBox.Text;
            password = PasswordTextBox.Text;

            if (CheckEnteredValues())
            {
                // Pierwsze nazwy tabelek w db, następne nazwy zmiennych
                SqlCommand insertCommand = new SqlCommand("insert into Users(UserID, Name) values(@USerID, @Name)");

                // Dopiero tutaj do zmienych przypisujemy wartości. @Username to co innego niż Username. Zabezpieczenie przed SQL injaction
                insertCommand.Parameters.AddWithValue("@UserID", Guid.NewGuid());
                insertCommand.Parameters.AddWithValue("@Name", name);

                int row = DBAccess.ExecuteQuery(insertCommand);

                if (row == 1)        // wykona się jeśli zapytanie miało wpływ na tabele
                {
                    MessageBox.Show("Account Created Successfully. FINALLY");
                    //User currentUser = User.GetUserWithNameAndPassword(name, password);

                    //HomePage homePage = new HomePage(currentUser);
                    //homePage.Show();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to create account. Sorry");
                }
            }
        }

        bool CheckEnteredValues()
        {
            if (!ValidateDate.Name(name))
            {
                MessageBox.Show("There is already user with this name");
            }
            //else if (!ValidateDate.Password(password))
            //{
            //    MessageBox.Show("Your password is too short");
            //}
            else
            {
                return true;
            }

            return false;
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }
    }
}

