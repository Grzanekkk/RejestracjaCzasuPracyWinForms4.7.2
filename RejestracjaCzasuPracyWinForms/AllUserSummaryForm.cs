using DatabaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RejestracjaCzasuPracyWinForms
{
    public partial class AllUserSummaryForm : Form
    {
        TimeManager timeManager = new TimeManager();
        User currentUser;
        public AllUserSummaryForm(User _currentUser)
        {
            currentUser = _currentUser;
            InitializeComponent();
            FillDataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillDataTable();   
        }

        void FillDataTable()
        {
            DataTable dataTabel = timeManager.GetAllUserTimeToCatchUp();

            if (dataTabel.Rows.Count !=0)
            {
                summaryGridView.DataSource = dataTabel;
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(currentUser);
            homePage.Show();
            this.Hide();
        }
    }
}
