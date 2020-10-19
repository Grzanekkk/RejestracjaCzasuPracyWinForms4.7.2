using System;
using System.Windows.Forms;
using DatabaseConnection;
using System.Configuration;
using System.Data;

namespace RejestracjaCzasuPracyWinForms
{
    public partial class HomePage : Form
    {
        User currentUser;
        TimeManager timeManager = new TimeManager();
        UserManager userManager = new UserManager();

        public HomePage(User _currentUser)
        {
            InitializeComponent();
            currentUser = _currentUser;
            RefreshWindow();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            nameLabel.Text = currentUser.name;
            CheckIfUserIsWorking();
            FillWorkHoursTextBoxes();
            RefreshWindow();
        }

        private void goHomeButton_Click(object sender, EventArgs e)
        {
            AddNewEventMsgBox(timeManager.CountMinutesToCatchUpFromNow(currentUser));
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


        #region Events

        private void AddNewEventButton_Click(object sender, EventArgs e)
        {
            int minutesToCatchUp = Convert.ToInt32(addNewEventTextBox.Text);
            AddNewEventMsgBox(minutesToCatchUp);
        }

        private void GoToSummaryButton_Click(object sender, EventArgs e)
        {
            AllUserSummaryForm summaryForm = new AllUserSummaryForm(currentUser);
            summaryForm.Show();
            this.Close();
        }

        private void UpdateRecordsButton_Click(object sender, EventArgs e)
        {
            DataTable changes = (DataTable)eventsGridView.DataSource;

            if (changes != null)
            {
                timeManager.UpdateEvents(changes);
            }

            RefreshWindow();
        }

        private void TimeInWorkCounterButton_Click(object sender, EventArgs e)
        {
            if (CheckIfUserIsWorking())
            {
                timeManager.StopWorking(currentUser.id);
            }
            else    // User is not working now
            {
                timeManager.StartWorking(currentUser.id);
            }

            RefreshWindow();
        }

        private void BreakButton_Click(object sender, EventArgs e)
        {

        }

        #endregion Events


        #region Methods


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
                timeManager.AddNewEvent(currentUser.id, minutesToCatchUp);

                RefreshWindow();
            }
        }

        private void RefreshWindow()
        {
            eventsGridView.DataSource = userManager.GetUserEvents(currentUser.id);
            eventsGridView.Columns["Date"].ReadOnly = true;
            eventsGridView.Columns["EventID"].Visible = false;
            eventsGridView.Columns["MemberID"].Visible = false;

            minutesToCatchUpTextBox.Text = timeManager.CountUserTimeToCatchUp(currentUser.id).ToString();
            CheckIfUserIsWorking();
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

        bool CheckIfUserIsWorking()
        {
            if (timeManager.CheckIfUserIsWorking(currentUser.id))
            {
                BreakButton.Visible = true;
                TimeInWorkCounterButton.Text = "Stop Working";
                return true;
            }
            else    // User is not working
            {
                BreakButton.Visible = false;
                TimeInWorkCounterButton.Text = "Start Working";
                return false;
            }
        }


        #endregion Methods
    }
}

