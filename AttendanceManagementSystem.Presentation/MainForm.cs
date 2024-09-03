using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceManagementSystem.Application;
using AttendanceManagementSystem.Domain.Enitities;
using AttendanceManagementSystem.Infrastructure;

namespace AttendanceManagementSystem.Presentation
{
    public partial class MainForm : Form
    {
        private ITimeSheet _timeSheet;
        public MainForm(ITimeSheet timeSheet)
        {
            InitializeComponent();
            _timeSheet = timeSheet;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            TimeSheetDataStorage.SaveTimeSheetToStorage((FileTimeSheet)_timeSheet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClockManagement corm = new ClockManagement(_timeSheet);
            corm.ShowDialog();
        }

        private void manageEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm(_timeSheet);
            form.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimeSheetDataStorage.SaveTimeSheetToStorage((FileTimeSheet)_timeSheet);
        }
    }
}
