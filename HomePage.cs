using System;
using System.Windows.Forms;
using DatabaseConnection;
using System.Configuration;

namespace RejestracjaCzasuPracyWinForms
{
    public partial class HomePage : Form
    {
        User currentUser;

        public HomePage(User _currentUser)
        {
            InitializeComponent();
            currentUser = _currentUser;
            RefreshWindow();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            nameLabel.Text = currentUser.name;
            FillWorkHoursTextBoxes();
            RefreshWindow();
        }

        private void goHomeButton_Click(object sender, EventArgs e)
        {
            //DateTime startDate = Convert.ToDateTime(startHourTextBox.Text);
            //DateTime finishDate = Convert.ToDateTime(finishHourTextBox.Text);

            //if (!ValidateDate.CheckWorkHours(startDate, finishDate))
            //{
            //    MessageBox.Show("Your work time is not equal to 8h");
            //    return;
            //}

            AddNewEventMsgBox(TimeManager.GoHome(currentUser));
        }


        #region LOGOUT


        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Loguot();
        }

        private void Loguot()
        {
            currentUser = null;

            SignIn signInForm = new SignIn();
            signInForm.Show();
            this.Close();
        }


        #endregion LOGOUT

        private void addNewEventButton_Click(object sender, EventArgs e)
        {
            int minutesToCatchUp = Convert.ToInt32(addNewEventTextBox.Text);
            AddNewEventMsgBox(minutesToCatchUp);
        }

        private void AddNewEventMsgBox(int minutesToCatchUp)
        {
            string message = "";

            if (minutesToCatchUp == 0) { return; }
            else if (minutesToCatchUp > 0)
            {
                message = $"Are you sure you want to add {minutesToCatchUp} minutes to Your time to catchup?";
            }
            else if (minutesToCatchUp < 0)
            {
                message = $"Are you sure you want to subtract {Math.Abs(minutesToCatchUp)} minutes from Your time to catchup?";
            }

            DialogResult dialog = MessageBox.Show(message, "Add Event", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)     // Add new Event
            {
                TimeManager.AddNewEvent(currentUser.id, minutesToCatchUp);

                RefreshWindow();
            }
        }

        private void RefreshWindow()
        {
            eventsGridView.DataSource = User.GetAllUserEvents(currentUser.id);
            minutesToCatchUpTextBox.Text = TimeManager.CountMinutesToCatchUp(currentUser.id).ToString();
        }

        void FillWorkHoursTextBoxes()
        {
            string minutes = "0";
            if (currentUser.startWorkHour.Minute < 10)
            {
                minutes = "0" + currentUser.startWorkHour.Minute;
            }

            startHourTextBox.Text = $"{currentUser.startWorkHour.Hour}:{minutes}";

            if (currentUser.finishWorkHour.Minute < 10)
            {
                minutes = "0" + currentUser.finishWorkHour.Minute;
            }

            finishHourTextBox.Text = $"{currentUser.finishWorkHour.Hour}:{minutes}";
        }
    }
}

