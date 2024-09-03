using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceManagementSystem.Domain.Enitities;
using AttendanceManagementSystem.Application;

namespace AttendanceManagementSystem.Presentation
{
    public partial class EmployeeForm : Form
    {
        private ITimeSheet _timeSheet;

        public EmployeeForm(ITimeSheet timeSheet)
        {
            InitializeComponent();
            _timeSheet = timeSheet;
            LoadToGrid();
            updateButton.Enabled = false;
            saveButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            employeeIDTextBox.Clear();
            fullnameTextBox.Clear();
            positionTextBox.Clear();
            cardnoTextBox.Clear();
            fullnameTextBox.Focus();
            saveButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!IsValidName(fullnameTextBox.Text.Trim()))
            {
                MessageBox.Show("Full name must contain a first and last name separated by a space, and only letters.");
                return;
            }

            if (!IsValidPosition(positionTextBox.Text.Trim()))
            {
                MessageBox.Show("Position can only contain letters.");
                return;
            }

            if (!IsValidCardNumber(cardnoTextBox.Text.Trim()))
            {
                MessageBox.Show("Card number can only contain numbers.");
                return;
            }

            try
            {
                var emp = new Employee(fullnameTextBox.Text.Trim(), positionTextBox.Text.Trim(), cardnoTextBox.Text.Trim());
                _timeSheet.AddEmployee(emp);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addNewButton.Enabled = true;
                saveButton.Enabled = false;
            }
        }

        private void LoadToGrid()
        {
            dataGridView1.DataSource = _timeSheet.GetAllEmployee();
            dataGridView1.Refresh();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!IsValidName(fullnameTextBox.Text.Trim()))
            {
                MessageBox.Show("Full name must contain a first and last name separated by a space, and only letters.");
                return;
            }

            if (!IsValidPosition(positionTextBox.Text.Trim()))
            {
                MessageBox.Show("Position can only contain letters.");
                return;
            }

            if (!IsValidCardNumber(cardnoTextBox.Text.Trim()))
            {
                MessageBox.Show("Card number can only contain numbers.");
                return;
            }

            try
            {
                _timeSheet.UpdateEmployee(employeeIDTextBox.Text, fullnameTextBox.Text, positionTextBox.Text, cardnoTextBox.Text);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addNewButton.Enabled = true;
                saveButton.Enabled = false;
                updateButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(employeeIDTextBox.Text))
                {
                    MessageBox.Show("Please select an employee to delete.");
                    return;
                }
                _timeSheet.DeleteEmployee(employeeIDTextBox.Text);
                LoadToGrid();
                // Clear the text boxes after deletion
                employeeIDTextBox.Clear();
                fullnameTextBox.Clear();
                positionTextBox.Clear();
                cardnoTextBox.Clear();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addNewButton.Enabled = true;
                saveButton.Enabled = false;
                updateButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                employeeIDTextBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
                fullnameTextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
                positionTextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
                cardnoTextBox.Text = dataGridView1.SelectedCells[3].Value.ToString();
                addNewButton.Enabled = false;
                saveButton.Enabled = false;
                updateButton.Enabled = true;
                DeleteButton.Enabled = true; // Enable the delete button when a row is selected
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private bool IsValidName(string name)
        {
            // This regex ensures that the name contains only letters with a single space between the first and last names
            //return Regex.IsMatch(name, @"^[a-zA-Z]+\s[a-zA-Z]+$
            // This regex ensures that each part of the name is at least two characters long and allows for certain special characters.
            return Regex.IsMatch(name, @"^(?=.*[a-zA-Z]{2,})[a-zA-Z][a-zA-Z'`-]*(\s[a-zA-Z][a-zA-Z'`-]*)+$");
        }

        private bool IsValidPosition(string position) 
        {
            return Regex.IsMatch(position, @"^[a-zA-Z\s]+$");
        }

        private bool IsValidCardNumber(string cardNumber)
        {
            return Regex.IsMatch(cardNumber, @"^\d+$");
        }
    }
}
