using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using DatabaseConnection;

namespace RejestracjaCzasuPracyWinForms
{
    public partial class SIgnUpForm : Form
    {
        DBAccess dbAccess = new DBAccess();

        string firstName;
        string surName;

        public SIgnUpForm()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            firstName = FirstNameTextBox.Text;
            surName = SurNameTextBox.Text;
            
            // Pierwsze nazwy tabelek w db, następne nazwy zmiennych
            SqlCommand insertCommand = new SqlCommand("insert into CRMember(MemberID, FirstName, SurName, InsDate, InsUser, IsActive) " +
                "values(@MemberID, @FirstName, @SurName, @InsDate, @InsUser, @IsActive)");

            // Dopiero tutaj do zmienych przypisujemy wartości. @FirstName to co innego niż FirstName. Zabezpieczenie przed SQL injaction
            insertCommand.Parameters.AddWithValue("@MemberID", Guid.NewGuid());
            insertCommand.Parameters.AddWithValue("@FirstName", firstName);
            insertCommand.Parameters.AddWithValue("@SurName", surName);
            insertCommand.Parameters.AddWithValue("@InsDate", DateTime.Today);
            insertCommand.Parameters.AddWithValue("@InsUser", "Default");
            insertCommand.Parameters.AddWithValue("@IsActive", 1);

            int row = dbAccess.ExecuteQuery(insertCommand);

            if (row == 1)        // wykona się jeśli zapytanie miało wpływ na tabele
            {
                MessageBox.Show("Account Created Successfully.");
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

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }
    }
}

